using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMiddleware.CancelPNR
{
    public class CancelPNRRQ
    {
        public string ActionType { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public object HistoricUserName { get; set; }
    }

    public enum ActionTypes : int
    {
        CancelReservation = 0,
        RevertReservation = 1,
    }
}
