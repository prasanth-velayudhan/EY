namespace flydubai.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Airport Destination
    /// </summary>
    [Serializable]
    public class AirportDestination
    {
        public int AirportDestinationId { get; set; }

        [MaxLength(3)]
        [Required]
        [ForeignKey("OriginAirport")]
        public string OriginAirportCode { get; set; }

        [ForeignKey("OriginAirportCode")]
        public Airport OriginAirport { get; set; }

        [MaxLength(3)]
        [Required]
        [ForeignKey("DestinationAirport")]
        public string DestinationAirportCode { get; set; }

        [ForeignKey("DestinationAirportCode")]
        public Airport DestinationAirport { get; set; }

        public decimal RouteDuration { get; set; }

        public bool IsAPIsRequired { get; set; }

        public bool IsInterline { get; set; }

        public bool OverrideInterlineCheck { get; set; }
    }
}