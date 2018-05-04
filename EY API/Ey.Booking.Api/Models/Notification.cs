using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ey.Booking.Api.Models
{
    public class Notification
    {
        public Notification()
        {
            this.CanContinue = true;
            this.Pnr = null;
        }

        [Required]
        [JsonProperty("cmsKey")]
        public string CmsKey { get; set; }

        [Required]
        [JsonProperty("defaultMessage")]
        public string DefaultMessage { get; set; }

        [Required]
        [JsonProperty("displayLevel")]
        public string DisplayLevel { get; set; }

        [Required]
        [JsonProperty("canContinue")]
        public bool CanContinue { get; set; }

        [Required]
        [JsonProperty("pnr")]
        public string Pnr { get; set; }

        [JsonProperty("lstExtraProperties")]
        public List<ExtraProperties> LstExtraProperties { get; set; }
    }

    public class ExtraProperties
    {
        [Required]
        [JsonProperty("key")]
        public string Key { get; set; }

        [Required]
        [JsonProperty("lfId")]
        public string lfId { get; set; }

        [Required]
        [JsonProperty("value")]
        public string Value { get; set; }

        [Required]
        [JsonProperty("canContinue")]
        public bool CanContinue { get; set; }

        [Required]
        [JsonProperty("remarks")]
        public string Remarks { get; set; }
    }
}