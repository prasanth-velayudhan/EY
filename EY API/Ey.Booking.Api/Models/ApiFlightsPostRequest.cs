using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ey.Booking.Api.Models
{
    public class ApiFlightsPostRequest
    {
        [Required]
        [JsonProperty("promoCode")]
        public string PromoCode { get; set; }

        [Required]
        [JsonProperty("journeyType")]
        public string JourneyType { get; set; }

        [Required]
        [JsonProperty("cabinClass")]
        //[JsonConverter(typeof(StringEnumConverter))]
        public string CabinClass { get; set; }

        [Required]
        [JsonProperty("searchCriteria")]
        public Searchcriteria[] SearchCriteria { get; set; }

        [Required]
        [JsonProperty("paxInfo")]
        public Paxinfo PaxInfo { get; set; }
    }

    public class Paxinfo
    {       
        [JsonProperty("adultCount")]
        public int? AdultCount { get; set; }


        [JsonProperty("infantCount")]
        public int? InfantCount { get; set; }


        [JsonProperty("childCount")]
        public int? ChildCount { get; set; }
    }

    public class Searchcriteria
    {
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("dest")]
        public string Dest { get; set; }

        [JsonProperty("direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public string Direction { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }
}