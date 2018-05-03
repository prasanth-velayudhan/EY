using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Travel Agent Labels
    /// </summary>
    public class TravelAgentLabels : LabelsBase
    {
        [Key]
        public int TravelAgentLabelsId { get; set; }

        [DefaultValue("Travel agent locator")]
        public string SearchModuleTitle { get; set; }

        [DefaultValue("Select your country and city to see your nearest payment point.")]
        public string SearchModulePrompt { get; set; }

        [DefaultValue("Search")]
        public string SearchModuleForm { get; set; }

        [DefaultValue("Country")]
        public string SearchModuleCountry { get; set; }

        [DefaultValue("Town/city")]
        public string SearchModuleCity { get; set; }

        [DefaultValue("- Select -")]
        public string SearchModuleSelect { get; set; }

        [DefaultValue("Search")]
        public string SearchModuleSubmit { get; set; }

        [DefaultValue("Matched results")]
        public string ResultsModuleTitle { get; set; }

        [DefaultValue("See map")]
        public string ResultsModuleSeeMapLink { get; set; }
    }
}
