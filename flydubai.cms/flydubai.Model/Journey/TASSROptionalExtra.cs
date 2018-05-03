using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Journey
{
    /// <summary>
    /// TASSR Optional Extra
    /// </summary>
    [Serializable]
    public class TASSROptionalExtra : JourneyOptionalExtra
    {
        public string CurrencyCode { get; set; }
    }
}
