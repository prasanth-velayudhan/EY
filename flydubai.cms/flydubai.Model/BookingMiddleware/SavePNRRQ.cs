using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMiddleware.SavePNR
{
    public class SavePNRRQ
    {
        public string ActionType { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
        public string PNRPayments { get; set; }
        public string ReservationChannelType { get; set; }
    }

    public enum ActionTypes : int
    {
        SaveReservation = 0,
        CommitSummary = 1,
    }
}
