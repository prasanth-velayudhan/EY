using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.CheckPnrStatus
{
    public class CheckPnrStatusRQ
    {
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
        public ReservationInfo reservationInfo { get; set; }
        public bool checkfromdb { get; set; }
    }
}
