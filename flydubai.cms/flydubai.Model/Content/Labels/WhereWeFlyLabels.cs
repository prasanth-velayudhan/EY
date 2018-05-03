using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Where We Fly Labels
    /// </summary>
    [DisplayName("Where we fly labels")]
    public class WhereWeFlyLabels : LabelsBase
    {
        [Key]
        public int WhereWeFlyLabelsId { get; set; }

        [DefaultValue("Where we fly")]
        [DisplayName("Module title")]
        public string ModuleTitle { get; set; }

        [DefaultValue("Find destinations")]
        [DisplayName("Find destinations link")]
        public string FindDestinationsLink { get; set; }

        [DefaultValue("Go")]
        [DisplayName("We Fly Go Button")]
        public string WeFlyGoButton { get; set; }
    }
}
