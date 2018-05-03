using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Interface of ManageBookingTabLabels
    /// </summary>
    public interface IManageBookingTabLabels
    {
        string YourBookingDetailsSectionText { get; set; }

        string YourBookingDetailsParagraph1Text { get; set; }

        string YourBookingDetailsParagraph2BoldText { get; set; }

        string YourBookingDetailsParagraph3Text { get; set; }

        string FindBookingAccessibilityText { get; set; }

        string BookingReferenceLabelText { get; set; }

        string LastNameLabelText { get; set; }

        string ConfirmAuthorisedCheckbox { get; set; }

        string ViewBookingButton { get; set; }

        string AlreadyRegisteredSectionText { get; set; }

        string AlreadyRegisteredParagraph1Text { get; set; }

        string LogInToAccountAccessibilityText { get; set; }

        string EmailAddressLabelText { get; set; }

        string PasswordLabelText { get; set; }

        string ForgottenDetailsLink { get; set; }

        string LoginToAccountButton { get; set; }

        string WantToRegisterSectionText { get; set; }

        string WantToRegisterParagraph1Text { get; set; }

        string RegisterHereLink { get; set; }

        string LoggedInYourBookingDetailsParagraphText { get; set; }

        string LoggedInConfirmAuthorisedCheckbox { get; set; }

        string LoggedInActiveBookingsSectionTitle { get; set; }

        string LoggedInActiveBookingsParagraphText { get; set; }

        string LoggedInActiveBookingOriginToDestination { get; set; }

        string LoggedInActiveBookingsViewAllButton { get; set; }

        string LoggedInYourProfileSectionTitle { get; set; }

        string LoggedInYourProfileParagraphText { get; set; }

        string LoggedInYourProfileManageProfileButton { get; set; }

        //FFP Changes
        string FrequentFlyerIDLabelText { get; set; }
        string RememberMeText { get; set; }       
    }
}
