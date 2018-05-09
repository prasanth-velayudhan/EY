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
            string poc = searchCriteria != null && searchCriteria.Flights.Any() ? searchCriteria.Flights.First().Origin : "";
            string defaultCurrency = Common.Constants.AirportCurrencyCodes.ContainsKey(poc) ? Common.Constants.AirportCurrencyCodes[poc] : ConfigurationManager.AppSettings["DefaultCurrencyCode"];
            return new OTA_AirLowFareSearchRQ()
            {
                Version = "4.1.0",
                POS = new SourceType[] { new SourceType() { PseudoCityCode = poc,
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
                            Cabin = searchCriteria.CabinType.Trim().ToUpper() == "ECONOMY"? CabinType.Economy: searchCriteria.CabinType.Trim().ToUpper() == "BUSINESS"? CabinType.Business : searchCriteria.CabinType.Trim().ToUpper() == "FIRST"? CabinType.First : CabinType.Y,
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
        public FlightResults BuildResponse(Ey.Services.SabreFareQuote.OTA_AirLowFareSearchRS serviceRes, string currencyCode)
        {
            FlightResults response = null;
            if (serviceRes != null && serviceRes.Items != null && serviceRes.Items.Any())
            {
                var itineraryObj = serviceRes.Items.FirstOrDefault(a => a.GetType() == typeof(OTA_AirLowFareSearchRSOneWayItineraries));
                if (itineraryObj != null)
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

            if(response != null && response.MultiDayItineraries != null && response.MultiDayItineraries.Any())
            {
                response.MultiDayItineraries.First().CurrentDisplayCurrency = currencyCode;
            }
            if (response != null && response.OneDayItineraries != null && response.OneDayItineraries.Any())
            {
                response.OneDayItineraries.First().CurrentDisplayCurrency = currencyCode;
            }
            return response;
        }

        private List<OneDayJourneySegment> BuildOneDayItineraries(OTA_AirLowFareSearchRSOneWayItinerariesBrandedOneWayItineraries[] oneWayItineraries)
        {
            if (oneWayItineraries != null && oneWayItineraries.Any())
            {
                List<OneDayJourneySegment> segments = new List<OneDayJourneySegment>();
                foreach (var seg in oneWayItineraries)
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
            if (objItinerary.PricedItinerary != null && objItinerary.PricedItinerary.Any())
            {
                return objItinerary.PricedItinerary.Select(flt => new Ey.Model.Common.Flight()
                {
                    LFID = Convert.ToInt32(flt.SequenceNumber),
                    Legs = BuildLegs(flt.AirItinerary, flt.SequenceNumber),
                    FlightFares = GetFlightFares(flt.TPA_Extensions),
                    flighttime = flt.AirItinerary != null && flt.AirItinerary.OriginDestinationOptions != null && flt.AirItinerary.OriginDestinationOptions.Any() ? flt.AirItinerary.OriginDestinationOptions.First().ElapsedTime : 0
                }).ToList();
            }
            return null;
        }

        private List<Ey.Model.Common.Leg> BuildLegs(AirItineraryType airItinerary, string lfid)
        {
            List<Ey.Model.Common.Leg> legs = new List<Ey.Model.Common.Leg>();
            if (airItinerary != null && airItinerary.OriginDestinationOptions != null && airItinerary.OriginDestinationOptions.Any(a => a.FlightSegment != null && a.FlightSegment.Any()))
            {
                int pfid = 1;
                foreach (var obj in airItinerary.OriginDestinationOptions.Where(a => a.FlightSegment != null && a.FlightSegment.Any()))
                {
                    legs.AddRange(obj.FlightSegment.Select(lg => new Ey.Model.Common.Leg()
                    {
                        LFID = Convert.ToInt32(lfid),
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

        private List<FlightFare> GetFlightFares(PricedItineraryTypeTPA_Extensions tpa)
        {
            if (tpa != null && tpa.AdditionalFares != null && tpa.AdditionalFares.Any(a => a.AirItineraryPricingInfo != null && a.AirItineraryPricingInfo.FareReturned))
            {
                return tpa.AdditionalFares.Where(a => a.AirItineraryPricingInfo != null && a.AirItineraryPricingInfo.FareReturned).SelectMany(fare => BuildFlightFare(fare)).ToList();
            }

            return null;
        }

        private IList<FlightFare> BuildFlightFare(PricedItineraryTypeTPA_ExtensionsAdditionalFares fare)
        {
            int id = 0;
            var fr = from pax in fare.AirItineraryPricingInfo.PTC_FareBreakdowns
                     where pax.FareBasisCodes != null
                     select new FlightFare()
                     {
                         PaxId = (++id).ToString(),
                         FareBrandId = fare.AirItineraryPricingInfo.BrandID,
                         FareTypeId = fare.AirItineraryPricingInfo.BrandID,
                         FareTypeName = fare.AirItineraryPricingInfo.BrandID,
                         FareAmount = pax.PassengerFare != null && pax.PassengerFare.TotalFare != null ? pax.PassengerFare.TotalFare.Amount : 0,
                         WebFareAmount = pax.PassengerFare != null && pax.PassengerFare.TotalFare != null ? pax.PassengerFare.TotalFare.Amount : 0,
                         PaxCount = pax.PassengerTypeQuantity != null ? Convert.ToInt32(pax.PassengerTypeQuantity.Quantity) : 0,
                         PassengerTypeId = pax.PassengerTypeQuantity != null ? getPaxType(pax.PassengerTypeQuantity.Code) : Common.Enums.PassengerTypes.Adult,
                         FareBasisCode = pax.FareBasisCodes != null ? pax.FareBasisCodes.First().Value : "",
                         IsPrivateFare = !string.IsNullOrEmpty(pax.PrivateFareType),
                         Cabin = pax.FareInfos != null && pax.FareInfos.Any(a => a.TPA_Extensions != null) ? pax.FareInfos.First().TPA_Extensions.Cabin.Cabin : "",
                         SeatsAvailable = pax.FareInfos != null && pax.FareInfos.Any(a => a.TPA_Extensions != null) ? pax.FareInfos.First().TPA_Extensions.SeatsRemaining.Number : 0,
                         DisplayAmountNoTaxes = pax.PassengerFare != null ? pax.PassengerFare.EquivFare.Amount : 0,
                         Taxes = pax.PassengerFare != null && pax.PassengerFare.Taxes != null && pax.PassengerFare.Taxes.TotalTax != null ? pax.PassengerFare.Taxes.TotalTax.Amount : 0,
                         FareAmtNoTaxes = pax.PassengerFare != null ? pax.PassengerFare.EquivFare.Amount : 0
                     };

            return fr.ToList();
        }

        private Common.Enums.PassengerTypes getPaxType(string code)
        {
            return code == "ADT" ? Common.Enums.PassengerTypes.Adult : code == "CHD" ? Common.Enums.PassengerTypes.Child : Common.Enums.PassengerTypes.Infant;
        }

        private List<MultipleDayJourneySegment> BuildMultiDayItineraries(OTA_AirLowFareSearchRSOneWayItinerariesSimpleOneWayItineraries[] multiDayWayItineraries)
        {
            List<MultipleDayJourneySegment> multiSegs = new List<MultipleDayJourneySegment>();
            if (multiDayWayItineraries != null && multiDayWayItineraries.Any(a => a.PricedItinerary != null && a.PricedItinerary.Any()))
            {
                multiSegs.AddRange(multiDayWayItineraries.Where(a => a.PricedItinerary != null && a.PricedItinerary.Any()).SelectMany(b => GetMultiDaySegment(b.RPH, b.PricedItinerary)).ToList());
            }

            if (multiDayWayItineraries.Any(a => a.TPA_Extensions != null))
            {
                foreach (var p in multiDayWayItineraries.Where(a => a.TPA_Extensions != null))
                {
                    multiSegs.AddRange(p.TPA_Extensions.Select(emptyFlt => new MultipleDayJourneySegment()
                    {
                        Origin = emptyFlt.DepartureAirport,
                        Destination = emptyFlt.ArrivalAirport,
                        SearchedFromDate = emptyFlt.DepartureDate,
                        JourneySegmentId = Convert.ToInt32(p.RPH),
                        DayLowestFares = new List<DayLowestFare>() { new DayLowestFare
                        {
                            Date = emptyFlt.DepartureDate.Date,
                            FareAmount = 0,
                            WebFareAmount = 0,
                            WebFareAmountNoTax = 0,
                            WebTaxSum = 0,
                            FareType = 0,
                            AvailableSeats = 0,
                            isSoldOut = true,
                            isCodeShare = false,
                            isInterline = false
                        }}
                    }));
                }
            }

            return multiSegs;
        }

        private List<MultipleDayJourneySegment> GetMultiDaySegment(string Rph, PricedItineraryType[] PricedItinerary)
        {
            List<MultipleDayJourneySegment> segs = new List<MultipleDayJourneySegment>();
            foreach (var days in PricedItinerary)
            {
                var flts = BuildMultiDayFlight(days);
                if (flts != null && flts.Any())
                {
                    var flt = flts.First();
                    segs.Add(new MultipleDayJourneySegment()
                    {
                        JourneySegmentId = Convert.ToInt32(Rph),
                        Origin = flt.Origin,
                        Destination = flt.Destination,
                        SearchedFromDate = flt.DepartureDate,
                        SearchedToDate = flt.ArrivalDate,
                        DayLowestFares = BuildLowestFare(days.AirItineraryPricingInfo, flt.DepartureDate)
                    });
                }
            }
            return segs;
        }

        private IList<Ey.Model.Common.Flight> BuildMultiDayFlight(PricedItineraryType flt)
        {
            if (flt != null && flt.AirItinerary != null && flt.AirItinerary.OriginDestinationOptions != null && flt.AirItinerary.OriginDestinationOptions.Any(a => a.FlightSegment != null && a.FlightSegment.Any()))
            {
                return flt.AirItinerary.OriginDestinationOptions.Where(a => a.FlightSegment != null && a.FlightSegment.Any()).Select(ft => new Ey.Model.Common.Flight()
                {
                    LFID = Convert.ToInt32(flt.SequenceNumber),
                    Legs = BuildLegs(flt.AirItinerary, flt.SequenceNumber)
                }).ToList();
            }
            return null;
        }
        private List<DayLowestFare> BuildLowestFare(PricedItineraryTypeAirItineraryPricingInfo[] airItineraryPricingInfo, DateTime date)
        {
            List<DayLowestFare> lowestFares = new List<DayLowestFare>();
            if (airItineraryPricingInfo != null && airItineraryPricingInfo.Any())
            {
                var obj = airItineraryPricingInfo.First();

                lowestFares.Add(new DayLowestFare()
                {
                    Date = date,
                    FareAmount = obj.ItinTotalFare != null && obj.ItinTotalFare.TotalFare != null ? obj.ItinTotalFare.TotalFare.Amount : 0,
                    WebFareAmount = obj.ItinTotalFare != null && obj.ItinTotalFare.TotalFare != null ? obj.ItinTotalFare.TotalFare.Amount : 0,
                    WebFareAmountNoTax = obj.ItinTotalFare != null && obj.ItinTotalFare.EquivFare != null ? obj.ItinTotalFare.EquivFare.Amount : 0,
                    WebTaxSum = obj.ItinTotalFare != null && obj.ItinTotalFare.Taxes != null && obj.ItinTotalFare.Taxes.Tax != null && obj.ItinTotalFare.Taxes.Tax.Any(a => a.TaxCode == "TOTALTAX") ? obj.ItinTotalFare.Taxes.Tax.First(a => a.TaxCode == "TOTALTAX").Amount : 0,
                    FareType = 0,
                    AvailableSeats = obj.FareInfos.First().TPA_Extensions.SeatsRemaining.Number
                });
            }

            return lowestFares;
        }
    }
}
