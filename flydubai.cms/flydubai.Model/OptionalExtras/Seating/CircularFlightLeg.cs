namespace flydubai.Model.OptionalExtras.Seating
{
    using System;

    /// <summary>
    /// Circular Flight Leg
    /// </summary>
    [Serializable]
    public class CircularFlightLeg
    {
        public int PhysicalFlightId { get; set; }

        public int AssociatedSegmentId { get; set; }

        public long SeatHeldId { get; set; }

        public bool IsLegDisplayed { get; set; }

        public DateTime LegDepartureDate { get; set; }
    }
}