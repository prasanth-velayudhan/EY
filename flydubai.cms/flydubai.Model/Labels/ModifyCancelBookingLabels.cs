using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Cancel Booking Labels
    /// </summary>
    public class ModifyCancelBookingLabels : BaseLabels
    {
        [DefaultValue("Cancel booking")]
        public string CancelBookingTitleText { get; set; }

        [DefaultValue("Are you sure you want to cancel booking reference")]
        public string AreYouSureText { get; set; }

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

        [DefaultValue("Refunds are paid via vouchers or Credited to TA Account")]
        public string RefundForTAPNR { get; set; }

        [DefaultValue("Cancel booking")]
        public string CancelBookingButton { get; set; }

        [DefaultValue("Don't cancel booking")]
        public string DontCancelBookingButton { get; set; }

        public string YourBookingHasBeenCancelled { get; set; }

        public string FurtherInformationIncludingPINHasBeenSentToEmailBelow { get; set; }

        public string TermsAndConditions { get; set; }

        public string IFELabelText { get; set; }

        public string Meal { get; set; }

        public string Points { get; set; }

        public string AmountRefundedToWeblink { get; set; }
    }
}
