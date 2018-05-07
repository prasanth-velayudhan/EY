using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ey.Booking.Api.Models
{
    public partial class FareTypes
    {
        [Required]
        [JsonProperty("route")]
        public string Route { get; set; }

        [Required]
        [JsonProperty("lfId")]
        public string LfId { get; set; }

        [Required]
        [JsonProperty("fareTypeID")]
        public string FareTypeID { get; set; }

        [Required]
        [JsonProperty("fareTypeName")]
        public string FareTypeName { get; set; }
        [Required]
        [JsonProperty("includes")]
        public Dictionary<IncludeServiceType, string> IncludedServices { get; set; }
        [Required]
        [JsonProperty("pfIds")]
        public IList<PfIds> PfIds { get; set; }

        [Required]
        [JsonProperty("cabin")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Cabin Cabin { get; set; }

        [Required]
        [JsonProperty("secureHash")]
        public string SecureHash { get; set; }

        [Required]
        [JsonProperty("fareCarrier")]
        public string FareCarrier { get; set; }

        [Required]
        [JsonProperty("ticketDesignator")]
        public string TicketDesignator { get; set; }

        [Required]
        [JsonProperty("hashCode")]
        public string HashCode { get; set; }

        [Required]
        [JsonProperty("fare")]
        public Fare Fare { get; set; }

        [Required]
        [JsonProperty("fareInformation")]
        public FareInformation FareInformation { get; set; }

        [Required]
        [JsonProperty("seatsLeft")]
        public int? SeatsLeft { get; set; }

        [Required]
        [JsonProperty("isSoldOut")]
        public bool IsSoldOut { get; set; }

        [Required]
        [JsonProperty("containsCircularFlight")]
        public bool ContainsCircularFlight { get; set; }

        [Required]
        [JsonProperty("containsConnectionFlight")]
        public bool ContainsConnectionFlight { get; set; }
    }

    public partial class Fare
    {
        [Required]
        [JsonProperty("baseFare")]
        public string BaseFare { get; set; }

        [Required]
        [JsonProperty("tax")]
        public string Tax { get; set; }

        [Required]
        [JsonProperty("changeCost")]
        public string ChangeCost { get; set; }

        [Required]
        [JsonProperty("discount")]
        public string Discount { get; set; }

        [Required]
        [JsonProperty("totalFare")]
        public string TotalFare { get; set; }

        [Required]
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [Required]
        [JsonProperty("isPromoFare")]
        public bool IsPromoFare { get; set; }

        [Required]
        [JsonProperty("isPromoCodeApplied")]
        public bool IsPromoCodeApplied { get; set; }

        [Required]
        [JsonProperty("solutionId")]
        public string SolutionId { get; set; }

        [Required]
        [JsonProperty("isStopOverFare")]
        public bool IsStopOverFare { get; set; }

        [Required]
        [JsonProperty("combinables")]
        public IList<string> Combinables { get; set; }
    }

    public partial class FareInformation
    {
        [Required]
        [JsonProperty("adultFares")]
        public IList<AdultFares> AdultFares { get; set; }

        [Required]
        [JsonProperty("childFares")]
        public IList<ChildFares> ChildFares { get; set; }

        [Required]
        [JsonProperty("infantFares")]
        public IList<InfantFares> InfantFares { get; set; }
    }
    public partial class AdultFares
    {


        [Required]
        [JsonProperty("adultFarePerPax")]
        public string AdultFarePerPax { get; set; }

        [Required]
        [JsonProperty("baseAdultFarePerPax")]
        public string BaseAdultFarePerPax { get; set; }

        [Required]
        [JsonProperty("changeCost")]
        public string ChangeCost { get; set; }

        [Required]
        [JsonProperty("fareId")]
        public string FareId { get; set; }

        [Required]
        [JsonProperty("fareBasisCode")]
        public string FareBasisCode { get; set; }

        [Required]
        [JsonProperty("fareClass")]
        public string FareClass { get; set; }

        [Required]
        [JsonProperty("fareAmtNoTaxes")]
        public string FareAmtNoTaxes { get; set; }

        [Required]
        [JsonProperty("taxPerPax")]
        public string TaxPerPax { get; set; }

        [Required]
        [JsonProperty("discountPerPax")]
        public string DiscountPerPax { get; set; }

        [Required]
        [JsonProperty("paxCount")]
        public int PaxCount { get; set; }

        [Required]
        [JsonProperty("applicableTaxes")]
        public IList<ApplicableTaxes> ApplicableTaxes { get; set; }

        [Required]
        [JsonProperty("includedExtas")]
        public IList<IncludedExtas> IncludedExtas { get; set; }

        //[Required]
        //[JsonProperty("pointsEarned")]
        //public PointsEarned PointsEarned { get; set; }

        //Pricing Analytics
        [Required]
        [JsonProperty("ruleName")]
        public string RuleName { get; set; }

        [Required]
        [JsonProperty("ruleValue")]
        public string RuleValue { get; set; }
    }
    public partial class ChildFares
    {


        [Required]
        [JsonProperty("fareId")]
        public string FareId { get; set; }

        [Required]
        [JsonProperty("fareBasisCode")]
        public string FareBasisCode { get; set; }

        [Required]
        [JsonProperty("fareClass")]
        public string FareClass { get; set; }

        [Required]
        [JsonProperty("childFarePerPax")]
        public string ChildFarePerPax { get; set; }

        [Required]
        [JsonProperty("baseChildFarePerPax")]
        public string BaseChildFarePerPax { get; set; }

        [Required]
        [JsonProperty("changeCost")]
        public string ChangeCost { get; set; }


        [Required]
        [JsonProperty("taxPerPax")]
        public string TaxPerPax { get; set; }

        [Required]
        [JsonProperty("discountPerPax")]
        public string DiscountPerPax { get; set; }

        [Required]
        [JsonProperty("paxCount")]
        public int PaxCount { get; set; }

        [Required]
        [JsonProperty("applicableTaxes")]
        public IList<ApplicableTaxes> ApplicableTaxes { get; set; }

        [Required]
        [JsonProperty("includedExtas")]
        public IList<IncludedExtas> IncludedExtas { get; set; }

        //Pricing Analytics
        [Required]
        [JsonProperty("ruleName")]
        public string RuleName { get; set; }

        [Required]
        [JsonProperty("ruleValue")]
        public string RuleValue { get; set; }
    }
    public partial class InfantFares
    {


        [Required]
        [JsonProperty("baseInfantFarePerPax")]
        public string BaseInfantFarePerPax { get; set; }

        [Required]
        [JsonProperty("infantFarePerPax")]
        public string InfantFarePerPax { get; set; }

        [Required]
        [JsonProperty("changeCost")]
        public string ChangeCost { get; set; }

        [Required]
        [JsonProperty("fareBasisCode")]
        public string FareBasisCode { get; set; }

        [Required]
        [JsonProperty("fareClass")]
        public string FareClass { get; set; }

        [Required]
        [JsonProperty("fareId")]
        public string FareId { get; set; }

        [Required]
        [JsonProperty("taxPerPax")]
        public string TaxPerPax { get; set; }

        [Required]
        [JsonProperty("discountPerPax")]
        public string DiscountPerPax { get; set; }

        [Required]
        [JsonProperty("paxCount")]
        public int PaxCount { get; set; }

        [Required]
        [JsonProperty("applicableTaxes")]
        public IList<ApplicableTaxes> ApplicableTaxes { get; set; }

        [Required]
        [JsonProperty("includedExtas")]
        public IList<IncludedExtas> IncludedExtas { get; set; }

        //Pricing Analytics
        [Required]
        [JsonProperty("ruleName")]
        public string RuleName { get; set; }

        [Required]
        [JsonProperty("ruleValue")]
        public string RuleValue { get; set; }
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncludeServiceType
    {
        RFNDELG,
        CHDTELG,
        UPGRELG,
        PRCHKIN,
        PRFSEAT,
        CHKDBAG,
        MILEARN,
        CHDTFEE,
        RFNDFEE,
        [EnumMember(Value = "handBaggage")]
        HandBaggage,
        [EnumMember(Value = "checkinBaggage")]

        CheckinBaggage,

        [EnumMember(Value = "ife")]
        InflighEntertainment,

        [EnumMember(Value = "meals")]
        Meals,

        [EnumMember(Value = "seats")]
        SeatSelection,

        [EnumMember(Value = "refund")]
        Refund
    }

    public partial class ApplicableTaxes
    {


        [Required]
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [Required]
        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }

        [Required]
        [JsonProperty("taxId")]
        public string TaxId { get; set; }
    }
    public partial class IncludedExtas
    {


        [Required]
        [JsonProperty("type")]
        public string Type { get; set; }

        [Required]
        [JsonProperty("code")]
        public string Code { get; set; }

        [Required]
        [JsonProperty("value")]
        public string Value { get; set; }
    }

}