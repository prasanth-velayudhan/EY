using System;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Subscribed Scheduled Flight
    /// </summary>
    public class SubscribedScheduledFlight : ScheduledFlightResult
    {
        [Key]
        public int? SubscribedScheduledFlightId { get; set; }

        public ScheduledFlightSubscription Parent { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
    }

    /// <summary>
    /// Scheduled Flight Result
    /// </summary>
    public class ScheduledFlightResult : FlightStatusResult
    {
        public string FlightNumber { get; set; }

        public string FromAirportCode { get; set; }

        public string FromAirportName { get; set; }

        public string ToAirportCode { get; set; }

        public string ToAirportName { get; set; }

        public string FlightStatusCode { get; set; }

        public DateTime ScheduledDeparture { get; set; }

        public DateTime ScheduledArrival { get; set; }

        public DateTime? EstimatedDeparture { get; set; }

        public DateTime? EstimatedArrival { get; set; }

        public DateTime? ActualDeparture { get; set; }

        public DateTime? ActualArrival { get; set; }

        public FlightStatus FlightStatus 
        { 
            get
            {
                switch (this.FlightStatusCode)
                {
                    case "Not yet departed": return FlightStatus.NotYetDeparted;
                    case "In flight": return FlightStatus.InFlight;
                    case "Arrived": return FlightStatus.Arrived;
                    case "Canceled": return FlightStatus.Cancelled;
                    case "DV": return FlightStatus.DV;
                    case "RT": return FlightStatus.RT;
                    case "RR": return FlightStatus.RR;
                    case "FR": return FlightStatus.FR;
                    default: return FlightStatus.Other;
                }
            } 
        }

        public bool IsDepartureDelayed { get; set; }
        
        public bool IsArrivalDelayed { get; set; }

        public string OriginalAirportCode { get; set; }

        public string OriginalAirportName { get; set; }
    }
}