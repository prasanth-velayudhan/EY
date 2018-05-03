using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Optional Extras Labels
    /// </summary>
    public class ModifyOptionalExtrasLabels : BaseLabels
    {
        [DefaultValue("Unfortunately one or more of the seats you selected is no longer available.")]
        public string SeatNoLongerAvailableHeadingText { get; set; }

        [DefaultValue("You can either continue with your booking without seat reservations or select alternative seats.")]
        public string SeatNoLongerAvailableHowToContinueText { get; set; }

        [DefaultValue("Save changes")]
        public string SaveChangesButton { get; set; }

        [DefaultValue("Cancel changes")]
        public string CancelChangesButton { get; set; }
    }
}
