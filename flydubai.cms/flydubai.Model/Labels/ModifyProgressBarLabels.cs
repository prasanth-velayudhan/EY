using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Progress Bar Labels
    /// </summary>
    public class ModifyProgressBarLabels : BaseLabels
    {
        [DefaultValue("Amend booking")]
        public string AmendBookingText { get; set; }

        [DefaultValue("Select sectors")]
        public string SelectSectorsText { get; set; }

        [DefaultValue("Seats and baggage")]
        public string SeatsAndBaggageText { get; set; }

        [DefaultValue("Confirm changes")]
        public string ConfirmChangesText { get; set; }
    }
}
