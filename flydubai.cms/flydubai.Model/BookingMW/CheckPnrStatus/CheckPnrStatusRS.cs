using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.CheckPnrStatus
{
    public class CheckPnrStatusRS
    {
        public TransactionInfo TransactionInfo { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public List<CheckPNRSegment> Segments { get; set; }
        public List<Exception> Exceptions { get; set; }
    }

    public class CheckPNRSegment
    {
        public object SecurityGUID { get; set; }
        public object CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
        public string operFlightNum { get; set; }
        public int segmentID { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime depDate { get; set; }
        public string operCarrier { get; set; }
        public string mrktCarrier { get; set; }
        public string mrktFlightNum { get; set; }
        public int LogicalFlightID { get; set; }
        public int PhysicalFlightID { get; set; }
        public string lASTGDSStatus { get; set; }
        public string personName { get; set; }
        public List<CheckPNRPaxDetail> paxDetails { get; set; }
    }

    public class CheckPNRPaxDetail
    {
        public string fName { get; set; }
        public string mName { get; set; }
        public string lName { get; set; }
        public string rLoc { get; set; }
        public string lastGDSStatus { get; set; }
        public int personORGID { get; set; }
        public string recordLocator { get; set; }
    }
}
