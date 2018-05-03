using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class UpdatelocatorRQ
    {
        public ReservationInfoRUL reservationInfos { get; set; }
        public TransactionInfoRUL transactionInfos { get; set; }
        public List<SegmentRUL> segmentsInfos { get; set; }
    }

    public class ReservationInfoRUL
    {
        public string confirmationNumber { get; set; }
        public string priorityCode { get; set; }
        public string seriesNumber { get; set; }
    }

    public class TransactionInfoRUL
    {
        public string securityGUID { get; set; }
        public string userid { get; set; }
        public string office { get; set; }
        public string channel { get; set; }
        public string IPAddress { get; set; }
        public string userName { get; set; }
        public List<CarrierCode> carriers { get; set; }
    }

    public class SegmentRUL
    {
        public string carrier { get; set; }
        public string flightnum { get; set; }
        public string rbd { get; set; }
        public string depDate { get; set; }
        public string arrDate { get; set; }
        public string org { get; set; }
        public string dest { get; set; }
        public string depTime { get; set; }
        public string arrTime { get; set; }
        public List<PaxInfoRUL> paxInfos { get; set; }
    }

    public class PaxInfoRUL
    {
        public string title { get; set; }
        public string fName { get; set; }
        public object mName { get; set; }
        public string lName { get; set; }
        public string rLoc { get; set; }
        public string status { get; set; }
        public string dob { get; set; }
    }

    public class UpdatelocatorRS
    {
        public List<Exception> Exceptions { get; set; }
        public bool Status { get; set; }
    }
}
