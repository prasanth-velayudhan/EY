using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Add Passengers Flight Summary Labels
    /// </summary>
    public class ModifyAddPassengersFlightSummaryLabels : BaseLabels
    {
        [DefaultValue("Journey {0}")]
        [DisplayName("Journey number label text (use {0} for the journey number) (e.g. Journey {0})")]
        public string JourneyNumberLabelText { get; set; }

        [DefaultValue("Depart")]
        public string DepartureDateLabelText { get; set; }

        [DefaultValue("Flight No.")]
        public string FlightNumberColumnHeading { get; set; }

        [DefaultValue("Departing")]
        public string DepartingColumnHeading { get; set; }

        [DefaultValue("Arrival")]
        public string ArrivalColumnHeading { get; set; }

        [DefaultValue("Fare Type")]
        public string FareTypeColumnHeading { get; set; }

        [DefaultValue("Pay to change")]
        public string FareType1Name { get; set; }

        [DefaultValue("Free to change")]
        public string FareType2Name { get; set; }

        [DefaultValue("Adult")]
        public string Adult { get; set; }

        [DefaultValue("Children")]
        public string Children { get; set; }

        [DefaultValue("Infant")]
        public string Infant { get; set; }

        [DefaultValue("Business Basic")]
        public string BusinessBasic { get; set; }
    }
}
