using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Scheduled Flight Subscription
    /// </summary>
    [DataContract]
    public class ScheduledFlightSubscription
    {
        [Key]
        public int? ScheduledFlightSubscriptionId { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string FlyingToAirportCode { get; set; }

        [DataMember]
        public string FlyingFromAirportCode { get; set; }

        [DataMember]
        public string FlightNumber { get; set; }

        [DataMember]
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DepartureDate { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public List<SubscribedScheduledFlight> ScheduledFlights { get; set; }
    }
}
