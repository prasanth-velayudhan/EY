using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.SetCharges
{
    public class SegmentDetail
    {
        public int segmentID { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime depDate { get; set; }
        public DateTime arrDate { get; set; }
        public List<LegDetail> legDetails { get; set; }
        public List<BookingCode> bookingCodes { get; set; }
        public bool OAFlight { get; set; }
        public string operCarrier { get; set; }
        public string operFlightNum { get; set; }
        public string mrktCarrier { get; set; }
        public string mrktFlightNum { get; set; }
        public string depTerminal { get; set; }
        public string arrTerminal { get; set; }
    }

    public class LegDetail
    {
        public int legID { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string operCarrier { get; set; }
        public string operFlightNum { get; set; }
        public DateTime depDate { get; set; }
        public DateTime arrDate { get; set; }
        public string mrktCarrier { get; set; }
        public string mrktFlightNum { get; set; }
        public string arrTerminal { get; set; }
        public string depterminal { get; set; }
        public bool OAFlight { get; set; }
    }

    public class BookingCode
    {
        public string fareClass { get; set; }
        public string cabin { get; set; }
        public List<string> paxID { get; set; }
    }
}
