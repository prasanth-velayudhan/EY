using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Faq Labels
    /// </summary>
    [DisplayName("FAQ labels")]
    public class FaqLabels : LabelsBase
    {
        [Key]
        public int FaqLabelsId { get; set; }

        [DefaultValue("FAQs")]
        [DisplayName("Main Header Text")]
        public string MainHeaderText { get; set; }

        [DefaultValue("Answer")]
        [DisplayName("Answer Label Text")]
        public string AnswerLabelText { get; set; }

        [DefaultValue("See All FAQs")]
        [DisplayName("See All FAQs Link Text")]
        public string SeeAllFaqsLinkText { get; set; }

        [DefaultValue("Search FAQ categories")]
        [DisplayName("Search FAQ categories Title Text")]
        public string SearchFaqsTitleText { get; set; }

        [DefaultValue("You can search via our FAQ categories:")]
        [DisplayName("Search FAQ categories instruction Text")]
        public string SearchFaqsInstructionText { get; set; }

        [DefaultValue("Select a category")]
        [DisplayName("Category dropdown list default option text")]
        public string SearchFaqsDefaultOption { get; set; }

        [DefaultValue("Search")]
        [DisplayName("Search button label")]
        public string SearchButtonLabel { get; set; }
    }
}
