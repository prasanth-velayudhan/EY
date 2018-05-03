using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class SeatAssignment
    {
        public string Key { get; set; }
        public int PhysicalFlightID { get; set; }
        public DateTime ActualDepartureDate { get; set; }
        public string FlightNumber { get; set; }
        public DateTime ScheduledDeparturetime { get; set; }
        public DateTime ScheduledArrivaltime { get; set; }
        public int BoardingPassNumber { get; set; }
        public string Seat { get; set; }
        public int RowNumber { get; set; }
        public string Gate { get; set; }
        public string OldSeat { get; set; }
        public int OldRowNumber { get; set; }
        public bool Boarded { get; set; }
        public string CheckInAgent { get; set; }
        public DateTime CheckInDate { get; set; }
        public string CouponStatusIndicator { get; set; }
        public string BoardingSequence { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int BoardingPassPrinted { get; set; }
        public string FrequentFlyerCarrierCode { get; set; }
        public string FrequentFlyerNumber { get; set; }
        public string FrequentFlyerSSRCode { get; set; }
        public string FrequentFlyerMemberTierLevel { get; set; }
        public string FrequentFlyerMemberRating { get; set; }
        public int FrequentFlyerNumberActionTracker { get; set; }
        public int ReservationChannelID { get; set; }
        public int FrequentFlyerInfoReservationChannelID { get; set; }
        public DateTime? FrequentFlyerNumberLAstModifiedDate { get; set; }
    }
}
