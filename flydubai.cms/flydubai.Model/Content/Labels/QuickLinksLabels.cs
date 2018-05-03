using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Quick Links Labels
    /// </summary>
    [DisplayName("Quick links labels")]
    public class QuickLinksLabels : LabelsBase
    {
        [Key]
        public int QuickLinksLabelsId { get; set; }

        [DefaultValue("Quick links")]
        [DisplayName("Module title")]
        public string ModuleTitle { get; set; }
    }
}
