using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Fare Type Labels
    /// </summary>
    public class MobileFareTypeLabels : BaseLabels
    {
        public string AboutOurFareTypes { get; set; }
        public string NoChangeFare { get; set; }
        public string PayToChangeFare { get; set; }
        public string FreeToChangeFare { get; set; }

        public string SevenKgHandBaggageAllowance { get; set; }
        public string ChangeOfDatesAllowedAdditionalFee { get; set; }
        public string NoRefund { get; set; }
        public string CancellationFeeIs100Percent { get; set; }
        public string CheckedBaggageAllowance { get; set; }
        public string ChangeOfDatesAllowedOnceFareIsPaid { get; set; }
        public string AbilityToGetARefund { get; set; }
        public string FortyKgCheckedBaggageAllowance { get; set; }


        //A-5616
        public string BusinessBasicFare { get; set; }
        public string BackToFares { get; set; }
        public string FifteenKgHandBaggageAllowance { get; set; }
        public string ChangeOfDatesAllowedBusinessClass { get; set; }
        public string AbilityToGetARefundBusinessClass { get; set; }
    }
}
