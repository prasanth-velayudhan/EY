using System;
using System.Collections.Generic;
using System.Linq;

using flydubai.Model.Common;
using flydubai.Model.Search;

namespace flydubai.Model.Results.Pricing
{
    /// <summary>
    /// Multiple Day Journey Segment
    /// </summary>
    [Serializable]
    public class PricingAncillaries
    {
        public List<ServiceQuote> ServiceQuotes { get; set; }
        public List<Exception>Exceptions { get; set; }
    }

    public class LogicalFlight
    {
        public Segment Segments { get; set; }
        public List<Leg> Legs { get; set; }
    }
    public class ServiceQuotes
    {
        public string SSRCode { get; set; }
        public int CategoryID { get; set; }
        public string CutoffHours { get; set; }
        public bool AmountActive { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public int MaxCountFlightLevel { get; set; }
        public int MaxCountServiceLevel { get; set; }
        public int QuantityAvailable { get; set; }
    }

    public class Segment
    {
        public int LFid { get; set; }
        public string DepartureDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public List<ServiceQuotes> ServiceQuote { get; set; }
    }
    public class Leg
    {
        public int LFID { get; set; }
        public int PFID { get; set; }
        public string DepartureDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public List<ServiceQuotes> ServiceQuote { get; set; }
    }

    public class ServiceQuote
    {
        public List<LogicalFlight> LogicalFlight { get; set; }
    }

    public class Exception
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public int ExceptionLevel { get; set; }
    }
}
