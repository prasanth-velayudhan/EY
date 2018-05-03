using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Passenger Limit Reached Labels
    /// </summary>
    public class ModifyPassengerLimitReachedLabels : BaseLabels
    {
        [DefaultValue("Add Passengers - No Availability")]
        public string AddPassangerNoAvailabilityTitle { get; set; }

        [DefaultValue("Sorry, there was no availability to add the requested passengers to your booking.")]
        public string NoAvailabilityToAddTheRequestText { get; set; }

        [DefaultValue("Add Passenger")]
        public string PassengerLimitReachedTitleText { get; set; }

        [DefaultValue("Add Passengers - Passengers Cannot be Added")]
        public string CannotAddPassangerErrorTitle { get; set; }

        [DefaultValue("Sorry, you need to choose at least one passenger.")]
        public string PassengerLimitGreaterThanZeroText { get; set; }

        [DefaultValue("Sorry, there is a limit of 9 passengers in a single booking.")]
        public string LimitOfNinePassengersText { get; set; }

        [DefaultValue("Sorry, there must be as many adults as infants in a booking.")]
        public string AsManyAdultsAsInfantsText { get; set; }

        [DefaultValue("For assistance, please contact flydubai on XXXX XXXX XXXX.")]
        public string ForAssistanceText { get; set; }

        [DefaultValue("Ok")]
        public string OkButton { get; set; }
    }
}
