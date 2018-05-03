using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Ways To Pay Labels
    /// </summary>
    [DisplayName("Ways To Pay Labels")]
    public class WaysToPayLabels : LabelsBase
    {
        [Key]
        public int WaysToPayLabelsId { get; set; }

        [DefaultValue("Ways To Pay")]
        [DisplayName("Summary Main Title")]
        public string SummaryMainTitle { get; set; }

        [DefaultValue("Find out more")]
        [DisplayName("Find out more link")]
        public string FindOutMoreLinkText { get; set; }
    }
}