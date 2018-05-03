using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Merchandising.FLX
{
    public class FLXRequest
    {
        public AgentInfo AgentInfo { get; set; }
        public string SalesChannel { get; set; }
        public string ResCurrency { get; set; }
        public List<OriginDestination> OriginDestination { get; set; }
        public List<PricingInformation> PricingInformation { get; set; }
        //public List<SeatMap> SeatMap { get; set; }
        public List<PaxAttributes> PaxAttributes { get; set; }
        public List<SSRDetails> SSRDetails { get; set; }
        public string GUID { get; set; }

    }

    public class FLXSeatRequest
    {
        public AgentInfo AgentInfo { get; set; }
        public string SalesChannel { get; set; }
        public string ResCurrency { get; set; }
        public List<OriginDestination> OriginDestination { get; set; }
        public List<PricingInformation> PricingInformation { get; set; }
        public List<SeatMap> SeatMap { get; set; }
        public List<PaxAttributes> PaxAttributes { get; set; }
        public List<SSRDetails> SSRDetails { get; set; }
        public string GUID { get; set; }

    }
}
