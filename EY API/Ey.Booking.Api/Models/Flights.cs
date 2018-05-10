using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ey.Booking.Api.Models
{
    public partial class Flights
    {
        [Required]
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [Required]
        [JsonProperty("dest")]
        public string Dest { get; set; }

        [Required]
        [JsonProperty("lfId")]
        public string LfId { get; set; }

        [Required]
        [JsonProperty("ODId")]
        public string oDId { get { return this.LfId; } }

        [Required]
        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }

        [Required]
        [JsonProperty("isAvailabile")]
        public bool IsAvailabile { get; set; }

        //[Required]
        //[JsonProperty("isInterline")]
        //public bool IsInterLine { get; set; }

        //[Required]
        //[JsonProperty("isCodeShare")]
        //public bool IsCodeShare { get; set; }

        [Required]
        [JsonProperty("stops")]
        public IList<Stops> Stops { get; set; }

        [Required]
        [JsonProperty("totalDuration")]
        public string TotalDuration { get; set; }

        [Required]
        [JsonProperty("departureTime")]
        public string DepartureTime { get; set; }

        [Required]
        [JsonProperty("arrivalTime")]
        public string ArrivalTime { get; set; }

        [Required]
        [JsonProperty("fareTypes")]
        public IList<FareTypes> FareTypes { get; set; }

        [Required]
        [JsonProperty("legs")]
        public IList<Legs> Legs { get; set; }

        [Required]
        [JsonProperty("flightNum")]
        public string FlightNum { get; set; }

        //[JsonProperty("flightGroupID")]
        //public string FlightGroupID { get; set; }
    } // end class

    public partial class Stops
    {


        [Required]
        [JsonProperty("stopLocation")]
        public string StopLocation { get; set; }

        [Required]
        [JsonProperty("layOverTime")]
        public string LayOverTime { get; set; }

        [JsonProperty("notConnection")]
        public bool NotConnection { get; set; }

    }

    public partial class MultiDayLowestFareFlights
    {
        [JsonProperty("lfId")]
        public string LfId { get; set; }

        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }

        [JsonProperty("lowestAdultFarePerPax")]
        public string LowestAdultFarePerPax { get; set; }

        [JsonProperty("lowestAdultFareTaxSumPerPax")]
        public string LowestAdultFareTaxSumPerPax { get; set; }

        [JsonProperty("lowestAdultFareNoTaxUnformatted")]
        public string LowestAdultFareNoTaxUnformatted { get; set; }

        [JsonProperty("isInterline")]
        public bool IsInterline { get; set; }

        [JsonProperty("isCodeShare")]
        public bool IsCodeShare { get; set; }

        [JsonProperty("solutionId")]
        public string SolutionId { get; set; }

        [JsonProperty("combinables")]
        public IList<string> Combinables { get; set; }

    }
}