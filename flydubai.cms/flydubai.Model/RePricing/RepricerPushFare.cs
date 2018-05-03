using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.RePricing
{
    public class RepricerPushFare
    {
        public enum InventoryFilterMethod
        {
            Available = 0
        }
        public class Request
        {
            public string securityGUID { get; set; }
            public string currency { get; set; }
            public string IATA { get; set; }
            public string inventoryFilterMethod { get; set; }
            public string promoCode { get; set; }
            public Origindestination[] originDestinations { get; set; }
        }

        public class Origindestination
        {
            public int odID { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public string flightNum { get; set; }
            public DateTime depDate { get; set; }
            public string isPromoApplied { get; set; }
            public Farebrand[] fareBrand { get; set; }
            public Segmentdetail[] segmentDetails { get; set; }
        }

        public class Farebrand
        {
            public int fareBrandID { get; set; }
            public string fareBrandName { get; set; }
            public Fareinfo[] fareInfos { get; set; }
        }

        public class Fareinfo
        {
            public Paxfareinfo[] paxFareInfos { get; set; }
        }

        public class Paxfareinfo
        {
            public int fareID { get; set; }
            public string ID { get; set; }
            public string FBC { get; set; }
            public string fareClass { get; set; }
            public string cabin { get; set; }
            public decimal baseFare { get; set; }
            public decimal totalFare { get; set; }
            public int PTC { get; set; }
            public int seatAvailability { get; set; }
            public int infantAvailability { get; set; }
            public Applicabletaxdetail[] applicableTaxDetails { get; set; }
        }

        public class Applicabletaxdetail
        {
            public string amt { get; set; }
            public string taxCode { get; set; }
            public int taxID { get; set; }
        }

        public class Segmentdetail
        {
            public int segmentID { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public string operCarrier { get; set; }
            public string operFlightNum { get; set; }
            public DateTime depDate { get; set; }
        }
    }
}
