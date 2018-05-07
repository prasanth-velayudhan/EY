using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ey.Booking.Api.Models
{

    public partial class Segments
    {
        [Required]
        [JsonProperty("route")]
        public string Route { get; set; }

        [Required]
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [Required]
        [JsonProperty("dest")]
        public string Dest { get; set; }
        [Required]
        [JsonProperty("operatingCarrier")]
        public string OperatingCarrier { get; set; }

        [Required]
        [JsonProperty("direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Direction Direction { get; set; }

        [Required]
        [JsonProperty("lowestAdultFarePerPax")]
        public string LowestAdultFarePerPax { get; set; }

        [Required]
        [JsonProperty("lowestAdultFareTaxSumPerPax")]
        public string LowestAdultFareTaxSumPerPax { get; set; }

        [Required]
        [JsonProperty("lowestAdultFareNoTaxUnformatted")]
        public string LowestAdultFareNoTaxUnformatted { get; set; }

        [Required]
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [Required]
        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }

        [Required]
        [JsonProperty("isPromoFare")]
        public bool IsPromoFare { get; set; }

        [Required]
        [JsonProperty("isSoldOut")]
        public bool IsSoldOut { get; set; }

        [Required]
        [JsonProperty("flights")]
        public IList<Flights> Flights { get; set; }

        [Required]
        [JsonProperty("multiDayflights")]
        public IList<MultiDayflights> MultiDayFlights { get; set; }

        [Required]
        [JsonProperty("brands")]
        public IList<Brand> Brands { get; set; }

        [Required]
        [JsonProperty("notifications")]
        public IList<Notification> Notifications { get; set; }


        [Required]
        [JsonProperty("isInterline")]
        public bool IsInterline { get; set; }

        [Required]
        [JsonProperty("isCodeShare")]
        public bool IsCodeShare { get; set; }
       
    } // end class

    public partial class Brand
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [Required]
        [JsonProperty("fareTypeID")]
        public string FareTypeID { get; set; }
        [Required]
        [JsonProperty("cabin")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Cabin Cabin { get; set; }

        [Required]
        [JsonProperty("includes")]
        public Dictionary<IncludeServiceType, string> IncludedServices { get; set; }

        [Required]
        [JsonProperty("orderId")]
        public int OrderId { get; set; }
    }
    public partial class MultiDayflights
    {
        [Required]
        [JsonProperty("lowestAdultFarePerPax")]
        public string LowestAdultFarePerPax { get; set; }

        [Required]
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [Required]
        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }

        [Required]
        [JsonProperty("isSoldOut")]
        public bool IsSoldOut { get; set; }
    }

        public enum Direction
    {
        outBound, inBound, multiSector
    }

    public enum Cabin
    {
        economy, business, first
    }
}