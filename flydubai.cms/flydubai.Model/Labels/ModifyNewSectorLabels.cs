using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify New Sector Labels
    /// </summary>
    public class ModifyNewSectorLabels : BaseLabels
    {
        [DefaultValue("Departing")]
        public string DepartingColumnHeading { get; set; }

        [DefaultValue("Arrival")]
        public string ArrivalColumnHeading { get; set; }

        [DefaultValue("Duration")]
        public string DurationColumnHeading { get; set; }

        [DefaultValue("Flight No.")]
        public string FlightNumberColumnHeading { get; set; }

        [DefaultValue("Price")]
        public string PriceColumnHeading { get; set; }

        public string UnfortunatlyWeAreUnableToMakeTheChangesYouRequested { get; set; }

        public string ThisIsDueToYourSelectedOptionsNoLongerBeingAvailable { get; set; }

        public string ReturnToMyBooking { get; set; }

        public string Continue { get; set; }

        public string CompletePayment { get; set; }
    }
}
