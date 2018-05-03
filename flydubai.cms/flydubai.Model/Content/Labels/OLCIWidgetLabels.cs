using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// OLCI Widget Labels
    /// </summary>
    [DisplayName("OLCI Widget labels")]
    public class OLCIWidgetLabels : LabelsBase
    {
        [Key]
        public int OLCIWidgetLabelsId { get; set; }

        [DefaultValue("Online check-in")]
        [DisplayName("Module title")]
        public string ModuleTitle { get; set; }

        [DefaultValue("Booking Reference")]
        [DisplayName("Booking Reference")]
        public string BookingReference { get; set; }

        [DefaultValue("Last Name")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DefaultValue("View Booking")]
        [DisplayName("View Booking")]
        public string OLCIWidgetGoButton { get; set; }
    }
}
