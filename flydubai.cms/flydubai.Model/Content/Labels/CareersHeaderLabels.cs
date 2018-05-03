using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Careers Header Labels
    /// </summary>
    public class CareersHeaderLabels : LabelsBase
    {
        [Key]
        public int CareersHeaderLabelsId { get; set; }

        [DefaultValue("Careers")]
        public string PageHeading { get; set; }

        [DefaultValue("Home")]
        public string MenuHome { get; set; }

        [DefaultValue("Careers")]
        public string MenuCareers { get; set; }

        [DefaultValue("About flydubai")]
        public string MenuAbout { get; set; }

        [DefaultValue("Go to flydubai.com")]
        public string MainSiteLink { get; set; }
    }
}
