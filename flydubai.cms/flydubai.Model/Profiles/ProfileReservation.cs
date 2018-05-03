using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Profiles
{
    /// <summary>
    /// Profile Reservation
    /// </summary>
    [Serializable]
    public class ProfileReservation
    {
        public string ConfirmationNumber { get; set; }

        public string PrimaryPassengerSurname { get; set; }

        public DateTime BookingDate { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDate { get; set; }

        public int NumberOfPassengers { get; set; }

        public ProfileReservationStatus Status { get; set; }
    }

    public enum ProfileReservationStatus
    {
        PaymentOutstanding,
        Confirmed,
        JourneyCompleted,
        ExpiredCancelled,
    }
}
