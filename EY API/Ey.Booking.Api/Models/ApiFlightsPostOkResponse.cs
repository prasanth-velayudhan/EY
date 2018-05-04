using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ey.Booking.Api.Models
{
    public class ApiFlightsPostOkResponse
    {
        [Required]
        [JsonProperty("serverDateTimeUTC ")]
        public string ServerDateTimeUTC { get; set; }

        [Required]
        [JsonProperty("sessionDuration")]
        public string SessionDuration { get; set; }
                
        [Required]
        [JsonProperty("serverTimeGMT")]
        public string ServerTimeGMT { get; set; }

        [Required]
        [JsonProperty("segments")]
        public IList<Segments> Segments { get; set; }
        
        [Required]
        [JsonProperty("notifications")]
        public List<Notification> Notifications { get; set; }
        
        [JsonProperty("sessionExpiryGMT")]
        public DateTime SessionExpiryGMT { get; set; }

        [JsonProperty("sessionRemainingTime")]
        public int SessionRemainingTime { get; set; }
    }
}