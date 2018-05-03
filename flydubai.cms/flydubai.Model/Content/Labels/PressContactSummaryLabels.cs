using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Press Contact Summary Labels
    /// </summary>
    [DisplayName("Press Contact Summary Labels")]
    public class PressContactSummaryLabels : LabelsBase
    {
        [Key]
        public int PressContactSummaryLabelsId { get; set; }

        [DefaultValue("Press Contacts")]
        [DisplayName("Press Contact Summary Main Title")]
        public string PressContactSummaryMainTitle { get; set; }

        [DefaultValue("Please note that we will only be able to deal with enquiries from accredited members of the press.")]
        [DisplayName("Press Contact Summary Text")]
        public string PressContactSummaryText { get; set; }

        [DefaultValue("Call")]
        [DisplayName("Press Contact Summary Call Label")]
        public string PressContactSummaryCallLabel { get; set; }

        [DefaultValue("Email")]
        [DisplayName("Press Contact Summary Email Label")]
        public string PressContactSummaryEmailLabel { get; set; }

        [DefaultValue("Office Hours")]
        [DisplayName("Press Contact Summary Office Hours Label")]
        public string PressContactSummaryOfficeHoursLabel { get; set; }

        [DefaultValue("PR agencies in other markets")]
        [DisplayName("Press Contact Summary Global PR Contacts Link Text")]
        public string PressContactSummaryGlobalPRContactsLinkText { get; set; }
    }
}