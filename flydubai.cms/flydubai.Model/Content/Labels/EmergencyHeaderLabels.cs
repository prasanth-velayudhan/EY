using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Emergency Header Labels
    /// </summary>
    [DisplayName("Emergency header labels")]
    public class EmergencyHeaderLabels : LabelsBase
    {
        [Key]
        public int EmergencyHeaderLabelsId { get; set; }

        [DefaultValue("flydubai.com")]
        [DisplayName("Main website link text")]
        public string MainSiteLink { get; set; }

        [DefaultValue("Home")]
        [DisplayName("1. Top level menu - home")]
        public string MenuHome { get; set; }

        [DefaultValue("Latest updates")]
        [DisplayName("2. Top level menu - latest updates")]
        public string MenuLatestUpdates { get; set; }

        [DefaultValue("Press centre")]
        [DisplayName("3. Top level menu - press centre")]
        public string MenuPressCentre { get; set; }
    }
}
