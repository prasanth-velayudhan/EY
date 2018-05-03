using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Experience Labels
    /// </summary>
    public class ExperienceLabels : LabelsBase
    {
        [Key]
        public int ExperienceLabelsId { get; set; }

        [DefaultValue("flydubai Experience")]
        public string Title { get; set; }

        [DefaultValue("Please select your experience:")]
        public string SelectLabel { get; set; }
    }
}
