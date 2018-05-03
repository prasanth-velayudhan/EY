using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Manage Booking Tab Labels
    /// </summary>
    [DisplayName("Manage Booking Tab Labels (shared between booking path and content website)")]
    public class ManageBookingTabLabels : BaseLabels, IManageBookingTabLabels
    {
        [DefaultValue("Your booking details")]
        public string YourBookingDetailsSectionText { get; set; }

        [DefaultValue("You can use this facility to change your travel dates, time or destination.")]
        public string YourBookingDetailsParagraph1Text { get; set; }

        [DefaultValue("Please note any changes made here will apply to all passengers.")]
        public string YourBookingDetailsParagraph2BoldText { get; set; }

        [DefaultValue("If you wish to change some of the passengers only please contact our helpdesk.")]
        public string YourBookingDetailsParagraph3Text { get; set; }

        [DefaultValue("Find and view a booking")]
        public string FindBookingAccessibilityText { get; set; }

        [DefaultValue("Booking Reference")]
        public string BookingReferenceLabelText { get; set; }

        [DefaultValue("Last name")]
        public string LastNameLabelText { get; set; }

        [DefaultValue("I confirm I'm authorized to make changes on behalf of all passengers")]
        public string ConfirmAuthorisedCheckbox { get; set; }

        [DefaultValue("View booking")]
        public string ViewBookingButton { get; set; }

        [DefaultValue("Already registered?")]
        public string AlreadyRegisteredSectionText { get; set; }

        [DefaultValue("To retrieve your flight information and manage your flights.")]
        public string AlreadyRegisteredParagraph1Text { get; set; }

        [DefaultValue("Login to registered account")]
        public string LogInToAccountAccessibilityText { get; set; }

        [DefaultValue("Email address")]
        public string EmailAddressLabelText { get; set; }

        [DefaultValue("Password")]
        public string PasswordLabelText { get; set; }

        [DefaultValue("Forgotten your login details?")]
        public string ForgottenDetailsLink { get; set; }

        [DefaultValue("Login to my account")]
        public string LoginToAccountButton { get; set; }

        [DefaultValue("Want to register?")]
        public string WantToRegisterSectionText { get; set; }

        [DefaultValue("If you are not currently registered to flydubai, then take this opportunity to do so now.")]
        public string WantToRegisterParagraph1Text { get; set; }

        [DefaultValue("Register here")]
        public string RegisterHereLink { get; set; }

        [DefaultValue("Enter your booking reference to view a specific booking or see below for a list of your active bookings")]
        public string LoggedInYourBookingDetailsParagraphText { get; set; }

        [DefaultValue("I confirm I'm authorized to make changes on behalf of all passengers")]
        public string LoggedInConfirmAuthorisedCheckbox { get; set; }

        [DefaultValue("Active bookings")]
        public string LoggedInActiveBookingsSectionTitle { get; set; }

        [DefaultValue("Showing up to your last 5 bookings")]
        public string LoggedInActiveBookingsParagraphText { get; set; }

        [DefaultValue("{0} to {1}")]
        [DisplayName("Logged In Active Booking Origin To Destination (use {0} for the origin, {1} for the destination) (e.g. {0} to {1})")]
        public string LoggedInActiveBookingOriginToDestination { get; set; }

        [DefaultValue("View all")]
        public string LoggedInActiveBookingsViewAllButton { get; set; }

        [DefaultValue("Your profile")]
        public string LoggedInYourProfileSectionTitle { get; set; }

        [DefaultValue("To view, amend or add to your existing details click on the link below")]
        public string LoggedInYourProfileParagraphText { get; set; }

        [DefaultValue("Manage your profile")]
        public string LoggedInYourProfileManageProfileButton { get; set; }

        //FFP Changes
        [DefaultValue("Frequent Flyer ID")]
        public string FrequentFlyerIDLabelText { get; set; }

        [DefaultValue("Remember me")]
        public string RememberMeText { get; set; }  
    }
}
