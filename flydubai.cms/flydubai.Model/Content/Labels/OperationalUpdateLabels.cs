using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Operational Update Labels
    /// </summary>
    public class OperationalUpdateLabels : LabelsBase
    {
        [Key]
        public int OperationalUpdateLabelsId { get; set; }

        [DefaultValue("Operational updates")]
        public string SidebarModuleTitle { get; set; }

        [DefaultValue("Read more")]
        public string ReadMoreLink { get; set; }
    }
}
