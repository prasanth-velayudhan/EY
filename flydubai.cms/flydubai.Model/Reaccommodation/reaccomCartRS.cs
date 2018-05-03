using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.ReAccommodation
{
    [Serializable]
    public class reaccomCartRS
    {
        [Serializable]
        public class reaccomCartResponse
        {
            public bool loadTax { get; set; }
            public string SecurityGUID { get; set; }
            public string currency { get; set; }
            public string CurrencyOfFareQuote { get; set; }
            public string IATA { get; set; }
            public string inventoryFilterMethod { get; set; }
            public string promoCode { get; set; }
            public List<FlightGroup> flightGroups { get; set; }
            public List<OriginDestination> originDestinations { get; set; }
            public List<OASegment> OASegments { get; set; }
            public List<TicketingInfo> ticketingInfo { get; set; }
            public List<Exception> Exceptions { get; set; }
        }

        [Serializable]
        public class FlightGroup
        {
            public DateTime depDate { get; set; }
            public string flightNum { get; set; }
            public string ID { get; set; }
            public string destination { get; set; }
            public List<string> flightGroup { get; set; }
            public string origin { get; set; }
            public List<FareBrand> fareBrands { get; set; }
        }

        [Serializable]
        public class FareBrand
        {
            public int fareBrandID { get; set; }
            public string fareBrand { get; set; }
            public List<FareInfo> fareInfos { get; set; }
        }

        [Serializable]
        public class FareInfo
        {
            public List<PaxFareInfo> paxFareInfos { get; set; }
        }

        [Serializable]
        public class PaxFareInfo
        {
            public string FBC { get; set; }
            public int HeldId { get; set; }
            public string ID { get; set; }
            public int PTC { get; set; }
            public List<ApplicableTaxDetail> applicableTaxDetails { get; set; }
            public decimal baseFare { get; set; }
            public string fareCarrier { get; set; }
            public int fareID { get; set; }
            public decimal originalFare { get; set; }
            public string ruleID { get; set; }
            public string secureHash { get; set; }
            public string ticketDesignator { get; set; }
            public decimal totalFare { get; set; }
        }

        [Serializable]
        public class ApplicableTaxDetail
        {
            public decimal amt { get; set; }
            public string codeType { get; set; }
            public string taxCode { get; set; }
            public string taxDesc { get; set; }
            public int taxID { get; set; }
        }

        [Serializable]
        public class OriginDestination
        {
            public string ID { get; set; }
            public int odID { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public string flightNum { get; set; }
            public DateTime depDate { get; set; }
            public bool isPromoApplied { get; set; }
            public List<FareBrand> fareBrands { get; set; }
            public List<SegmentDetail> segmentDetails { get; set; }
        }

        [Serializable]
        public class SegmentDetail
        {
            public int segmentID { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public DateTime depDate { get; set; }
            public List<LegDetail> legDetails { get; set; }
            public List<BookingCode> bookingCodes { get; set; }
        }

        [Serializable]
        public class LegDetail
        {
            public DateTime arrDate { get; set; }
            public string arrTerminal { get; set; }
            public DateTime depDate { get; set; }
            public string depTerminal { get; set; }
            public string destination { get; set; }
            public int legID { get; set; }
            public string mrktCarrier { get; set; }
            public string mrktFlightNum { get; set; }
            public string operCarrier { get; set; }
            public string operFlightNum { get; set; }
            public string origin { get; set; }
        }

        [Serializable]
        public class BookingCode
        {
            public string fareClass { get; set; }
            public string cabin { get; set; }
            public List<int> paxID { get; set; }
        }

        [Serializable]
        public class OASegment
        {
            public string ID { get; set; }
            public int OAFlightID { get; set; }
            public string arrTerminal { get; set; }
            public string depDate { get; set; }
            public string depTerminal { get; set; }
            public string destination { get; set; }
            public List<FareBrand> fareBrands { get; set; }
            public string mrktCarrier { get; set; }
            public string mrktFlightNum { get; set; }
            public string operCarrier { get; set; }
            public string operFlightNum { get; set; }
            public string origin { get; set; }
            public List<SegmentDetail> segmentDetails { get; set; }
        }

        [Serializable]
        public class TicketingInfo
        {

        }

        [Serializable]
         public class Exception
        {
            public int ExceptionCode { get; set; }
            public string ExceptionDescription { get; set; }
            public string ExceptionSource { get; set; }
            public int ExceptionLevel { get; set; }
        }

       
   
    }
}
