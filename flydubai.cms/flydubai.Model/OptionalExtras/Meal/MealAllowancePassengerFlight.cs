using System;
using System.Linq;

namespace flydubai.Model.OptionalExtras.Meal
{
    using System.Collections.Generic;
    using flydubai.Common;

    /// <summary>
    /// Baggage Allowance Passenger Flight
    /// </summary>
    public class MealAllowancePassengerFlight
    {
        public MealAllowancePassengerFlight()
        {
            this.MealAllowancePrices = new List<MealAllowancePrice>();
            this.FlightLegs = new List<MealAllowancePassengerFlightLeg>();
        }

        public int LFID { get; set; }

        public DateTime DepartureDate { get; set; }

        public int FareTypeId { get; set; }

        public string Cabin { get; set; }

        public List<MealAllowancePrice> MealAllowancePrices { get; set; }

        public List<MealAllowancePassengerFlightLeg> FlightLegs { get; set; }

        public bool IsReturnFlight { get; set; }

        public int Stops
        {
            get
            {
                return this.FlightLegs.Count - 1;
            }
        }

        public bool IsConnectionFlight { get; set; }

        public bool HasEnoughMeal { get; set; }

        public bool IsWithinCutoffPeriod { get; set; }

        public bool WasMealAssingedFlight { get; set; }

        //Y class meal
        public string MasterMealCode { get; set; }

        //Interline changes
        public bool IsInterline
        {
            get
            {
                return FlightLegs.Any(a => a.IsOtherAirline);
            }
        }

        public string SellingCarrier { get; set; }

        public bool IsRemovable { get; set; }

        public bool IsCircularFlight { get; set; }
    }
}