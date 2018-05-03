using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.SetCharges
{
    public class PaxFareInfo
    {
        public List<ApplicableTaxDetail> applicableTaxDetails { get; set; }
        public int fareID { get; set; }
        public string ID { get; set; }
        public string FBC { get; set; }
        public string fareClass { get; set; }
        public string cabin { get; set; }
        public decimal baseFare { get; set; }
        public string ruleID { get; set; }
        public decimal originalFare { get; set; }
        public decimal totalFare { get; set; }
        public int PTC { get; set; }
        public int seatAvailability { get; set; }
        public int infantAvailability { get; set; }
        public string secureHash { get; set; }
        public string FCCode { get; set; }
        public string ticketDesignator { get; set; }
        public string fareCarrier { get; set; }
    }
}
