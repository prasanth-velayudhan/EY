namespace flydubai.Model.OptionalExtras.Seating
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Circular Flight
    /// </summary>
    [Serializable]
    public class CircularFlight
    {
        public CircularFlight()
        {
            this.PhysicalFlights = new List<CircularFlightLeg>();
        }

        public int LogicalFlightId { get; set; }

        public DateTime DepartureDate { get; set; }

        public List<CircularFlightLeg> PhysicalFlights { get; set; }
    }
}
