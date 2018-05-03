using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Results
{
    /// <summary>
    /// Day Lowest Fare
    /// </summary>
    [Serializable]
    public class DayLowestFare
    {
        public DateTime Date { get; set; }

        public decimal FareAmount { get; set; }

        public decimal WebFareAmount { get; set; }

        public int FareType { get; set; }

        public int AvailableSeats { get; set; }

        //A-5467: FZWR-87 :WR5
        public bool isSoldOut { get; set; }

        public List<MultiDayLowestFareFlight> LowestFareFlights { get; set; }
    }

    [Serializable]
    public class MultiDayLowestFareFlight
    {
        public DateTime DepartureDate { get; set; }

        public int LFID { get; set; }

        public int SegmentId { get; set; }

        public int SolutionID { get; set; }

        public decimal WebFareAmountNoTax { get; set; }

        public decimal WebTaxSum { get; set; }

        public decimal FareAmount { get; set; }

        public decimal WebFareAmount { get; set; }

        //Will be kept stable.'WebFareAmount' will change as per currency conversions
        public decimal FareAmountOriginal { get; set; }
    }
}
