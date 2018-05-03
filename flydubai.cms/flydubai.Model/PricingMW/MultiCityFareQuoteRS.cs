using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.PricingMW
{
    public class MultiCityFareQuoteRS
    {
        public FareQuoteResponse fareQuoteResponse { get; set; }
    }

    public class ApplicableTaxDetail
    {
        public int taxID { get; set; }
        public decimal amt { get; set; }
    }

    public class ApplicableTaxDetails
    {
        public List<ApplicableTaxDetail> applicableTaxDetail { get; set; }
    }

    public class AccruedPoints
    {
        public string baseRewardPoints { get; set; }
        public string bonusRewardPoints { get; set; }
        public string baseTierPoints { get; set; }
        public string bonusTierPoints { get; set; }
    }

    public class BookingCode
    {
        public string RBD { get; set; }
        public string cabin { get; set; }
        public int segmentID { get; set; }
        public DateTime depDateTime { get; set; }
    }

    public class PaxFareInfo
    {
        public int fareID { get; set; }
        public string paxID { get; set; }
        public string fareClass { get; set; }
        public string FBC { get; set; }
        public string fareCarrier { get; set; }
        public decimal baseFare { get; set; }
        public decimal tax { get; set; }
        public decimal total { get; set; }
        public int PTC { get; set; }
        public string cabin { get; set; }
        public bool specialMarketed { get; set; }
        public int promotionCatID { get; set; }
        public ApplicableTaxDetails applicableTaxDetails { get; set; }
        public AccruedPoints accruedPoints { get; set; }
        public List<int> includedServiceRef { get; set; }
        public string secureHash { get; set; }
        public List<BookingCode> bookingCode { get; set; }
        public decimal originalFare { get; set; }
    }

    public class PaxFareInfos
    {
        public List<PaxFareInfo> paxFareInfo { get; set; }
    }

    public class FareBrand
    {
        public int fareBrandID { get; set; }
        public int solnID { get; set; }
        public string fareBrandName { get; set; }
        public PaxFareInfos paxFareInfos { get; set; }
    }

    public class FareBrands
    {
        public List<FareBrand> fareBrand { get; set; }
    }

    public class FlightSegmentDetail
    {
        public int segmentID { get; set; }
        public DateTime depDateTime { get; set; }
    }

    public class FlightSegmentDetails
    {
        public List<FlightSegmentDetail> flightSegmentDetail { get; set; }
    }

    public class OrgDes
    {
        public int odID { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime depDateTime { get; set; }
        public DateTime arrDateTime { get; set; }
        public int flightTime { get; set; }
        public FareBrands fareBrands { get; set; }
        public FlightSegmentDetails flightSegmentDetails { get; set; }
    }

    public class ODs
    {
        public List<OrgDes> originDestination { get; set; }
    }

    public class SegmentDetail
    {
        public int segmentID { get; set; }
        public DateTime depDateTime { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime arrDateTime { get; set; }
        public int flightTime { get; set; }
        public string mrktCarrier { get; set; }
        public string mrktFlightNum { get; set; }
        public string operFlightNum { get; set; }
        public string operCarrier { get; set; }
        public string fromTerminal { get; set; }
        public string toTerminal { get; set; }
        public string aircraftType { get; set; }
    }

    public class SegmentDetails
    {
        public List<SegmentDetail> segmentDetail { get; set; }
    }

    public class TaxDetail
    {
        public int taxID { get; set; }
        public string taxCode { get; set; }
        public string codeType { get; set; }
        public string taxDesc { get; set; }
    }

    public class TaxDetails
    {
        public List<TaxDetail> taxDetail { get; set; }
    }

    public class ServiceDetail
    {
        public int ID { get; set; }
        public string code { get; set; }
        public string desc { get; set; }
    }

    public class ServiceDetails
    {
        public List<ServiceDetail> serviceDetail { get; set; }
    }

    public class BS
    {
        public List<int> solnRef { get; set; }
        public int ID { get; set; }
    }

    public class Combinability
    {
        public List<BS> BS { get; set; }
    }

    public class FareQuoteResponse
    {
        public ODs originDestinations { get; set; }
        public SegmentDetails segmentDetails { get; set; }
        public TaxDetails taxDetails { get; set; }
        public ServiceDetails serviceDetails { get; set; }
        public Combinability combinability { get; set; }
    }    
}
