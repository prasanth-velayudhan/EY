using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// How To Book Labels
    /// </summary>
    [DisplayName("How To Book Labels")]
    public class HowToBookLabels : LabelsBase
    {
        [Key]
        public int HowToBookLabelsId { get; set; }

        [DefaultValue("How To Book")]
        [DisplayName("Summary Main Title")]
        public string SummaryMainTitle { get; set; }

        [DefaultValue("You can also book via these methods.")]
        [DisplayName("Summary Instruction Text")]
        public string SummaryInstructionText { get; set; }
        
        [DefaultValue("Telephone")]
        [DisplayName("Telephone Booking Method Label")]
        public string TelephoneLinkText { get; set; }

        [DefaultValue("Agent")]
        [DisplayName("Agent Booking Method Label")]
        public string AgentLinkText { get; set; }
    }
}