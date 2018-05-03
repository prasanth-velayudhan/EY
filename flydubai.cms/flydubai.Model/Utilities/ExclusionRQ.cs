using System;
using System.Collections.Generic;

namespace flydubai.Model.Utilities
{
    public class ExclusionRQ
    {
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
        public string SystemOptionKeyword { get; set; }
    }

    public class CarrierCode
    {
        public string AccessibleCarrierCode { get; set; }
    }
}
