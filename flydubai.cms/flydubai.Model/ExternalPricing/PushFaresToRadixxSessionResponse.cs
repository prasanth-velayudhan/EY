using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.ExternalPricing.PushFares
{
    public class PushFaresToRadixxSessionResponse
    {
        public List<Exception> Exceptions { get; set; }
        public List<FlightSegment> FlightSegments { get; set; }
    }

    public class Exception
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public int ExceptionLevel { get; set; }
    }

    public class PAXFareInfo
    {
        public string ID { get; set; }
        public int PTCID { get; set; }
        public int FareID { get; set; }
        public string FCCode { get; set; }
        public string FBCode { get; set; }
        public double BaseFareAmtNoTaxes { get; set; }
        public double BaseFareAmt { get; set; }
        public double FareAmtNoTaxes { get; set; }
        public double FareAmt { get; set; }
        public double BaseFareAmtInclTax { get; set; }
        public double FareAmtInclTax { get; set; }
        public string Cabin { get; set; }
    }

    public class FareInfo
    {
        public List<PAXFareInfo> PAXFareInfos { get; set; }
    }

    public class Faretype
    {
        public List<FareInfo> FareInfos { get; set; }
        public int FareTypeID { get; set; }
        public string FareTypeName { get; set; }
    }

    public class FlightSegment
    {
        public DateTime DepartureDate { get; set; }
        public string Destination { get; set; }
        public List<Faretype> Faretypes { get; set; }
        public string FlightNum { get; set; }
        public int LFID { get; set; }
        public string Origin { get; set; }
    }
}
