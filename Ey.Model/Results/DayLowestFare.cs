using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model.Results
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

        public bool IncludesPromo { get; set; }
        
        public bool isSoldOut { get; set; }

        public bool isInterline { get; set; }
        public bool isCodeShare { get; set; }

        public decimal WebFareAmountNoTax { get; set; }

        public decimal WebTaxSum { get; set; }

        public System.Collections.Generic.List<MultiDayLowestFareFlight> LowestFareFlights { get; set; }

        //public int SolutionID { get; set; }
    }

    public class MultiDayLowestFareFlight
    {
        public DateTime DepartureDate { get; set; }

        public int LFID { get; set; }

        public int SolutionID { get; set; }

        public bool isInterline { get; set; }

        public bool isCodeShare { get; set; }

        public decimal WebFareAmountNoTax { get; set; }

        public decimal WebTaxSum { get; set; }

        public decimal FareAmount { get; set; }

        public decimal WebFareAmount { get; set; }
    }
}
