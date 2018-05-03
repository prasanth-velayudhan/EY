using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Remove Passenger Labels
    /// </summary>
    public class ModifyRemovePassengerLabels : BaseLabels
    {
        [DefaultValue("Remove passenger")]
        public string RemovePassengerTitleText { get; set; }

        [DefaultValue("Remove {0} from")]
        [DisplayName("Remove passenger from (use {0} for the passenger name) (e.g. Remove {0} from)")]
        public string RemovePassengerFromText { get; set; }

        [DefaultValue("Fare")]
        public string FareLabelText { get; set; }

        [DefaultValue("Taxes")]
        public string TaxesLabelText { get; set; }

        [DefaultValue("Services")]
        public string ServicesSectionLabelText { get; set; }

        [DefaultValue("Baggage")]
        public string BaggageLabelText { get; set; }

        [DefaultValue("Meal")]
        public string MealLabelText { get; set; }

        [DefaultValue("Seating total")]
        public string SeatingTotalLabelText { get; set; }

        [DefaultValue("Non-refundable")]
        public string NonRefundableLabelText { get; set; }

        [DefaultValue("Insurance")]
        public string InsuranceLabelText { get; set; }

        [DefaultValue("Penalty")]
        public string PenaltyLabelText { get; set; }

        [DefaultValue("Total refund")]
        public string TotalRefundLabelText { get; set; }

        [DefaultValue("All refunds are paid via voucher which can be redeemed against any future flydubai flights")]
        public string AllRefundsPaidViaVoucherText { get; set; }

        [DefaultValue("Remove passenger")]
        public string RemovePassengerButton { get; set; }

        [DefaultValue("Don't remove passenger")]
        public string DontRemovePassengerButton { get; set; }

        [DefaultValue("In-flight entertainment")]
        public string IFETotalLabelText { get; set; }
    }
}
