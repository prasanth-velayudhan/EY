using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model.Merchandising.FLX;

namespace flydubai.Model.Journey
{
    /// <summary>
    /// Journey Service Quote
    /// </summary>
    [Serializable]
    public class JourneyServiceQuote
    {
        public int ServiceId { get; set; }

        public int QuantityAvailable { get; set; }

        public int LogicalFlightId { get; set; }

        public string Description { get; set; }

        public DateTime DepartureDate { get; set; }

        public string CodeType { get; set; }

        public int CategoryId { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public int CutOffHours { get; set; }

        public string DiagID { get; set; }

        public int DiagDesc { get; set; }

        public bool AmountActive { get; set; }

        public int MaxCountServiceLevel { get; set; }

        public int PFID { get; set; }

        public int Row { get; set; }

        public string Seat { get; set; }  

    }
}
