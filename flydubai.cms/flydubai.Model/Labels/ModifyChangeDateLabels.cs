using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Change Date Labels
    /// </summary>
    public class ModifyChangeDateLabels : BaseLabels
    {
        [DefaultValue("Search for alternative dates")]
        public string ChangeDateTitleText { get; set; }

        [DefaultValue("to")]
        [DisplayName("\"To\" text (goes between origin and destination airports) (e.g. [origin] \"To\" [destination])")]
        public string ToText { get; set; }

        [DefaultValue("I am flexible on dates ( +/- 3 days )")]
        public string FlexibleOnDatesCheckbox { get; set; }

        [DefaultValue("Since the sector you are changing is a {0} fare, {1} will be paid on cancellation of the existing sector.")]
        [DisplayName("No refund message text when no change fare (use {0} for no change, {1} for no refund) (e.g. Since the sector you are changing is a {0} fare, {1} will be paid on cancellation of the existing sector.)")]
        public string NoRefundMessageText { get; set; }

        [DefaultValue("no change")]
        [DisplayName("No change text (used in no refund message)")]
        public string NoChangeText { get; set; }

        [DefaultValue("no refund")]
        [DisplayName("No refund text (used in no refund message)")]
        public string NoRefundText { get; set; }

        [DefaultValue("Changes apply to all passengers")]
        public string ChangesApplyToAllPassengersText { get; set; }

        [DefaultValue("Find alternative sector")]
        public string FindAlternativeSectorButton { get; set; }

        public string InsuranceOutOfCoverage { get; set; }

        public string InsuranceOutOfCoveredForTheFirst90Days { get; set; }

        public string Cancel { get; set; }

    }
}
