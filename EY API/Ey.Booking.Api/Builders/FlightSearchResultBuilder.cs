﻿using Ey.Booking.Api.Models;
using Ey.Common;
using Ey.Common.Helpers;
using Ey.Model.Booking;
using Ey.Model.Common;
using Ey.Model.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ey.Booking.Api.Builders
{
    public class FlightSearchResultBuilder
    {
        private string currency;
        private Model.Search.SearchCriteria searchCriteria;
        private Model.SecurityData _securityData;
        public bool IsInclude;

        public List<Segments> BuildResponse(Model.Results.FlightResults response, Model.Search.SearchCriteria searchCriteria, Model.SecurityData securityData)
        {
            this.searchCriteria = searchCriteria;
            this._securityData = securityData;
            List<Segments> segments = new List<Segments>();
            if (response.OneDayItineraries != null && response.OneDayItineraries.Count > 0)
            {
                currency = response.OneDayItineraries.First().CurrentDisplayCurrency;
                for (int i = 0; i < response.OneDayItineraries.Count(); ++i)
                {
                    OneDayJourneySegment segmentItem = response.OneDayItineraries[i];
                    Segments segment = new Segments();
                    segment.Origin = segmentItem.Origin;
                    segment.Dest = segmentItem.Destination;
                    segment.CurrencyCode = currency;
                    segment.DepartureDate = String.Format("{0:s}", segmentItem.Date);
                    segment.Direction = searchCriteria.Flights[i].FlightDirection.ToLower() == Direction.multiSector.ToString().ToLower() ? Direction.multiSector : searchCriteria.Flights[i].FlightDirection.ToLower() == "inbound" ? Direction.inBound : Direction.outBound;
                    segment.Route = string.Format("{0}_{1}", segment.Origin, segment.Dest);
                    
                    segment.Flights = BuildFlights(segmentItem, false);
                    var distinctFareBrands = segment.Flights.SelectMany(x => x.FareTypes).Select(x =>
                                     new FareBrandInfo()
                                     {
                                         FareTypeID = x.FareTypeID,
                                         FareTypeName = x.FareTypeName,
                                         CabinType = x.Cabin.ToString(),
                                         OrderId = getFareOrderId(x.FareTypeID)
                                     }
                                     ).GroupBy(fb => fb.FareTypeID).OrderBy(x => x.Key)
                                     .Select(g => g.First());


                    segment.Brands = new List<Brand>();
                    foreach (var brandInfo in distinctFareBrands.OrderBy(a => a.OrderId))
                    {
                        segment.Brands.Add(new Brand
                        {
                            FareTypeID = brandInfo.FareTypeID.ToString(),
                            Cabin = brandInfo.CabinType.ToUpper() == "BUSINESS" ? Cabin.business : brandInfo.CabinType.ToUpper() == "ECONOMY" ? Cabin.economy : Cabin.first,
                            Name = Constants.FareBrandIds.Where(x => x.Key == brandInfo.FareTypeName).FirstOrDefault().Value,
                            IncludedServices = BuildBrandIncludeServices(response.BrandedFareInfo, segmentItem.JourneySegmentId, brandInfo.FareTypeID.ToString()),
                            OrderId = brandInfo.OrderId
                        });
                    }
                    segment.Notifications = new List<Notification>();
                    if (segment.Flights.Count == 0)
                    {
                        //ExceptionMessage message = (ExceptionMessage)_exceptionResourceManager.GetObject("NoFlights");
                        segment.Notifications.Add(new Notification
                        {
                            CmsKey = "NoFlights",
                            DefaultMessage = "NoFlights",
                            DisplayLevel = "S"
                        });
                    }

                    segment.MultiDayFlights = BuildMultiDaySegments(response.MultiDayItineraries.Where(a => a.JourneySegmentId == segmentItem.JourneySegmentId).ToList(), 7);

                    segments.Add(segment);
                }
            }
            
            return segments;
        }
        public static T GetPropertyValue<T>(object obj, string propName) { return (T)obj.GetType().GetProperty(propName).GetValue(obj, null); }

        private Dictionary<IncludeServiceType, string> BuildBrandIncludeServices(List<BrandedFareInfo> BrandedFareInfo, int segmentId, string faretypeId = "")
        {
            try
            {
                Dictionary<IncludeServiceType, string> includedItems = new Dictionary<IncludeServiceType, string>();
                if (BrandedFareInfo != null && BrandedFareInfo.Any(a => a.SegmentId == segmentId))
                {
                    var brand = BrandedFareInfo.FirstOrDefault(a => a.SegmentId == segmentId);
                    if (brand != null && brand.baggage != null)
                    {
                        string value = GetPropertyValue<string>(brand.baggage, faretypeId.ToLower() + "Values");
                        if (!string.IsNullOrEmpty(value))
                        {
                            includedItems.Add(IncludeServiceType.CHKDBAG, value);
                        }
                    }

                    if (brand != null && brand.upgrade != null)
                    {
                        string value = GetPropertyValue<string>(brand.upgrade, faretypeId.ToLower() + "Values");
                        if (!string.IsNullOrEmpty(value))
                        {
                            includedItems.Add(IncludeServiceType.UPGRELG, (value.EndsWith("Upgrade.Yes") ? true : false).ToString());
                        }
                    }
                    if (brand != null && brand.refund != null)
                    {
                        BrandedFareInfo.changeValues value = GetPropertyValue<BrandedFareInfo.changeValues>(brand.refund, faretypeId.ToLower() + "Values");
                        if (value != null)
                        {
                            includedItems.Add(IncludeServiceType.RFNDELG, value.isRefundable.ToString());
                            if (value.isRefundable && !string.IsNullOrEmpty(value.charge))
                            {
                                includedItems.Add(IncludeServiceType.RFNDFEE, value.charge.Split('|').First());
                            }
                        }
                    }
                    if (brand != null && brand.preferredSeat != null)
                    {
                        string value = GetPropertyValue<string>(brand.preferredSeat, faretypeId.ToLower() + "Values");
                        if (!string.IsNullOrEmpty(value) && value.Contains('.'))
                        {
                            includedItems.Add(IncludeServiceType.PRFSEAT, value.Split('.').Last());
                        }
                    }

                    if (brand != null && brand.milesEarned != null)
                    {
                        BrandedFareInfo.ErnedValues value = GetPropertyValue<BrandedFareInfo.ErnedValues>(brand.milesEarned, faretypeId.ToLower() + "Values");
                        if (value != null && !string.IsNullOrEmpty(value.etihad) && value.etihad.EndsWith(".Miles") && value.etihad.Contains('|'))
                        {
                            includedItems.Add(IncludeServiceType.MILEARN, value.etihad.Split('|').First());
                        }
                    }

                    if (brand != null && brand.checkIn != null)
                    {
                        string value = GetPropertyValue<string>(brand.checkIn, faretypeId.ToLower() + "Values");
                        if (!string.IsNullOrEmpty(value))
                        {
                            includedItems.Add(IncludeServiceType.PRCHKIN, (value.EndsWith("Priority.Yes") ? true : false).ToString());
                        }
                    }
                    if (brand != null && brand.changeTravel != null)
                    {
                        BrandedFareInfo.changeValues value = GetPropertyValue<BrandedFareInfo.changeValues>(brand.changeTravel, faretypeId.ToLower() + "Values");
                        if (value != null)
                        {
                            includedItems.Add(IncludeServiceType.CHDTELG, value.isChangeable.ToString());
                            if (value.isChangeable && !string.IsNullOrEmpty(value.charge))
                            {
                                includedItems.Add(IncludeServiceType.CHDTFEE, value.charge.Split('|').First());
                            }
                        }
                    }
                }
                return includedItems;
            }
            catch (Exception ex)
            {
                return new Dictionary<IncludeServiceType, string>()
                {
                    {IncludeServiceType.RFNDELG, "true"},
                    {IncludeServiceType.CHDTELG, "true"},
                    {IncludeServiceType.UPGRELG, "true"},
                    {IncludeServiceType.PRCHKIN, "true"},
                    {IncludeServiceType.CHKDBAG, "30KG"},
                    {IncludeServiceType.MILEARN, "500"},
                    {IncludeServiceType.CHDTFEE, "AED 100"},
                    {IncludeServiceType.RFNDFEE, "AED 100"},
                };
            }
        }

        private int getFareOrderId(string brandId)
        {
            if (Enum.IsDefined(typeof(Ey.Common.Enums.FareBrandOrder), (brandId ?? "").Trim()))
            {
                return (int)Enum.Parse(typeof(Ey.Common.Enums.FareBrandOrder), brandId.Trim());
            }
            return 0;
        }

        public List<Flights> BuildFlights(OneDayJourneySegment segmentItem, bool IsRerpice)
        {
            List<Flights> flights = new List<Flights>();
            if (segmentItem != null)
            {
                List<Flight> flightList = new List<Flight>();
                flightList = segmentItem.Flights.OrderBy(x => GetCheapflightFare(x.FlightFares)).ThenBy(x => x.Duration)//.ThenBy(x => x.GetUtcDepartureDate())
                    .ToList();

                foreach (var flightItem in flightList)
                {
                    Flights flight = new Flights();
                    flight.Origin = flightItem.Origin;
                    flight.Dest = flightItem.Destination;
                    flight.LfId = Convert.ToString(flightItem.LFID);
                    flight.DepartureDate = flightItem.DepartureDate.ToString();
                    flight.ArrivalTime = String.Format("{0:s}", flightItem.ArrivalDate);
                    flight.DepartureTime = String.Format("{0:s}", flightItem.DepartureDate);
                    flight.Stops = BuildStops(flightItem);
                    if ((int)flightItem.Duration.TotalHours > 9)
                        flight.TotalDuration = string.Format("{0}:{1:mm}", (int)flightItem.Duration.TotalHours, flightItem.Duration);
                    else
                        flight.TotalDuration = string.Format("{0:hh}:{1:mm}", flightItem.Duration, flightItem.Duration);
                    flight.IsAvailabile = flightItem.FlightFares.Any(x => !x.IsSoldOut(searchCriteria.Adults + searchCriteria.Children));
                    flight.Legs = BuildLegs(flightItem);
                    flight.FareTypes = BuildFares(flightItem, IsRerpice);
                    flight.FlightNum = flightItem.FlightNum;
                    flights.Add(flight);
                }
            }
            return flights;
        }

        public List<FareTypes> BuildFares(Flight flightItem, bool IsRerpice)
        {
            List<FareTypes> fareTypes = new List<FareTypes>();
            if (flightItem != null)
            {
                var fTypes = (flightItem.FlightFares.OrderByDescending(x => x.Cabin).ThenBy(x => x.WebFareAmount).GroupBy(x => new { x.FareTypeId, x.SolutionID }).ToList());
                if (fTypes != null)
                {
                    foreach (var fType in fTypes)
                    {
                        FareTypes fareType = new FareTypes();
                        fareType.FareTypeID = fType.FirstOrDefault().FareTypeName;
                        fareType.FareTypeName = fType.FirstOrDefault().FareTypeName;
                        fareType.ContainsCircularFlight = IsCircularFlight(flightItem).Value;
                        fareType.ContainsConnectionFlight = IsConnectionFlight(flightItem).Value;
                        fareType.FareInformation = BuildFlightFareInformation(fType, IsRerpice);
                        fareType.Fare = BuildFlightFare(fareType.FareInformation);
                        //fareType.Fare.SolutionId = Convert.ToString(fType.Key.SolutionID);
                        //fareType.Fare.Combinables = BuildCombinableList(fType.Key.SolutionID);
                        fareType.FareCarrier = fType.FirstOrDefault().FareCarrier;
                        //fareType.TicketDesignator = fType.FirstOrDefault().TicketDesignator;
                        //fareType.HashCode = fType.FirstOrDefault().HashCode;
                        fareType.LfId = Convert.ToString(flightItem.LFID);
                        //fareType.PfIds = GetPhysicalFlightIds(flightItem, fType.FirstOrDefault().Bookingcodes, fType.FirstOrDefault().Cabin);
                        fareType.Route = String.Format("{0}_{1}", flightItem.Origin, flightItem.Destination);
                        fareType.Cabin = (fType.FirstOrDefault().FareTypeName.IndexOf('J') != -1 ? Cabin.business : fType.FirstOrDefault().FareTypeName.IndexOf('Y') != -1 ? Cabin.economy : fType.FirstOrDefault().FareTypeName.IndexOf('F') != -1 ? Cabin.first : Cabin.first);
                        //if (fType.FirstOrDefault(x => x.PassengerTypeId == Enums.PassengerTypes.Adult) != null)
                        //{
                        //    fareType.IncludedServices = BuildIncludedServices(fType.FirstOrDefault(a => a.PassengerTypeId == Enums.PassengerTypes.Adult) ?? fType.FirstOrDefault());
                        //}
                        //else if (IsRerpice && fType.FirstOrDefault(x => x.PassengerTypeId == Enums.PassengerTypes.Child) != null)
                        //{
                        //    fareType.IncludedServices = BuildIncludedServices(fType.FirstOrDefault(a => a.PassengerTypeId == Enums.PassengerTypes.Child) ?? fType.FirstOrDefault());
                        //}
                        fareType.IsSoldOut = fType.FirstOrDefault().IsSoldOut();
                        fareType.Fare.IsPromoFare = fType.FirstOrDefault().IsPromoFare;
                        //fareType.Fare.IsPromoCodeApplied = fType.FirstOrDefault().IsPromoCodeApplied;
                        //fareType.Fare.IsStopOverFare = (fType.FirstOrDefault(a => a.PassengerTypeId == Enums.PassengerTypes.Adult) ?? fType.FirstOrDefault()).IsStopOverFare;
                        fareType.SeatsLeft = fType.FirstOrDefault().SeatsAvailable;
                        //if (fareType.Cabin == Cabin.business && fType.FirstOrDefault().SeatsAvailable <= _settingsTasks.SeatThresholdBusiness)
                        //{
                        //    fareType.SeatsLeft = fType.FirstOrDefault().SeatsAvailable;
                        //}
                        //else if (fareType.Cabin == Cabin.economy && fType.FirstOrDefault().SeatsAvailable <= _settingsTasks.SeatThresholdEconomy)
                        //{
                        //    fareType.SeatsLeft = fType.FirstOrDefault().SeatsAvailable;
                        //}
                        fareType.SecureHash = new HashService().GenerateHash(new
                        {
                            LfId = fareType.LfId,
                            FareTypeID = fareType.FareTypeID,
                            FareTypeName = fareType.FareTypeName,
                            Cabin = fareType.Cabin,
                            Fare = fareType.Fare,
                            FareInformation = fareType.FareInformation,
                            scToken = this.IsInclude && this._securityData != null && !string.IsNullOrEmpty(this._securityData.SabreToken) ? this._securityData.SabreToken : string.Empty
                        });

                        fareType.OrderId = getFareOrderId(fType.FirstOrDefault().FareBrandId);
                        fareTypes.Add(fareType);
                    }
                }
            }

            return fareTypes.OrderBy(a => a.OrderId).ToList();
        }
        
        public List<Legs> BuildLegs(Flight flightItem)
        {
            List<Legs> legs = new List<Legs>();
            if (flightItem != null)
            {
                string preflightNum = "";

                foreach (var legItem in flightItem.Legs)
                {
                    Legs leg = new Legs();
                    leg.ArrivalDate = String.Format("{0:s}", legItem.ArrivalDate);
                    leg.ArrivalTime = legItem.ArrivalTime;
                    leg.DepartureDate = String.Format("{0:s}", legItem.DepartureDate);
                    leg.DepartureTime = legItem.DepartureTime;
                    leg.PfId = Convert.ToString(legItem.PFID);
                    leg.Destination = legItem.Destination;
                    leg.FlightDuration = TimeSpan.FromMinutes(legItem.FlightTime).ToString(@"hh\:mm");
                    leg.FlightNumber = legItem.FlightNum;
                    leg.IsCircularNextLeg = (legItem.FlightNum == preflightNum);
                    preflightNum = legItem.FlightNum;
                    leg.Origin = legItem.Origin;
                    //leg.HasFreeMeals = _settingsTasks.MealInclusiveAirportsList != null &&
                    //                   _settingsTasks.MealInclusiveAirportsList.Any(
                    //                       x => x == legItem.Origin || x == legItem.Destination);
                    //leg.IsBusRoute = lstBusRoutes.Any(a => a.AirportCode.Trim() == leg.Origin.Trim() || a.AirportCode.Trim() == leg.Destination.Trim());
                    leg.IsBusRoute = leg.EquipmentType == "BUS";
                    leg.FromTerminal = legItem.FromTerminal;
                    leg.ToTerminal = legItem.ToTerminal;
                    leg.OperatingCarrier = legItem.OperatingCarrier;
                    leg.MarketingCarrier = legItem.MarketingCarrier;
                    leg.MarketingFlightNum = legItem.MarketingFlightNum;
                    leg.EquipmentType = legItem.EquipmentType;
                    legs.Add(leg);
                }
            }
            return legs;
        }

        private Dictionary<string, decimal> GetLowestAdultFarePerPax(OneDayJourneySegment segmentItem)
        {
            Dictionary<string, decimal> lowestFare = new Dictionary<string, decimal>();

            if (segmentItem != null)
            {
                List<FlightFare> adultNonSoldOutFares = segmentItem.Flights.SelectMany(f => f.FlightFares).Where(ff => !ff.IsSoldOut(searchCriteria.Adults + searchCriteria.Children) && ff.PassengerTypeId == Enums.PassengerTypes.Adult).ToList();
                if (adultNonSoldOutFares != null && adultNonSoldOutFares.Count() > 0)
                {
                    lowestFare.Add("lowestAdultFarePerPax", adultNonSoldOutFares.Min(ff => ff.WebFareAmount));
                    lowestFare.Add("lowestAdultBaseFarePerPax", adultNonSoldOutFares.Min(ff => ff.DisplayAmountNoTaxes));
                    lowestFare.Add("lowestAdultTaxPerPax", adultNonSoldOutFares.Min(ff => ff.Taxes));
                }
            }

            return lowestFare;
        }

        private IList<Stops> BuildStops(Flight flightItem)
        {
            List<Stops> stops = new List<Stops>();
            if (flightItem != null)
            {
                for (int i = 1; i < flightItem.Legs.Count(); ++i)
                {
                    Stops stop = new Stops();
                    stop.StopLocation = flightItem.Legs[i].Origin;
                    stop.LayOverTime = flightItem.Legs[i].DepartureDate.Subtract(flightItem.Legs[i - 1].ArrivalDate).ToString(@"hh\:mm");
                    stop.NotConnection = (flightItem.Legs[i].FlightNum == flightItem.Legs[i - 1].FlightNum);

                    stops.Add(stop);
                }
            }
            return stops;
        }
                
        private FareInformation BuildFlightFareInformation<T>(IGrouping<T, FlightFare> fType, bool isReprice)
        {
            FareInformation fareInformation = new FareInformation();
            if (fType != null)
            {
                var adulFareInfos = isReprice ? fType.ToList().Where(f => f.PassengerTypeId == Enums.PassengerTypes.Adult && f.WebFareAmount == fType.ToList().Where(g => g.PassengerTypeId == Enums.PassengerTypes.Adult).Min(d => d.WebFareAmount)).GroupBy(x => x.FareAmount) :
                    fType.ToList().Where(f => f.PassengerTypeId == Enums.PassengerTypes.Adult).GroupBy(x => x.FareAmount);

                if (adulFareInfos != null)
                {
                    var AdultFares = new List<AdultFares>();
                    foreach (var adulFareInfo in adulFareInfos)
                    {
                        AdultFares adultFare = new AdultFares();
                        adultFare.FareId = Convert.ToString(adulFareInfo.First().FareId);
                        adultFare.FareBasisCode = adulFareInfo.First().FareBasisCode;
                        adultFare.FareClass = adulFareInfo.First().FareClass;
                        adultFare.AdultFarePerPax = CurrencyHelper.ToString(currency, adulFareInfo.First().WebFareAmount);
                        adultFare.BaseAdultFarePerPax = CurrencyHelper.ToString(currency, adulFareInfo.First().DisplayAmountNoTaxes).Replace(",", "");
                        adultFare.DiscountPerPax = CurrencyHelper.ToString(currency, adulFareInfo.First().Discount);
                        adultFare.PaxCount = searchCriteria.Adults;
                        adultFare.TaxPerPax = CurrencyHelper.ToString(currency, adulFareInfo.First().Taxes);
                        AdultFares.Add(adultFare);
                    }
                    fareInformation.AdultFares = AdultFares;
                }
                var childFareInfos = isReprice ? fType.ToList().Where(f => f.PassengerTypeId == Enums.PassengerTypes.Child && f.WebFareAmount == fType.ToList().Where(g => g.PassengerTypeId == Enums.PassengerTypes.Child).Min(d => d.WebFareAmount)).GroupBy(x => x.FareAmount) :
                    fType.ToList().Where(f => f.PassengerTypeId == Enums.PassengerTypes.Child).GroupBy(x => x.FareAmount);
                if (childFareInfos != null)
                {
                    var ChildFares = new List<ChildFares>();
                    foreach (var childFareInfo in childFareInfos)
                    {
                        ChildFares childFare = new ChildFares();
                        childFare.FareId = Convert.ToString(childFareInfo.First().FareId);
                        childFare.FareBasisCode = childFareInfo.First().FareBasisCode;
                        childFare.FareClass = childFareInfo.First().FareClass;
                        childFare.ChildFarePerPax = CurrencyHelper.ToString(currency, childFareInfo.First().WebFareAmount);
                        childFare.BaseChildFarePerPax = CurrencyHelper.ToString(currency, childFareInfo.First().DisplayAmountNoTaxes).Replace(",", "");
                        childFare.DiscountPerPax = CurrencyHelper.ToString(currency, childFareInfo.First().Discount);
                        childFare.PaxCount = searchCriteria.Children;
                        childFare.TaxPerPax = CurrencyHelper.ToString(currency, childFareInfo.First().Taxes);
                        ChildFares.Add(childFare);
                    }
                    fareInformation.ChildFares = ChildFares;
                }
                var infantFareInfos = isReprice ? fType.ToList().Where(f => f.PassengerTypeId == Enums.PassengerTypes.Infant && f.WebFareAmount == fType.ToList().Where(g => g.PassengerTypeId == Enums.PassengerTypes.Infant).Min(d => d.WebFareAmount)).GroupBy(x => x.FareAmount) :
                    fType.ToList().Where(f => f.PassengerTypeId == Enums.PassengerTypes.Infant).GroupBy(x => x.FareAmount);
                if (infantFareInfos != null)
                {
                    var InfantFares = new List<InfantFares>();
                    foreach (var infantFareInfo in infantFareInfos)
                    {
                        InfantFares infantFare = new InfantFares();
                        infantFare.FareId = Convert.ToString(infantFareInfo.First().FareId);
                        infantFare.FareBasisCode = infantFareInfo.First().FareBasisCode;
                        infantFare.FareClass = infantFareInfo.First().FareClass;
                        infantFare.InfantFarePerPax = CurrencyHelper.ToString(currency, infantFareInfo.First().WebFareAmount);
                        infantFare.BaseInfantFarePerPax = CurrencyHelper.ToString(currency, infantFareInfo.First().DisplayAmountNoTaxes).Replace(",", "");
                        infantFare.DiscountPerPax = CurrencyHelper.ToString(currency, infantFareInfo.First().Discount);
                        infantFare.PaxCount = searchCriteria.Infants;
                        infantFare.TaxPerPax = CurrencyHelper.ToString(currency, infantFareInfo.First().Taxes);
                        InfantFares.Add(infantFare);
                    }
                    fareInformation.InfantFares = InfantFares;
                }
            }
            return fareInformation;
        }
        
        private Fare BuildFlightFare(FareInformation fareInfo)
        {
            Fare fare = new Fare();

            decimal baseFare = 0;
            decimal changeCost = 0;
            decimal discount = 0;
            decimal tax = 0;

            if (fareInfo != null)
            {
                if (fareInfo.AdultFares != null)
                {
                    foreach (var AdultFare in fareInfo.AdultFares)
                    {

                        if (!string.IsNullOrEmpty(AdultFare.BaseAdultFarePerPax))
                            baseFare += Convert.ToDecimal(AdultFare.BaseAdultFarePerPax) * Convert.ToDecimal(AdultFare.PaxCount);

                        if (!string.IsNullOrEmpty(AdultFare.DiscountPerPax))
                            discount += Convert.ToDecimal(AdultFare.DiscountPerPax) * Convert.ToDecimal(AdultFare.PaxCount);

                        if (!string.IsNullOrEmpty(AdultFare.TaxPerPax))
                            tax += Convert.ToDecimal(AdultFare.TaxPerPax) * Convert.ToDecimal(AdultFare.PaxCount);

                        //if (!string.IsNullOrEmpty(AdultFare.ChangeCost))
                        //    changeCost += Convert.ToDecimal(AdultFare.ChangeCost) * Convert.ToDecimal(AdultFare.PaxCount);

                    }
                }

                if (fareInfo.ChildFares != null)
                {
                    foreach (var ChildFare in fareInfo.ChildFares)
                    {
                        if (!string.IsNullOrEmpty(ChildFare.BaseChildFarePerPax))
                            baseFare += Convert.ToDecimal(ChildFare.BaseChildFarePerPax) * Convert.ToDecimal(ChildFare.PaxCount);

                        if (!string.IsNullOrEmpty(ChildFare.DiscountPerPax))
                            discount += Convert.ToDecimal(ChildFare.DiscountPerPax) * Convert.ToDecimal(ChildFare.PaxCount); ;

                        if (!string.IsNullOrEmpty(ChildFare.TaxPerPax))
                            tax += Convert.ToDecimal(ChildFare.TaxPerPax) * Convert.ToDecimal(ChildFare.PaxCount);

                        //if (!string.IsNullOrEmpty(ChildFare.ChangeCost))
                        //    changeCost += Convert.ToDecimal(ChildFare.ChangeCost) * Convert.ToDecimal(ChildFare.PaxCount);
                    }
                }

                if (fareInfo.InfantFares != null)
                {
                    foreach (var InfantFare in fareInfo.InfantFares)
                    {
                        if (!string.IsNullOrEmpty(InfantFare.BaseInfantFarePerPax))
                            baseFare += Convert.ToDecimal(InfantFare.BaseInfantFarePerPax) * Convert.ToDecimal(InfantFare.PaxCount); ;

                        if (!string.IsNullOrEmpty(InfantFare.DiscountPerPax))
                            discount += Convert.ToDecimal(InfantFare.DiscountPerPax) * Convert.ToDecimal(InfantFare.PaxCount); ;

                        if (!string.IsNullOrEmpty(InfantFare.TaxPerPax))
                            tax += Convert.ToDecimal(InfantFare.TaxPerPax) * Convert.ToDecimal(InfantFare.PaxCount);

                        //if (!string.IsNullOrEmpty(InfantFare.ChangeCost))
                        //    changeCost += Convert.ToDecimal(InfantFare.ChangeCost) * Convert.ToDecimal(InfantFare.PaxCount);
                    }
                }
            }

            fare.BaseFare = CurrencyHelper.ToString(currency, baseFare);
            //fare.ChangeCost = CurrencyHelper.ToString(currency, changeCost);
            fare.Discount = CurrencyHelper.ToString(currency, discount);
            fare.Tax = CurrencyHelper.ToString(currency, tax);
            fare.TotalFare = CurrencyHelper.ToString(currency, baseFare + tax);

            fare.CurrencyCode = currency;
            //faresForConversion.Add(fare.BaseFare.Replace(",", ""));

            return fare;
        }
        
        private bool? IsConnectionFlight(Flight flightItem)
        {
            if (flightItem != null)
            {
                var uniqueFlightNumbers = flightItem.Legs.Select(x => x.FlightNum).Distinct();
                return flightItem.Legs.Count() > 1 && uniqueFlightNumbers.Count() > 1;
            }
            return false;
        }

        private bool? IsCircularFlight(Flight flightItem)
        {
            if (flightItem != null)
            {
                var uniqueFlightNumbers = flightItem.Legs.Select(x => x.FlightNum).Distinct();
                return flightItem.Legs.Count() > 1 && flightItem.Legs.Count() > uniqueFlightNumbers.Count();
            }
            return false;
        }

        private decimal GetCheapflightFare(List<FlightFare> flightFares)
        {
            if (flightFares.Where(x => x.PassengerTypeId == Enums.PassengerTypes.Adult).Count() > 0 && flightFares.Any(x => x.PassengerTypeId == Enums.PassengerTypes.Adult && x.FareAmount > 0))
            {
                var cheapestFare = flightFares.Where(ff => ff.PassengerTypeId == Enums.PassengerTypes.Adult).ToList().Min(ff => ff.WebFareAmount);
                return cheapestFare;
            }
            else
                return 999999999999;
        }
        
        public List<MultiDayflights> BuildMultiDaySegments(List<MultipleDayJourneySegment> response, int noOfDays)
        {
            List<MultiDayflights> segments = new List<MultiDayflights>();
            if (response != null)
            {
                foreach (var grp in response.GroupBy(a => a.JourneySegmentId))
                {
                    var result = grp.ToList();
                    int criteriaIndex = result.First().JourneySegmentId - 1;
                    for (int i = 0; i < result.Count(); ++i)
                    {
                        MultipleDayJourneySegment segmentItem = result[i];
                        foreach (var days in segmentItem.DayLowestFares)
                        {
                            MultiDayflights segment = new MultiDayflights();
                            segment.CurrencyCode = currency;
                            segment.DepartureDate = String.Format("{0:s}", days.Date);
                            segment.LowestAdultFarePerPax = CurrencyHelper.ToString(segmentItem.CurrentDisplayCurrency, days.WebFareAmount);
                            segment.IsSoldOut = days.isSoldOut;
                            segments.Add(segment);
                        }
                    }
                }
            }
            return segments.OrderBy(a => a.DepartureDate).ToList();
        }
        
        public List<Segments> BuildIncludedServiceResponse(List<Model.Results.BrandedFareInfo> includes, Model.Search.SearchCriteria searchCriteria)
        {
            var brandList = GetBrandList();
            return searchCriteria.Flights.Select(flt => new Segments()
            {
                Route = flt.Origin + "_" + flt.Destination,
                Origin = flt.Origin,
                Dest = flt.Destination,
                Direction = !string.IsNullOrEmpty(flt.FlightDirection) && flt.FlightDirection.ToLower() == "inbound" ? Direction.inBound : Direction.outBound,
                DepartureDate = String.Format("{0:s}", flt.DepartureDate),
                Brands = brandList != null ? brandList.Select(brandInfo => new Brand
                {
                    FareTypeID = brandInfo.FareTypeID.ToString(),
                    Cabin = brandInfo.CabinType.ToUpper() == "BUSINESS" ? Cabin.business : brandInfo.CabinType.ToUpper() == "ECONOMY" ? Cabin.economy : Cabin.first,
                    Name = Constants.FareBrandIds.Where(x => x.Key == brandInfo.FareTypeID).FirstOrDefault().Value,
                    IncludedServices = BuildBrandIncludeServices(includes, flt.SegmentId, brandInfo.FareTypeID.ToString()),
                    OrderId = brandInfo.OrderId
                }).ToList() : null
            }).ToList();
        }

        private List<FareBrandInfo> GetBrandList()
        {
            return new List<FareBrandInfo>() {
                new FareBrandInfo()
                {
                    FareTypeID = "YS",
                    FareTypeName = "Economy Saver",
                    CabinType = "economy",
                    OrderId = getFareOrderId("YS")
                },
                new FareBrandInfo()
                {
                    FareTypeID = "YV",
                    FareTypeName = "Economy Classic",
                    CabinType = "economy",
                    OrderId = getFareOrderId("YV")
                },
                new FareBrandInfo()
                {
                    FareTypeID = "YF",
                    FareTypeName = "Economy Flex",
                    CabinType = "economy",
                    OrderId = getFareOrderId("YF")
                },
                new FareBrandInfo()
                {
                    FareTypeID = "JF",
                    FareTypeName = "Business Flex",
                    CabinType = "business",
                    OrderId = getFareOrderId("JF")
                },
            };
        }
    }
}