namespace flydubai.Model.Booking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using flydubai.Common;

    /// <summary>
    /// Seat Assignment
    /// </summary>
    [Serializable]
    public class SeatAssignment
    {
        public string Key { get; set; }

        public string Seat { get; set; }

        public string RowNumber { get; set; }

        public bool IsRestrictedSeat
        {
            get {
                    return Constants.RestrictedSeats.Contains(RowNumber + Seat.Trim().ToUpper());
                }
        }
        public bool isMatched
        {
            get;
            set;
        }
        public int PhysicalFlightId { get; set; }

    }
}
