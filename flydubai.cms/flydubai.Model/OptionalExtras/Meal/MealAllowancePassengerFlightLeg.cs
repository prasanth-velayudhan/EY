namespace flydubai.Model.OptionalExtras.Meal
{
    using flydubai.Common;
    using System;

    /// <summary>
    /// Baggage Allowance Passenger Flight Leg
    /// </summary>
    public class MealAllowancePassengerFlightLeg
    {
        public DateTime DepartureDate { get; set; }

        public string FlightNum { get; set; }

        public string OperatingCarrier { get; set; }

        public string OperatingCarrierName { get; set; }

        public string MarketingCarrier { get; set; }

        public string SellingCarrier { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public int PFID { get; set; }

        public bool IsWithinCutoffPeriodMeals { get; set; } //A-7297 Leg Level CutOff - Meals

        public bool HasEnoughMeal { get; set; } //Has Enough Meal in leg level

        public bool HasEnoughBusinessMeal { get; set; } //Has Enough Meal in leg level

        public bool WasMealAssingedFlight { get; set; }

        //Y class meal
        public string MasterMealCode { get; set; }

        public bool IsBusRoute { get; set; }

        public bool IsMealIncludedFare { get; set; }

        //Interline changes
        public bool IsOtherAirline
        {
            get
            {
                return OperatingCarrier.Trim().ToUpper() != Constants.FlydubaiCarrierCode;
            }
        }

        //code share
        public bool IsCodeshare
        {
            get
            {
                if (OperatingCarrier.Trim().ToUpper() != Constants.FlydubaiCarrierCode)
                {
                    if (!String.IsNullOrWhiteSpace(MarketingCarrier))
                    {
                        return MarketingCarrier.Trim().ToUpper() == Constants.FlydubaiCarrierCode;
                    }
                    if (!String.IsNullOrWhiteSpace(SellingCarrier))
                    {
                        return SellingCarrier.Trim().ToUpper() == Constants.FlydubaiCarrierCode;
                    }
                }
                return false;
            }
        }

    }
}