using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Event Labels
    /// </summary>
    public class EventLabels : LabelsBase
    {
        [Key]
        public int EventLabelsId { get; set; }

        [DefaultValue("Events and tours")]
        public string ModuleTitle { get; set; }

        [DefaultValue("Book")]
        public string BookButton { get; set; }
    }
}
