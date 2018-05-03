using System;
using System.Collections.Generic;
using System.Linq;

namespace flydubai.Model.Results
{
    /// <summary>
    /// Lowest Flight Prices
    /// </summary>
    [Serializable]
    public class LowestFlightPrices
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LowestFlightPrices"/> class.
        /// </summary>
        public LowestFlightPrices()
        {
            this.FlightPricesOnDates = new List<FlightPriceOnDate>();
        }

        public List<FlightPriceOnDate> FlightPricesOnDates { get; set; }

        public List<DateTime> CheapestFlightDays
        {
            get
            {
                return this.FlightPricesOnDates.Where(fp => fp.FareAmount == this.LowestPrice).Select(x => x.Date).ToList();
            }
        }

        public decimal LowestPrice
        {
            get
            {
                return this.FlightPricesOnDates.Where(f => !f.IsSoldOut).Min(f => f.FareAmount);
            }
        }
    }

    /// <summary>
    /// Flight Price On Date
    /// </summary>
    [Serializable]
    public class FlightPriceOnDate
    {
        public DateTime Date { get; set; }

        public decimal FareAmount { get; set; }

        public string FareCurrencyCode { get; set; }

        public bool IsSoldOut { get; set; }
    }

}
