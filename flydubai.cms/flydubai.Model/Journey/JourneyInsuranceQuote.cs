using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Journey
{
    /// <summary>
    /// Journey Insurance Quote
    /// </summary>
    [Serializable]
    public class JourneyInsuranceQuote
    {
        public Price Quote { get; set; }
        public string TransactionId { get; set; }
    }
}
