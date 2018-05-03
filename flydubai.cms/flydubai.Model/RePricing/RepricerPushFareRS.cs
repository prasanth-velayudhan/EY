using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.RePricing
{
    public class RepricerPushFareRS
    {
        public class Result
        {
            public object IATA { get; set; }
            public object[] OASegments { get; set; }
            public object SecurityGUID { get; set; }
            public object currency { get; set; }
            public object[] flightGroups { get; set; }
            public object inventoryFilterMethod { get; set; }
            public Origindestination[] originDestinations { get; set; }
            public object promoCode { get; set; }
            public Exception[] Exceptions { get; set; }
        }

        public class Origindestination
        {
            public DateTime depDate { get; set; }
            public string destination { get; set; }
            public Farebrand[] fareBrands { get; set; }
            public string flightNum { get; set; }
            public bool isPromoApplied { get; set; }
            public int odID { get; set; }
            public string origin { get; set; }
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
            public string FBC { get; set; }
            public int ID { get; set; }
            public int PTC { get; set; }
            public Applicabletaxdetail[] applicableTaxDetails { get; set; }
            public float baseFare { get; set; }
            public string cabin { get; set; }
            public string fareClass { get; set; }
            public int fareID { get; set; }
            public int infantAvailability { get; set; }
            public int seatAvailability { get; set; }
            public object secureHash { get; set; }
            public float totalFare { get; set; }
        }

        public class Applicabletaxdetail
        {
            public float amt { get; set; }
            public string taxCode { get; set; }
            public int taxID { get; set; }
        }

        public class Segmentdetail
        {
            public DateTime depDate { get; set; }
            public string destination { get; set; }
            public string operCarrier { get; set; }
            public string operFlightNum { get; set; }
            public string origin { get; set; }
            public int segmentID { get; set; }
        }
        public class Exception
        {
            public int ExceptionCode { get; set; }
            public string ExceptionDescription { get; set; }
            public object ExceptionSource { get; set; }
            public object ExceptionLevel { get; set; }
        }
    }
}
