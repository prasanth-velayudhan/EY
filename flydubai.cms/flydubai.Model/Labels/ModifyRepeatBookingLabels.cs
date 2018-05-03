using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Repeat Booking Labels
    /// </summary>
    public class ModifyRepeatBookingLabels : BaseLabels
    {
        [DefaultValue("Where would you like to fly?")]
        public string RepeatBookingTitleText { get; set; }
    }
}
