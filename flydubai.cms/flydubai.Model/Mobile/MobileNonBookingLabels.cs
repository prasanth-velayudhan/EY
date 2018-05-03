using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    using System.ComponentModel;

    /// <summary>
    /// Mobile Non Booking Labels
    /// </summary>
    public class MobileNonBookingLabels : BaseLabels
    {
        public string FlightNumber { get; set; }
        public string Route { get; set; }
        public string DueToArrive { get; set; }
        public string FlyingFrom { get; set; }
        public string FlyingTo { get; set; }
        public string GetFlightInfo { get; set; }
        public string BackToTop { get; set; }

        public string CheckFlightStatus { get; set; }
        public string FlightSearch { get; set; }
        public string Flights { get; set; }
        public string BasedOn24HourClock { get; set; }
        public string AllTimesAreShownLocal { get; set; }
        public string Scheduled { get; set; }
        public string Expected { get; set; }
        public string Terminal { get; set; }
        public string Status { get; set; }
        public string Arrived { get; set; }
        public string NotYetArrived { get; set; }
        public string FlightStatusTop { get; set; }

        //FR 10 A-5583//
        public string ActualArrival { get; set; }
        public string ActualDeparture { get; set; }
        public string EstimatedArrival { get; set; }
        public string EstimatedDeparture { get; set; }
        public string ScheduledDeparture { get; set; }
        //FR 10 A-5583//

        public string FlydubaiTimetable { get; set; }
        public string RoundTrip { get; set; }
        public string OneWay { get; set; }
        public string OutboundDate { get; set; }
        public string ReturnDate { get; set; }
        public string ShowTimetable { get; set; }
        public string EffectiveBetween { get; set; }
        public string Arrival { get; set; }
        public string TimetableTop { get; set; }

        public string ContactUs { get; set; }
        public string WhereAreYouCallingFrom { get; set; }
        public string GetContactNumber { get; set; }
        public string EmailUs { get; set; }
        public string flydubaiEmailAddress { get; set; }
        public string ContactUsTop { get; set; }

        public string flydubaiContactNumber { get; set; }
        public string flydubaiCallCentre { get; set; }
        public string TravelPartners { get; set; }
        public string OurTravelPartnersAreAbleToAssist { get; set; }
        public string SearchAgain { get; set; }

        public string MyBookings { get; set; }
        public string Record { get; set; }
        public string Paid { get; set; }
        public string Pending { get; set; }
        public string TimeUntilExpiry { get; set; }
        //WR8:WR-122:A-4740: Mobile UI changes for a pay later booking in the recent bookings page for a logged in user - start
        public string AtPaymentPointToKeepFare { get; set; }
        //WR8:WR-122:A-4740: Mobile UI changes for a pay later booking in the recent bookings page for a logged in user - end
        public string View { get; set; }
        public string BookingsTop { get; set; }

        public string Completed { get; set; }
        public string ExpiredCancelled { get; set; }
        public string FiveMostRecentBoookings { get; set; }

        [DisplayName("XMostRecentBookings (e.g. {0} most recent bookings) where {0} will be the number once page formatting has been applied.")]
        [DefaultValue("{0} most recent bookings")]
        public string XMostRecentBookings { get; set; }
    }
}
