using flydubai.Model.ExternalPricing.PushFares;
using System.Collections.Generic;

namespace flydubai.Model.Utilities
{
    public class ExclusionRS
    {
        public string SystemOptionValue { get; set; }
        public List<Exception> Exceptions { get; set; }
    }
}
