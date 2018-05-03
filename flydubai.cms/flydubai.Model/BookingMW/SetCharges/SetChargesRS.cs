using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.SetCharges
{
    public class SetChargesRS
    {
        public string SecurityGUID { get; set; }
        public string currency { get; set; }
        public string CurrencyOfFareQuote { get; set; }
        public object IATA { get; set; }
        public object inventoryFilterMethod { get; set; }
        public object promoCode { get; set; }
        public bool loadTax { get; set; }
        public List<FlightGroup> flightGroups { get; set; }
        public List<OriginDestination> originDestinations { get; set; }
        public List<OASegment> OASegments { get; set; }
        public List<FareCalc> fareCalc { get; set; }
        public List<Exception> Exceptions { get; set; }
    }

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

    public class FareCalc
    {
        public string fareCalc { get; set; }
        public int paxID { get; set; }
    }
}
