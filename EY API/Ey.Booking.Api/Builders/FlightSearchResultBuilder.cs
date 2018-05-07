using Ey.Booking.Api.Models;
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
            return BuildSegments(response.OneDayItineraries, response.MultiDayItineraries);
        }

        public List<Segments> BuildSegments(List<OneDayJourneySegment> oneDayResult, List<MultipleDayJourneySegment> multiDayResult)
        {
            List<Segments> segments = new List<Segments>();
            if (oneDayResult != null && oneDayResult.Count > 0)
            {
                currency = this.searchCriteria.CurrencyCode;
                for (int i = 0; i < oneDayResult.Count(); ++i)
                {
                    OneDayJourneySegment segmentItem = oneDayResult[i];
                    Segments segment = new Segments();
                    segment.Origin = segmentItem.Origin;
                    segment.Dest = segmentItem.Destination;
                    segment.CurrencyCode = currency;
                    segment.DepartureDate = String.Format("{0:s}", segmentItem.Date);
                    segment.Direction = searchCriteria.Flights[i].FlightDirection.ToLower() == Direction.multiSector.ToString().ToLower() ? Direction.multiSector : searchCriteria.Flights[i].FlightDirection.ToLower() == "inbound" ? Direction.inBound : Direction.outBound;
                    segment.Route = string.Format("{0}_{1}", segment.Origin, segment.Dest);

                    Dictionary<string, decimal> lowestAdultFares = GetLowestAdultFarePerPax(segmentItem);

                    if (lowestAdultFares.ContainsKey("lowestAdultFarePerPax"))
                    {
                        segment.LowestAdultFarePerPax = CurrencyHelper.ToString(currency, lowestAdultFares["lowestAdultFarePerPax"]);
                        segment.LowestAdultFareTaxSumPerPax = CurrencyHelper.ToString(currency, lowestAdultFares["lowestAdultTaxPerPax"]);
                        segment.LowestAdultFareNoTaxUnformatted = CurrencyHelper.ToString(currency, lowestAdultFares["lowestAdultBaseFarePerPax"]);
                    }

                    segment.Flights = BuildFlights(segmentItem, false);
                    var distinctFareBrands = segment.Flights.SelectMany(x => x.FareTypes).Select(x =>
                                     new FareBrandInfo()
                                     {
                                         FareTypeID = x.FareTypeID,
                                         FareTypeName = x.FareTypeName,
                                         CabinType = x.Cabin.ToString()

                                     }
                                     ).GroupBy(fb => fb.FareTypeID).OrderBy(x => x.Key)
                                     .Select(g => g.First());


                    segment.Brands = new List<Brand>();
                    foreach (var brandInfo in distinctFareBrands)
                    {
                        segment.Brands.Add(new Brand
                        {
                            FareTypeID = brandInfo.FareTypeID.ToString(),
                            Cabin = brandInfo.CabinType.ToUpper() == "BUSINESS" ? Cabin.business : brandInfo.CabinType.ToUpper() == "ECONOMY" ? Cabin.economy : Cabin.first,
                            Name = Constants.FareBrandIds.Where(x => x.Key == brandInfo.FareTypeName).FirstOrDefault().Value,
                            IncludedServices = BuildBrandIncludeServices(segment.Flights, brandInfo.FareTypeID.ToString())
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

                    segment.MultiDayFlights = BuildMultiDaySegments(multiDayResult.Where(a => a.JourneySegmentId == segmentItem.JourneySegmentId).ToList(), 7);

                    segments.Add(segment);
                }
            }

            //faresToPointsRQ = string.Join(",", faresForConversion.Distinct());
            return segments;
        }

        private Dictionary<IncludeServiceType, string> BuildBrandIncludeServices(IList<Flights> flights, string faretypeId)
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
                    flight.IsInterLine = flightItem.IsInterLine;
                    flight.IsCodeShare = flightItem.IsCodeShare;
                    flight.Legs = BuildLegs(flightItem);
                    flight.FareTypes = BuildFares(flightItem, IsRerpice);
                    flight.FlightNum = flightItem.FlightNum;
                    flight.FlightGroupID = flightItem.FlightGroupID;
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
                        fareType.Fare.SolutionId = Convert.ToString(fType.Key.SolutionID);
                        fareType.Fare.Combinables = BuildCombinableList(fType.Key.SolutionID);
                        fareType.FareCarrier = fType.FirstOrDefault().FareCarrier;
                        fareType.TicketDesignator = fType.FirstOrDefault().TicketDesignator;
                        fareType.HashCode = fType.FirstOrDefault().HashCode;
                        fareType.LfId = Convert.ToString(flightItem.LFID);
                        fareType.PfIds = GetPhysicalFlightIds(flightItem, fType.FirstOrDefault().Bookingcodes, fType.FirstOrDefault().Cabin);
                        fareType.Route = String.Format("{0}_{1}", flightItem.Origin, flightItem.Destination);
                        fareType.Cabin = (fType.FirstOrDefault().FareTypeName.IndexOf('J') != -1 ? Cabin.business : fType.FirstOrDefault().FareTypeName.IndexOf('Y') != -1 ? Cabin.economy : fType.FirstOrDefault().FareTypeName.IndexOf('F') != -1 ? Cabin.first : Cabin.first);
                        if (fType.FirstOrDefault(x => x.PassengerTypeId == Enums.PassengerTypes.Adult) != null)
                        {
                            fareType.IncludedServices = BuildIncludedServices(fType.FirstOrDefault(a => a.PassengerTypeId == Enums.PassengerTypes.Adult) ?? fType.FirstOrDefault());
                        }
                        else if (IsRerpice && fType.FirstOrDefault(x => x.PassengerTypeId == Enums.PassengerTypes.Child) != null)
                        {
                            fareType.IncludedServices = BuildIncludedServices(fType.FirstOrDefault(a => a.PassengerTypeId == Enums.PassengerTypes.Child) ?? fType.FirstOrDefault());
                        }
                        fareType.IsSoldOut = fType.FirstOrDefault().IsSoldOut();
                        fareType.Fare.IsPromoFare = fType.FirstOrDefault().IsPromoFare;
                        fareType.Fare.IsPromoCodeApplied = fType.FirstOrDefault().IsPromoCodeApplied;
                        fareType.Fare.IsStopOverFare = (fType.FirstOrDefault(a => a.PassengerTypeId == Enums.PassengerTypes.Adult) ?? fType.FirstOrDefault()).IsStopOverFare;
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
                        fareTypes.Add(fareType);
                    }
                }
            }

            return fareTypes;
        }

        private Dictionary<IncludeServiceType, string> BuildIncludedServices(FlightFare fType)
        {
            var includes = fType.CheckedBaggageIncludedInFare;

            var retIncludeServices = new Dictionary<IncludeServiceType, string>();
            foreach (var include in includes)
            {
                switch (include.Type)
                {
                    case Constants.SSRBaggage:
                        retIncludeServices.Add(
                            IsHandBaggageCode(include.Code)
                                ? IncludeServiceType.HandBaggage
                                : IncludeServiceType.CheckinBaggage, include.Code);

                        break;
                    case Constants.SSRIFE:
                        retIncludeServices.Add(IncludeServiceType.InflighEntertainment, include.Code);
                        break;
                    case Constants.SSRMeals:
                        retIncludeServices.Add(IncludeServiceType.Meals, include.Code);
                        break;
                    case Constants.SSRSeat:
                        retIncludeServices.Add(IncludeServiceType.SeatSelection, include.Code);
                        break;

                }
            }
            if (fType.ApplicableTaxDetails == null) return retIncludeServices;
            if (fType.ApplicableTaxDetails.Any(x => x.TaxCode == Constants.FreeSeatingCode) && !retIncludeServices.Any(x => x.Key == IncludeServiceType.SeatSelection))
            {
                retIncludeServices.Add(IncludeServiceType.SeatSelection, Constants.FreeSeatingCode);
            }
            if (fType.ApplicableTaxDetails.Any(x => x.TaxCode == Constants.FreeMealCode) && !retIncludeServices.Any(x => x.Key == IncludeServiceType.Meals))
            {
                retIncludeServices.Add(IncludeServiceType.Meals, Constants.FreeMealCode);
            }
            if (fType.ApplicableTaxDetails.Any(x => x.TaxCode == Constants.FreeIFECode) && !retIncludeServices.Any(x => x.Key == IncludeServiceType.InflighEntertainment))
            {
                retIncludeServices.Add(IncludeServiceType.InflighEntertainment, Constants.FreeIFECode);
            }
            if (fType.ApplicableTaxDetails.Any(x => x.TaxCode == Constants.IncludedIFECodeForBusiness) && !retIncludeServices.Any(x => x.Key == IncludeServiceType.InflighEntertainment))
            {
                retIncludeServices.Add(IncludeServiceType.InflighEntertainment, Constants.IncludedIFECodeForBusiness);
            }
            if (fType.ApplicableTaxDetails.Any(x => x.TaxCode == Constants.IncludedFreeMealCodeForBusiness) && !retIncludeServices.Any(x => x.Key == IncludeServiceType.Meals))
            {
                retIncludeServices.Add(IncludeServiceType.Meals, Constants.IncludedFreeMealCodeForBusiness);
            }
            if (fType.ApplicableTaxDetails.Any(x => x.TaxCode == Constants.IncludedFreeSeatCodeForBusiness) && !retIncludeServices.Any(x => x.Key == IncludeServiceType.SeatSelection))
            {
                retIncludeServices.Add(IncludeServiceType.SeatSelection, Constants.IncludedFreeSeatCodeForBusiness);
            }

            return retIncludeServices;
        }

        private bool IsHandBaggageCode(string code)
        {

            return Constants.IncludedHandBaggageCodes.Contains(code);
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

        private IList<string> BuildCombinableList(int solutionID)
        {
            //var combinableList = this.combinablesolutions;
            //if (combinableList.Any(x => x.SolutionId == solutionID.ToString()))
            //{
            //    return combinableList.First(x => x.SolutionId == solutionID.ToString()).Combinables;
            //}
            return null;
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
                        adultFare.ChangeCost = CurrencyHelper.ToString(currency, adulFareInfo.First().ChangeCost);
                        adultFare.BaseAdultFarePerPax = CurrencyHelper.ToString(currency, adulFareInfo.First().DisplayAmountNoTaxes).Replace(",", "");
                        adultFare.DiscountPerPax = CurrencyHelper.ToString(currency, adulFareInfo.First().Discount);
                        adultFare.PaxCount = searchCriteria.Adults;
                        adultFare.TaxPerPax = CurrencyHelper.ToString(currency, adulFareInfo.First().Taxes);
                        //adultFare.IncludedExtas = BuildIncludedExtras(adulFareInfo.First().CheckedBaggageIncludedInFare);
                        //adultFare.ApplicableTaxes = BuildIncludedApplicableTaxes(adulFareInfo.First().ApplicableTaxDetails);
                        //adultFare.PointsEarned = BuildPointsEarned(adulFareInfo.First().AccrualPoints);
                        adultFare.RuleName = adulFareInfo.First().RuleId;
                        adultFare.RuleValue = CurrencyHelper.ToString(currency, adulFareInfo.First().OriginalFare);
                        //faresForConversion.Add(adultFare.BaseAdultFarePerPax);
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
                        childFare.ChangeCost = CurrencyHelper.ToString(currency, childFareInfo.First().ChangeCost);
                        childFare.FareBasisCode = childFareInfo.First().FareBasisCode;
                        childFare.FareClass = childFareInfo.First().FareClass;
                        childFare.ChildFarePerPax = CurrencyHelper.ToString(currency, childFareInfo.First().WebFareAmount);
                        childFare.BaseChildFarePerPax = CurrencyHelper.ToString(currency, childFareInfo.First().DisplayAmountNoTaxes).Replace(",", "");
                        childFare.DiscountPerPax = CurrencyHelper.ToString(currency, childFareInfo.First().Discount);
                        childFare.PaxCount = searchCriteria.Children;
                        childFare.TaxPerPax = CurrencyHelper.ToString(currency, childFareInfo.First().Taxes);
                        //childFare.IncludedExtas = BuildIncludedExtras(childFareInfo.First().CheckedBaggageIncludedInFare);
                        //childFare.ApplicableTaxes = BuildIncludedApplicableTaxes(childFareInfo.First().ApplicableTaxDetails);
                        childFare.RuleName = childFareInfo.First().RuleId;
                        childFare.RuleValue = CurrencyHelper.ToString(currency, childFareInfo.First().OriginalFare);
                        //faresForConversion.Add(childFare.BaseChildFarePerPax.Replace(",", ""));
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
                        infantFare.ChangeCost = CurrencyHelper.ToString(currency, infantFareInfo.First().ChangeCost);
                        infantFare.FareClass = infantFareInfo.First().FareClass;
                        infantFare.InfantFarePerPax = CurrencyHelper.ToString(currency, infantFareInfo.First().WebFareAmount);
                        infantFare.BaseInfantFarePerPax = CurrencyHelper.ToString(currency, infantFareInfo.First().DisplayAmountNoTaxes).Replace(",", "");
                        infantFare.DiscountPerPax = CurrencyHelper.ToString(currency, infantFareInfo.First().Discount);
                        infantFare.PaxCount = searchCriteria.Infants;
                        infantFare.TaxPerPax = CurrencyHelper.ToString(currency, infantFareInfo.First().Taxes);
                        //infantFare.IncludedExtas = BuildIncludedExtras(infantFareInfo.First().CheckedBaggageIncludedInFare);
                        //infantFare.ApplicableTaxes = BuildIncludedApplicableTaxes(infantFareInfo.First().ApplicableTaxDetails);
                        infantFare.RuleName = infantFareInfo.First().RuleId;
                        infantFare.RuleValue = CurrencyHelper.ToString(currency, infantFareInfo.First().OriginalFare);
                        //faresForConversion.Add(infantFare.BaseInfantFarePerPax.Replace(",", ""));
                        InfantFares.Add(infantFare);
                    }
                    fareInformation.InfantFares = InfantFares;
                }
            }
            return fareInformation;
        }

        //private PointsEarned BuildPointsEarned(AccrualPoints accrualPoints)
        //{
        //    PointsEarned pointsEarned = new PointsEarned();
        //    if (accrualPoints != null)
        //    {
        //        pointsEarned.BaseRewardPoints = accrualPoints.BaseRewardPoints;
        //        pointsEarned.BaseTierPoints = accrualPoints.BaseTierPoints;
        //        pointsEarned.BonusRewardPoints = accrualPoints.BonusRewardPoints;
        //        pointsEarned.BonusTierPoints = accrualPoints.BonusTierPoints;
        //    }
        //    return pointsEarned;
        //}

        private IList<IncludedExtas> BuildIncludedExtras(List<IncludedBaggage> checkedBaggageIncludedInFare)
        {
            List<IncludedExtas> includedExtas = new List<IncludedExtas>();
            if (checkedBaggageIncludedInFare != null)
            {
                foreach (var baggage in checkedBaggageIncludedInFare)
                {
                    IncludedExtas includedExta = new IncludedExtas();
                    includedExta.Type = baggage.Type;
                    includedExta.Code = baggage.Code;
                    includedExta.Value = Convert.ToString(baggage.Weight);
                    includedExtas.Add(includedExta);
                }
            }
            return includedExtas;
        }

        private IList<ApplicableTaxes> BuildIncludedApplicableTaxes(List<ApplicableTaxDetail> applicableTaxdetails)
        {
            List<ApplicableTaxes> includedApplicableTaxes = new List<ApplicableTaxes>();
            if (applicableTaxdetails != null)
            {
                foreach (var applicableTaxdetail in applicableTaxdetails)
                {
                    ApplicableTaxes includedApplicableTax = new ApplicableTaxes();
                    includedApplicableTax.Amount = CurrencyHelper.ToString(currency, applicableTaxdetail.Amt);
                    includedApplicableTax.TaxCode = applicableTaxdetail.TaxCode;
                    includedApplicableTax.TaxId = applicableTaxdetail.TaxID.ToString();
                    includedApplicableTaxes.Add(includedApplicableTax);
                }
            }
            return includedApplicableTaxes;
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

                        if (!string.IsNullOrEmpty(AdultFare.ChangeCost))
                            changeCost += Convert.ToDecimal(AdultFare.ChangeCost) * Convert.ToDecimal(AdultFare.PaxCount);

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

                        if (!string.IsNullOrEmpty(ChildFare.ChangeCost))
                            changeCost += Convert.ToDecimal(ChildFare.ChangeCost) * Convert.ToDecimal(ChildFare.PaxCount);
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

                        if (!string.IsNullOrEmpty(InfantFare.ChangeCost))
                            changeCost += Convert.ToDecimal(InfantFare.ChangeCost) * Convert.ToDecimal(InfantFare.PaxCount);
                    }
                }
            }

            fare.BaseFare = CurrencyHelper.ToString(currency, baseFare);
            fare.ChangeCost = CurrencyHelper.ToString(currency, changeCost);
            fare.Discount = CurrencyHelper.ToString(currency, discount);
            fare.Tax = CurrencyHelper.ToString(currency, tax);
            fare.TotalFare = CurrencyHelper.ToString(currency, baseFare + tax);

            fare.CurrencyCode = currency;
            //faresForConversion.Add(fare.BaseFare.Replace(",", ""));

            return fare;
        }

        private IList<PfIds> GetPhysicalFlightIds(Flight flightItem, List<Bookingcode> bookingCode, string defaultCabin)
        {
            if (flightItem != null)
            {
                if (flightItem.Legs.Count() > 0)
                {
                    List<PfIds> pfIds = new List<PfIds>();
                    foreach (Leg leg in flightItem.Legs)
                    {
                        string cabin = "";
                        string fareclass = "";
                        try
                        {
                            cabin = bookingCode.First(w => w.PFID == leg.PFID).cabin;
                            fareclass = bookingCode.First(w => w.PFID == leg.PFID).RBD;
                        }
                        catch (System.Exception)
                        {
                            cabin = defaultCabin;
                        }

                        pfIds.Add(new PfIds
                        {
                            PfId = Convert.ToString(leg.PFID),
                            Date = String.Format("{0:s}", leg.DepartureDate),
                            FareClass = fareclass,
                            Cabin = cabin
                        });
                    }
                    return pfIds;
                }
            }
            return null;
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
            return segments;
        }

        private List<DayLowestFare> BuildLowestFareList(MultipleDayJourneySegment segmentItem, DateTime searchedDate, int noOfDays)
        {
            List<DayLowestFare> vm = new List<DayLowestFare>();
            for (int i = -noOfDays / 2; i < (noOfDays / 2) + 1; i++)
            {
                DateTime date = searchedDate.AddDays(i).Date;
                var dayFares = segmentItem.DayLowestFares.FirstOrDefault(l => l.Date.Date == date);
                if (dayFares != null)
                {
                    vm.Add(new DayLowestFare
                    {
                        Date = dayFares.Date,
                        WebFareAmount = dayFares.WebFareAmount,
                        WebFareAmountNoTax = dayFares.WebFareAmountNoTax,
                        WebTaxSum = dayFares.WebTaxSum,
                        isSoldOut = dayFares.isSoldOut,
                        isCodeShare = dayFares.isCodeShare,
                        isInterline = dayFares.isInterline,
                        LowestFareFlights = dayFares.LowestFareFlights
                    });
                }
                else
                {
                    vm.Add(new DayLowestFare { Date = date, FareAmount = 0 });
                }
            }

            return vm;
        }
    }
}