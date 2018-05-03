using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.OptionalExtras.FallBack
{
    public class FallBackScenarios
    {
        public bool fallBackValue { get; set; }
        public string fallBackMessage { get; set; }
        public string fallBackMobileMessage { get; set; }
        public string fallBackType { get; set; }
        public bool MandatoryRadixxApply { get; set; }

        public FallBackScenarios(bool fallBackValue, string fallBackMessage, string fallBackType, bool MandatoryRadixxApply, string fallbackMobileMessage)
        {
            this.fallBackValue = fallBackValue;
            this.fallBackMessage = fallBackMessage;
            this.fallBackType = fallBackType;
            this.MandatoryRadixxApply = MandatoryRadixxApply;
            this.fallBackMobileMessage = fallbackMobileMessage;
        }

    }
}
