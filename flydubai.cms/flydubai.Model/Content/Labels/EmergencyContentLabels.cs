using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Emergency Content Labels
    /// </summary>
    public class EmergencyContentLabels : LabelsBase
    {
        [Key]
        public int EmergencyContentLabelsId { get; set; }

    [DefaultValue("Other updates")]
        public string OtherUpdatesTitle { get; set; }

        [DefaultValue("Latest update")]
        public string LatestUpdate { get; set; }

        [DefaultValue("Last updated")]
        public string LastUpdated { get; set; }

        [DefaultValue("Read more")]
        public string ReadMoreLink { get; set; }

        [DefaultValue("View all updates")]
        public string ViewAllUpdatesLink { get; set; }

        [DefaultValue("More information")]
        public string MoreInformationLink { get; set; }
    }
}
