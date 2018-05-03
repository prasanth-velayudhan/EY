using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ey.Booking.Api.Models
{
    public partial class Legs
    {

        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }


        [JsonProperty("departureTime")]
        public string DepartureTime { get; set; }


        [JsonProperty("arrivalDate")]
        public string ArrivalDate { get; set; }

        [JsonProperty("hasFreeMeals")]
        public bool HasFreeMeals { get; set; }

        [JsonProperty("arrivalTime")]
        public string ArrivalTime { get; set; }


        [JsonProperty("flightDuration")]
        public string FlightDuration { get; set; }


        [JsonProperty("pfId")]
        public string PfId { get; set; }


        [JsonProperty("flightNumber")]
        public string FlightNumber { get; set; }

        [JsonProperty("isCircularNextLeg")]
        public bool IsCircularNextLeg { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }


        [JsonProperty("destination")]
        public string Destination { get; set; }


        [JsonProperty("originMetroGroup")]
        public string OriginMetroGroup { get; set; }


        [JsonProperty("destinationMetroGroup")]
        public string DestinationMetroGroup { get; set; }

        [JsonProperty("operatingCarrier")]
        public string OperatingCarrier { get; set; }

        [JsonProperty("marketingCarrier")]
        public string MarketingCarrier { get; set; }

        [JsonProperty("marketingFlightNum")]
        public string MarketingFlightNum { get; set; }

        [JsonProperty("fromTerminal")]
        public string FromTerminal { get; set; }

        [JsonProperty("toTerminal")]
        public string ToTerminal { get; set; }

        [JsonProperty("selectedSeatQuotes")]
        public IList<Seats> SelectedSeatQuotes { get; set; }

        [JsonProperty("isBusRoute")]
        public bool IsBusRoute { get; set; }

        [JsonProperty("equipmentType")]
        public string EquipmentType { get; set; }

    }

    public partial class PfIds
    {


        [Required]
        [JsonProperty("pfId")]
        public string PfId { get; set; }

        [JsonProperty("cabin")]
        public string Cabin { get; set; }

        [JsonProperty("fareClass")]
        public string FareClass { get; set; }

        [Required]
        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class Seats
    {

        [JsonProperty("passangerId")]
        public string PassangerId { get; set; }

        [JsonProperty("secureHash")]
        public string SecureHash { get; set; }

        [JsonProperty("segmentId")]
        public string LogicalFlightID { get; set; }

        [JsonProperty("legId")]
        public string PhyscialFlightID { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("codeType")]
        public string CodeType { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("flxDignoticId")]
        public string FLXDiagnosticID { get; set; }

        [JsonProperty("serviceId")]
        public string ServiceId { get; set; }

        [JsonProperty("amount")]
        public decimal Total { get; set; }

        [JsonProperty("row")]
        public int Row { get; set; }

        [JsonProperty("seat")]
        public string Seat { get; set; }

        [JsonProperty("seatHeldId")]
        public int SeatHeldId { get; set; }
    }
}