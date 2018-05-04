using Ey.Model.Results;
using Ey.Model.Search;
using Ey.Services.SabreFareQuote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Services.Builders
{
    public class FlightFareQuoteBuilder
    {
        public MessageHeader GetFlightFareMessageHeader()
        {
            return new MessageHeader()
            {
                ConversationId = "EY_Test",
                From = new From() { PartyId = new PartyId[] { new PartyId() { type = "urn:x12.org:IO5:01", Value = "99999" } } },
                To = new To() { PartyId = new PartyId[] { new PartyId() { type = "urn:x12.org:IO5:01", Value = "123123" } } },
                CPAId = "JS",
                Service = new Service() { type = "OTA", Value = "SSSAdvShopRQ" },
                Action = "SSSAdvShopRQ",
                MessageData = new MessageData()
                {
                    MessageId = "mid:20001209-133003-2333@clientofsabre.com",
                    Timestamp = "2001-02-15T11:15:12Z",
                    TimeToLive = Convert.ToDateTime("2001-02-15T11:15:12Z")
                }
            };
        }

        public OTA_AirLowFareSearchRQ GetFlightFareSearchRequest(SearchCriteria searchCriteria)
        {
            string defaultCurrency = ConfigurationManager.AppSettings["DefaultCurrencyCode"];
            return new OTA_AirLowFareSearchRQ()
            {
                Version = "4.1.0",
                POS = new SourceType[] { new SourceType() { PseudoCityCode = searchCriteria != null && searchCriteria.Flights.Any() ? searchCriteria.Flights.First().Origin : "",
                    RequestorID = new UniqueID_Type() { Type="0.AAA.X", ID = "REQ.ID", CompanyName = new CompanyNameType() { Code = "SSW" } } }
                },
                OriginDestinationInformation = searchCriteria != null && searchCriteria.Flights.Any() ?
                searchCriteria.Flights.Select((flt, i) => new OTA_AirLowFareSearchRQOriginDestinationInformation()
                {
                    RPH = i.ToString(),
                    Item = String.Format("{0:s}", flt.DepartureDate),
                    ItemElementName = ItemChoiceType.DepartureDateTime,
                    OriginLocation = new OriginDestinationInformationTypeOriginLocation() { LocationCode = flt.Origin },
                    DestinationLocation = new OriginDestinationInformationTypeDestinationLocation() { LocationCode = flt.Destination },
                    TPA_Extensions = new OTA_AirLowFareSearchRQOriginDestinationInformationTPA_Extensions()
                    {
                        SegmentType = new ExchangeOriginDestinationInformationTypeSegmentType() { Code = ExchangeOriginDestinationInformationTypeSegmentTypeCode.O }
                    }
                }).ToArray() : null,
                TravelPreferences = new AirSearchPrefsType()
                {
                    VendorPref = new CompanyNamePrefType[] {
                        new CompanyNamePrefType() {
                            Code = "EY",
                            PreferLevel = PreferLevelType.Preferred
                        }
                    },
                    CabinPref = new CabinPrefType[] {
                        new CabinPrefType() {
                            Cabin = searchCriteria.CabinType.Trim().ToUpper() == "ECONOMY"? CabinType.Economy: searchCriteria.CabinType.Trim().ToUpper() == "BUSINESS"? CabinType.Business : CabinType.Y,
                            PreferLevel = PreferLevelType.Preferred
                        }
                    }
                },
                TravelerInfoSummary = new TravelerInfoSummaryType()
                {
                    SeatsRequested = new string[] { (searchCriteria.Adults + searchCriteria.Children + searchCriteria.Infants).ToString() },
                    AirTravelerAvail = new TravelerInformationType[] {
                        new TravelerInformationType() {
                             PassengerTypeQuantity = GetPaxInfo(searchCriteria).ToArray()
                        }
                    },
                    PriceRequestInformation = new PriceRequestInformationType()
                    {
                        FareQualifier = "false",
                        NegotiatedFaresOnly = false,
                        Reprice = false,
                        CurrencyCode = string.IsNullOrEmpty(defaultCurrency) ? "AED" : defaultCurrency.ToUpper()
                    }
                },
                TPA_Extensions = new OTA_AirLowFareSearchRQTPA_Extensions()
                {
                    IntelliSellTransaction = new TransactionType()
                    {
                        Debug = false,
                        RequestType = new TransactionTypeRequestType()
                        {
                            Name = "BRDFARES"
                        },
                        ServiceTag = new TransactionTypeServiceTag()
                        {
                            Name = "EY"
                        }
                    }
                }
            };
        }

        private IList<PassengerTypeQuantityType> GetPaxInfo(SearchCriteria criteria)
        {
            List<PassengerTypeQuantityType> paxInfo = new List<PassengerTypeQuantityType>();
            if (criteria.Adults > 0)
            {
                paxInfo.Add(new PassengerTypeQuantityType()
                {
                    Code = "ADT",
                    Quantity = criteria.Adults.ToString()
                });
            }
            if (criteria.Children > 0)
            {
                paxInfo.Add(new PassengerTypeQuantityType()
                {
                    Code = "CHD",
                    Quantity = criteria.Children.ToString()
                });
            }
            if (criteria.Infants > 0)
            {
                paxInfo.Add(new PassengerTypeQuantityType()
                {
                    Code = "INF",
                    Quantity = criteria.Infants.ToString()
                });
            }
            return paxInfo;
        }
        public FlightResults BuildResponse(Ey.Services.SabreFareQuote.OTA_AirLowFareSearchRS serviceRes)
        {
            FlightResults response = null;
            if (serviceRes != null && serviceRes.Items != null && serviceRes.Items.Any())
            {
                var itineraryObj = serviceRes.Items.FirstOrDefault(a => a.GetType() == typeof(OTA_AirLowFareSearchRSOneWayItineraries));
                if(itineraryObj != null)
                {
                    var itinerary = (OTA_AirLowFareSearchRSOneWayItineraries)itineraryObj;
                    var oneday = Task.Run(() => BuildOneDayItineraries(itinerary.BrandedOneWayItineraries));
                    var multiDay = Task.Run(() => BuildMultiDayItineraries(itinerary.SimpleOneWayItineraries));

                    Task.WaitAll();
                    response = new FlightResults()
                    {
                        OneDayItineraries = oneday.Result,
                        MultiDayItineraries = multiDay.Result
                    };
                }
            }

            return response;
        }

        private List<OneDayJourneySegment> BuildOneDayItineraries(OTA_AirLowFareSearchRSOneWayItinerariesBrandedOneWayItineraries[] oneWayItineraries)
        {
            if(oneWayItineraries != null && oneWayItineraries.Any())
            {
                List<OneDayJourneySegment> segments = new List<OneDayJourneySegment>();
                foreach(var seg in oneWayItineraries)
                {
                    var flights = BuildOneDayFlights(seg);
                    string org = flights != null && flights.Any() ? flights.First().Origin : seg.TPA_Extensions != null && seg.TPA_Extensions.Any() ? seg.TPA_Extensions.First().DepartureAirport : null;
                    string des = flights != null && flights.Any() ? flights.First().Destination : seg.TPA_Extensions != null && seg.TPA_Extensions.Any() ? seg.TPA_Extensions.First().ArrivalAirport : null;
                    DateTime date = flights != null && flights.Any() ? flights.First().DepartureDate : seg.TPA_Extensions != null && seg.TPA_Extensions.Any() ? seg.TPA_Extensions.First().DepartureDate : DateTime.MinValue;
                    segments.Add(new OneDayJourneySegment()
                    {
                        //flights != null && flights.Any() ? Convert.ToInt32(seg.PricedItinerary.First().CampaignID) : 
                        JourneySegmentId = Convert.ToInt32(seg.RPH),
                        Flights = BuildOneDayFlights(seg),
                        Origin = org,
                        Destination = des,
                        Date = date
                        //,MasterBrandList = 
                    });
                }
                return segments;
            }
            return null;
        }
        private List<Ey.Model.Common.Flight> BuildOneDayFlights(OTA_AirLowFareSearchRSOneWayItinerariesBrandedOneWayItineraries objItinerary)
        {
            if(objItinerary.PricedItinerary != null && objItinerary.PricedItinerary.Any())
            {
                return objItinerary.PricedItinerary.Select(flt => new Ey.Model.Common.Flight()
                {
                    LFID = Convert.ToInt32(flt.SequenceNumber),
                    Legs = BuildLegs(flt),
                    FlightFares = BuildFlightFares(flt)
                }).ToList();
            }
            return null;
        }

        private List<Ey.Model.Common.Leg> BuildLegs(PricedItineraryType flt)
        {
            List<Ey.Model.Common.Leg> legs = new List<Ey.Model.Common.Leg>();
            if (flt != null  && flt.AirItinerary != null && flt.AirItinerary.OriginDestinationOptions != null && flt.AirItinerary.OriginDestinationOptions.Any(a => a.FlightSegment != null && a.FlightSegment.Any()))
            {
                int pfid = 1;
                foreach (var obj in flt.AirItinerary.OriginDestinationOptions.Where(a => a.FlightSegment != null && a.FlightSegment.Any()))
                {
                    legs.AddRange(obj.FlightSegment.Select(lg => new Ey.Model.Common.Leg()
                    {
                        LFID = Convert.ToInt32(flt.SequenceNumber),
                        PFID = pfid++,
                        DepartureDate = Convert.ToDateTime(lg.DepartureDateTime),
                        ArrivalDate = Convert.ToDateTime(lg.ArrivalDateTime),
                        Origin = lg.DepartureAirport.LocationCode,
                        Destination = lg.ArrivalAirport.LocationCode,
                        OperatingCarrier = lg.OperatingAirline?.Code,
                        MarketingCarrier = lg.MarketingAirline?.Code,
                        EquipmentType = lg.Equipment != null && lg.Equipment.Any() ? lg.Equipment.First().AirEquipType : "",
                        FlightNum = lg.OperatingAirline?.FlightNumber,
                        FlightTime = lg.ElapsedTime,
                        FromTerminal = lg.DepartureAirport.TerminalID,
                        ToTerminal = lg.DepartureAirport.TerminalID
                    }));
                }
            }

            return legs;
        }

        private List<FlightFare> BuildFlightFares(PricedItineraryType type)
        {
            return null;
        }

        private List<MultipleDayJourneySegment> BuildMultiDayItineraries(OTA_AirLowFareSearchRSOneWayItinerariesSimpleOneWayItineraries[] multiDayWayItineraries)
        {
            return null;
        }
    }
}
