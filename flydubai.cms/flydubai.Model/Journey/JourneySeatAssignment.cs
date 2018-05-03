namespace flydubai.Model.Journey
{
    using System;

    /// <summary>
    /// Journey Seat Assignment
    /// </summary>
    [Serializable]
    public class JourneySeatAssignment
    {
        public long SeatHeldId { get; set; }

        public int PhisicalFlightId { get; set; }

        public int Row { get; set; }

        public string Seat { get; set; }
    }
}