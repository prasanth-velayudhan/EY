using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Flight Search Narrow Tab Labels
    /// </summary>
    [DisplayName("Flight Search Narrow Tab Labels (shared between booking path and content website)")]
    public class FlightSearchNarrowTabLabels : BaseLabels, IFlightSearchTabLabels
    {
        [DefaultValue("Round trip or one way selector")]
        public string ReturnOneWayAccessibilityText { get; set; }

        [DefaultValue("Return")]
        public string ReturnRadioButtonText { get; set; }

        [DefaultValue("One way")]
        public string OneWayRadioButtonText { get; set; }

        [DefaultValue("Flying from and / or to")]
        public string FlyingFromFlyingToAccessibilityText { get; set; }

        [DefaultValue("Flying from:")]
        public string FlyingFromLabelText { get; set; }

        [DefaultValue("From")]
        public string FlyingFromPlaceholderText { get; set; }

        [DefaultValue("Flying to:")]
        public string FlyingToLabelText { get; set; }

        [DefaultValue("To")]
        public string FlyingToPlaceholderText { get; set; }

        [DefaultValue("Multiple destinations")]
        public string AddMultipleDestinationsButton { get; set; }

        [DefaultValue("Flying dates")]
        public string FlyingDatesAccessibilityText { get; set; }

        [DefaultValue("Flying out on:")]
        public string FlyingOutOnLabelText { get; set; }

        [DefaultValue("Flying back on:")]
        public string FlyingBackOnLabelText { get; set; }

        [DefaultValue("Flexible on dates")]
        public string FlexibleOnDatesCheckboxText { get; set; }

        [DefaultValue("Passengers")]
        public string PassengersAccessibilityText { get; set; }

        [DefaultValue("Passengers:")]
        public string PassengersLabelText { get; set; }

        [DefaultValue("Adults")]
        public string AdultsLabelText { get; set; }

        [DefaultValue("> 12 yrs")]
        public string AdultsAgeLabelText { get; set; }

        [DefaultValue("Children")]
        public string ChildrenLabelText { get; set; }

        [DefaultValue("2 - 12 yrs")]
        public string ChildrenAgeLabelText { get; set; }

        [DefaultValue("Infants")]
        public string InfantsLabelText { get; set; }

        [DefaultValue("< 2 yrs")]
        public string InfantsAgeLabelText { get; set; }

        [DefaultValue("Infants")]
        public string InfantsTooltipHeadingText { get; set; }

        [DefaultValue("An infant's age must be over 14 days and under 2 years on the date of travel.")]
        public string InfantsTooltipBodyText { get; set; }

        [DefaultValue("Want to make a booking for 9 or more?")]
        public string GroupBookingsLinkText { get; set; }

        [DefaultValue("Group bookings")]
        public string GroupBookingsTooltipHeadingText { get; set; }

        [DefaultValue("You can book online for a maximum of 9 passengers (adults and children). If you need to book for more")]
        public string GroupBookingsTooltipBodyText { get; set; }

        [DefaultValue("call: +971 4 2311000")]
        public string GroupBookingsTooltipTelephoneText { get; set; }

        [DefaultValue("or email: {0}")]
        [DisplayName("Group Bookings Tooltip Email Text (use {0} for the email address) (e.g. or email: {0})")]
        public string GroupBookingsTooltipEmailText { get; set; }

        [DefaultValue("letstalk@flydubai.com")]
        public string GroupBookingsTooltipEmailAddress { get; set; }

        [DefaultValue("Promotional code")]
        public string PromoCodeAccessibilityText { get; set; }

        [DefaultValue("Promotional code:")]
        public string PromoCodeLabelText { get; set; }

        [DefaultValue("Promotional code")]
        public string PromoCodePlaceholderText { get; set; }

        [DefaultValue("Promotional code")]
        public string PromoCodeTooltipHeadingText { get; set; }

        [DefaultValue("You may have a 5-character promotional code from one of our special offers. This will give you a discount on some flydubai flights.")]
        public string PromoCodeTooltipBodyText { get; set; }

        [DefaultValue("Submit details")]
        public string SubmitDetailsAccessibilityText { get; set; }

        [DefaultValue("Show flights")]
        public string ShowFlightsButton { get; set; }

        [DefaultValue("For information on special needs, unaccompanied children, pets and our flights policy {0}")]
        [DisplayName("See Faqs Text (use {0} for the link text) (e.g. For information on special needs, unaccompanied children, pets and our flights policy {0})")]
        public string SeeFaqsText { get; set; }

        [DefaultValue("see FAQs")]
        public string SeeFaqsLinkText { get; set; }

        [DefaultValue("/en/contact-us/faqs/")]
        public string SeeFaqsLinkUrl { get; set; }

        [DefaultValue("Multi-City")]
        public string MultiCity { get; set; }
    }
}
