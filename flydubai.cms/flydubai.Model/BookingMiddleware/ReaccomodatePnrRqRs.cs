using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMiddleware
{
    public class ReaccomodatePNR
    {
        public class ReaccomodatePnrRQ
        {
            public Reservationinfos reservationInfos { get; set; }
            public Transactioninfos transactionInfos { get; set; }
            public IList<Segmentsinfo> segmentsInfos { get; set; }
        }

        public class Reservationinfos
        {
            public string PNR { get; set; }
            public string seriesNumber { get; set; }
            public string channel { get; set; }
        }

        public class Transactioninfos
        {
            public string securityGUID { get; set; }
            public string userid { get; set; }
            public string IPAddress { get; set; }
        }

        public class Segmentsinfo
        {
            public string carrier { get; set; }
            public string flightnum { get; set; }
            public DateTime depDate { get; set; }
            public string org { get; set; }
            public string dest { get; set; }
            public List<Paxinfo> paxInfos { get; set; }
        }

        public class Paxinfo
        {
            public string recordNumber { get; set; }
            public string title { get; set; }
            public string fName { get; set; }
            public string mName { get; set; }
            public string lName { get; set; }
            public string consentStatus { get; set; }
        }

        public class ReaccomodatePnrRS
        {
            public Reservationinfos reservationInfos { get; set; }
            public Transactioninfos transactionInfos { get; set; }
            public IList<Segmentsinfo> segmentsInfos { get; set; }
        }
    }
}
