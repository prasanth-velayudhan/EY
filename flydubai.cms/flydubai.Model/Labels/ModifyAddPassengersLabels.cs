using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Add Passengers Labels
    /// </summary>
    public class ModifyAddPassengersLabels : BaseLabels
    {
        [DefaultValue("Add passenger")]
        public string AddPassengersTitleText { get; set; }

        [DefaultValue("How many passengers do you want to add?")]
        public string HowManyPassengersText { get; set; }

        [DefaultValue("Please note that this will add the passengers to all sectors in the booking.")]
        public string AddPassengersToAllSectorsText { get; set; }

        [DefaultValue("Adults")]
        public string AdultsLabelText { get; set; }

        [DefaultValue("12+ years")]
        public string TwelvePlusYearsLabelText { get; set; }

        [DefaultValue("Children")]
        public string ChildrenLabelText { get; set; }

        [DefaultValue("2-12 years")]
        public string TwoToTwelveYearsLabelText { get; set; }

        [DefaultValue("Infants")]
        public string InfantsLabelText { get; set; }

        [DefaultValue("Under 2 years")]
        public string UnderTwoYearsLabelText { get; set; }

        [DefaultValue("If you wish to add more than 9 adults and / or children to the booking, please call flydubai on XXXXXXXXX")]
        public string AddMoreThanNinePassengersText { get; set; }

        [DefaultValue("Check availability")]
        public string CheckAvailabilityButton { get; set; }
    }
}
