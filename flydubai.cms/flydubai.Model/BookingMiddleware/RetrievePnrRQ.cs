using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMiddleware
{
    public class RetrievePnrRQ
    {
        public ActionTypes ActionType { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
    }

    public class RetrievePnrByDocRefRQ
    {
        public string url { get; set; }
        public string guid { get; set; }
    }

    public class ReservationInfo
    {
        public string SeriesNumber { get; set; }
        public string ConfirmationNumber { get; set; }
    }

    public enum ActionTypes : int
    {
        GetReservation = 0,
        GetReservationViewOnly = 1,
        GetReservationWithETicketInformation = 2,
        GetReservationWithETicketInformationViewOnly = 3,
        GetReservationFromSession = 4,
    }
}
