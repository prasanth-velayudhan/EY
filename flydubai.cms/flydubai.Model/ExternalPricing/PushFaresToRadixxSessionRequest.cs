using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.ExternalPricing
{
    public class PushFaresToRadixxSessionRequest
    {
        public int CorporationID { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyOfFareQuote { get; set; }
        public List<FlightSegment> FlightSegments { get; set; }
        public string IataNumber { get; set; }
        public string InventoryFilterMethod { get; set; }
        public string PromotionalCode { get; set; }
        public string SecurityGUID { get; set; }
    }
    [Serializable]
    public class ApplicableTaxDetail
    {
        public decimal Amt { get; set; }
        public string TaxCode { get; set; }
        public int TaxID { get; set; }
    }

    public class PAXFareInfo
    {
        public List<ApplicableTaxDetail> ApplicableTaxDetails { get; set; }
        public string Cabin { get; set; }
        public string FBCode { get; set; }
        public string FCCode { get; set; }
        public decimal FareAmtInclTax { get; set; }
        public decimal FareAmtNoTaxes { get; set; }
        public int FareID { get; set; }
        public string ID { get; set; }
        public int InfantAvailability { get; set; }
        public int PTCID { get; set; }
        public int SeatAvailability { get; set; }
        public decimal OriginalFare { get; set; }
        public string RuleId { get; set; }
    }

    public class FareInfo
    {
        public List<PAXFareInfo> PAXFareInfos { get; set; }
    }

    public class FareType
    {
        public List<FareInfo> FareInfos { get; set; }
        public int FareTypeID { get; set; }
        public string FareTypeName { get; set; }
    }

    public class FlightLegDetail
    {
        public DateTime DepartureDate { get; set; }
        public int PFID { get; set; }
        public string ORG { get; set; }
        public string DST { get; set; }
    }

    public class FlightSegment
    {
        public DateTime DepartureDate { get; set; }
        public string Destination { get; set; }
        public bool IsPromoApplied { get; set; }        
        //public string partyConfig { get; set; }
        public List<FareType> FareTypes { get; set; }
        public List<FlightLegDetail> FlightLegDetails { get; set; }
        public string FlightNum { get; set; }
        public int LFID { get; set; }
        public string Origin { get; set; }
    }

}
