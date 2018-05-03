using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Magazine Labels
    /// </summary>
    public class MagazineLabels : LabelsBase
    {
        [Key]
        public int MagazineLabelsId { get; set; }

        [DefaultValue("flydubai Magazine")]
        public string ModuleTitle { get; set; }

        [DefaultValue("See our inflight magazine")]
        public string Intro { get; set; }

        [DefaultValue("Right click to view in your browser.")]
        public string Description { get; set; }

        [DefaultValue("Download PDF")]
        public string DownloadButton { get; set; }

        [DefaultValue("Past issues")]
        public string PastIssues { get; set; }
    }
}
