using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Uae Visas Labels
    /// </summary>
    public class UaeVisasLabels : LabelsBase
    {
        [Key]
        public int UaeVisasLabelsId { get; set; }

        [DefaultValue("How to apply")]
        public string ModuleTitle { get; set; }

        [DefaultValue("Resident status")]
        public string ResidentStatus { get; set; }

        [DefaultValue("- Select -")]
        public string Select { get; set; }

        [DefaultValue("Download form")]
        public string DownloadButton { get; set; }
    }
}
