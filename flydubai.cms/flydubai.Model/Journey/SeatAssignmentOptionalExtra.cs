namespace flydubai.Model.Journey
{
    using System;

    /// <summary>
    /// Seat Assignment Optional Extra
    /// </summary>
    [Serializable]
    public class SeatAssignmentOptionalExtra : JourneyOptionalExtra
    {
        public long SeatHeldId { get; set; }

        public string FlightNumber { get; set; }

        public int Row { get; set; }

        public string Seat { get; set; }        
    }
}