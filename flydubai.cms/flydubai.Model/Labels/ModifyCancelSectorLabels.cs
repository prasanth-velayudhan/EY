using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Cancel Sector Labels
    /// </summary>
    public class ModifyCancelSectorLabels : BaseLabels
    {
        [DefaultValue("Cancel sector")]
        public string CancelSectorTitleText { get; set; }

        [DefaultValue("Are you sure you want to cancel sector")]
        public string AreYouSureYouWantToCancelSectorText { get; set; }

        [DefaultValue("to")]
        [DisplayName("\"To\" text (goes between origin and destination airports) (e.g. [origin] \"To\" [destination])")]
        public string ToText { get; set; }

        [DefaultValue("Fare")]
        public string FareLabelText { get; set; }

        [DefaultValue("Taxes")]
        public string TaxesLabelText { get; set; }

        [DefaultValue("Services")]
        public string ServicesSectionLabelText { get; set; }

        [DefaultValue("Baggage")]
        public string BaggageLabelText { get; set; }

        [DefaultValue("Seating total")]
        public string SeatingTotalLabelText { get; set; }

        [DefaultValue("Non-refundable")]
        public string NonRefundableSectionLabelText { get; set; }

        [DefaultValue("Insurance")]
        public string InsuranceLabelText { get; set; }

        [DefaultValue("Penalty")]
        public string PenaltyLabelText { get; set; }

        [DefaultValue("Total refund")]
        public string TotalRefundLabelText { get; set; }

        [DefaultValue("All refunds are paid via voucher which can be redeemed against any future flydubai flights")]
        public string AllRefundsPaidViaVoucherText { get; set; }

        [DefaultValue("Cancel booking")]
        public string CancelSectorButton { get; set; }

        [DefaultValue("Don't cancel booking")]
        public string DontCancelSectorButton { get; set; }

        [DefaultValue("In Flight Entertainment")]
        public string IFELabelText { get; set; }

        [DefaultValue("Meal")]
        public string Meal { get; set; }
    }
}
