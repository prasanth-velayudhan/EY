using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Account Labels
    /// </summary>
    public class AccountLabels : BaseLabels
    {
        [DefaultValue("Login to your account")]
        public string LoginModuleTitle { get; set; }

        [DefaultValue("Email address")]
        public string LoginEmailAddress { get; set; }

        [DefaultValue("Staff ID")]
        public string LoginStaffId { get; set; }

        [DefaultValue("Password")]
        public string LoginPassword { get; set; }

        [DefaultValue("If you have not been issued with any login details, please contact {0}")]
        [DisplayName("Login Staff Message (use the {0} placeholder for the contact email)")]
        public string LoginStaffMessage { get; set; }

        [DefaultValue("stafftravel@flydubai.com")]
        [DisplayName("Login Staff Email (the contact email for staff users)")]
        public string LoginStaffEmail { get; set; }

        [DefaultValue("Forgot password?")]
        public string LoginForgotPassword { get; set; }

        [DefaultValue("Login")]
        public string LoginButton { get; set; }

        [DefaultValue("Your email address or password is incorrect.")]
        public string LoginInvalid { get; set; }

        [DefaultValue("Create an account with flydubai")]
        public string CreateAccountModuleTitle { get; set; }

        [DefaultValue("flydubai lets you change or cancel your booking.")]
        public string CreateAccountMessage { get; set; }

        [DefaultValue("View more")]
        public string CreateAccountViewMore { get; set; }

        [DefaultValue("View less")]
        public string CreateAccountViewLess { get; set; }

        [DefaultValue("About you")]
        public string CreateAccountAboutYouTitle { get; set; }

        [DefaultValue("Title")]
        public string CreateAccountTitle { get; set; }

        [DefaultValue("First name")]
        public string CreateAccountFirstName { get; set; }

        [DefaultValue("Middle name")]
        public string CreateAccountMiddleName { get; set; }

        [DefaultValue("Last name")]
        public string CreateAccountLastName { get; set; }

        [DefaultValue("Date of birth")]
        public string CreateAccountDateOfBirth { get; set; }

        [DefaultValue("Day")]
        public string CreateAccountDay { get; set; }

        [DefaultValue("Month")]
        public string CreateAccountMonth { get; set; }

        [DefaultValue("Year")]
        public string CreateAccountYear { get; set; }

        [DefaultValue("Nationality")]
        public string CreateAccountNationality { get; set; }

        [DefaultValue("Login name and password")]
        public string CreateAccountLoginNameAndPassword { get; set; }

        [DefaultValue("Email address")]
        public string CreateAccountEmail { get; set; }

        [DefaultValue("This email address is already in use.")]
        public string CreateAccountEmailAlreadyInUse { get; set; }

        [DefaultValue("Password")]
        public string CreateAccountPassword { get; set; }

        [DefaultValue("Confirm password")]
        public string CreateAccountConfirmPassword { get; set; }

        [DefaultValue("Contact details")]
        public string CreateAccountContactDetails { get; set; }

        [DefaultValue("Why are we asking for these numbers?")]
        public string CreateAccountWhyAreWeAskingForTheseNumbers { get; set; }

        [DefaultValue("Country code")]
        public string CreateAccountCountryCode { get; set; }

        [DefaultValue("Area code")]
        public string CreateAccountAreaCode { get; set; }

        [DefaultValue("Number")]
        public string CreateAccountNumber { get; set; }

        [DefaultValue("Country code for other phone")]
        public string CreateAccountOtherPhoneCountryCode { get; set; }

        [DefaultValue("Home number")]
        public string CreateAccountHomeNumber { get; set; }

        [DefaultValue("Mobile number")]
        public string CreateAccountMobileNumber { get; set; }

        [DefaultValue("Preferred contact number")]
        public string CreateAccountPreferredContactNumber { get; set; }

        [DefaultValue("Same as")]
        public string CreateAccountPreferredContactNumberSameAs { get; set; }

        [DefaultValue("Mobile")]
        public string CreateAccountMobile { get; set; }

        [DefaultValue("Home")]
        public string CreateAccountHome { get; set; }

        [DefaultValue("Other")]
        public string CreateAccountOther { get; set; }

        [DefaultValue("Subscriptions to flydubai offers")]
        public string CreateAccountSubscriptions { get; set; }

        [DefaultValue("Subscribe me to flydubai offers")]
        public string CreateAccountSubscribeMe { get; set; }

        [DefaultValue("via SMS")]
        public string CreateAccountSubscribeSms { get; set; }

        [DefaultValue("via Email")]
        public string CreateAccountSubscribeEmail { get; set; }

        [DefaultValue("I want to receive offers in")]
        public string CreateAccountReceiveOffersIn { get; set; }

        [DefaultValue("Offers from")]
        public string CreateAccountReceiveOffersFrom { get; set; }

        [DefaultValue("All countries")]
        public string CreateAccountAllCountries { get; set; }

        [DefaultValue("Country 2")]
        public string CreateAccountCountry2 { get; set; }

        [DefaultValue("Country 3")]
        public string CreateAccountCountry3 { get; set; }

        [DefaultValue("I would be happy for flydubai to pass my details on to flydubai's partners")]
        public string CreateAccountPartners { get; set; }

        [DefaultValue("Create account")]
        public string CreateAccountButton { get; set; }

        [DefaultValue("Login to your account")]
        public string ForgottenPasswordModuleTitle { get; set; }

        [DefaultValue("Enter your email address below. Click the “Continue” button and we will send you a new password.")]
        public string ForgottenPasswordMessage { get; set; }

        [DefaultValue("Email address")]
        public string ForgottenPasswordEmail { get; set; }

        [DefaultValue("Staff ID")]
        public string ForgottenPasswordStaffId { get; set; }

        [DefaultValue("Contiune")]
        public string ForgottenPasswordContinue { get; set; }

        [DefaultValue("We have sent a new password to you.")]
        public string ForgottenPasswordConfirmationText { get; set; }

        [DefaultValue("Your account")]
        public string MenuTitle { get; set; }

        [DefaultValue("Account home")]
        public string MenuAccountHome { get; set; }

        [DefaultValue("Make a booking")]
        public string MenuMakeBooking { get; set; }

        [DefaultValue("Your details")]
        public string MenuYourDetails { get; set; }

        [DefaultValue("My vouchers")]
        public string MenuMyVouchers { get; set; }

        [DefaultValue("Booking history")]
        public string MenuBookingHistory { get; set; }

        [DefaultValue("Staff offers")]
        public string MenuStaffOffers { get; set; }

        [DefaultValue("Your details")]
        public string YourDetailsModuleTitle { get; set; }

        [DefaultValue("Your details have been updated")]
        public string YourDetailsConfirmationMessage { get; set; }

        [DefaultValue("For name changes, please contact flydubai on XXXXXXXXX")]
        public string YourDetailsUserNameChanges { get; set; }

        [DefaultValue("For name changes, please contact {0}")]
        [DisplayName("Staff Name Changes Message (use the {0} placeholder for the contact email)")]
        public string YourDetailsStaffNameChanges { get; set; }

        [DefaultValue("stafftravel@flydubai.com")]
        [DisplayName("Staff Name Changes Email")]
        public string YourDetailsStaffNameChangesEmail { get; set; }

        [DefaultValue("Cancel changes")]
        public string YourDetailsCancelChanges { get; set; }

        [DefaultValue("Save changes")]
        public string YourDetailsSaveChanges { get; set; }

        [DefaultValue("Current password")]
        public string YourDetailsCurrentPassword { get; set; }

        [DefaultValue("New password")]
        public string YourDetailsNewPassword { get; set; }

        [DefaultValue("Confirm new password")]
        public string YourDetailsConfirmNewPassword { get; set; }

        [DefaultValue("Change")]
        public string YourDetailsChangePassword { get; set; }

        [DefaultValue("Current password incorrect")]
        public string YourDetailsCurrentPasswordInvalid { get; set; }

        [DefaultValue("Welcome back")]
        public string AccountHomeWelcomeBack { get; set; }

        [DefaultValue("Payment outstanding")]
        public string BookingStatusPaymentOutstanding { get; set; }

        [DefaultValue("Confirmed")]
        public string BookingStatusConfirmed { get; set; }

        [DefaultValue("Journey completed")]
        public string BookingStatusJourneyCompleted { get; set; }

        [DefaultValue("Expired / cancelled")]
        public string BookingStatusExpiredCancelled { get; set; }

        [DefaultValue("Operational updates that affect your flights")]
        public string OperationalUpdatesTitle { get; set; }

        [DisplayName("Operational Updates Read More Link Text (only used on profile homepage)")]
        public string OperationalUpdatesReadMoreLinkText { get; set; }

        [DisplayName("Operational Updates Read More Link URL (absolute URL required) (only used on profile homepage)")]
        public string OperationalUpdatesReadMoreLinkUrl { get; set; }

        [DefaultValue("Offers")]
        public string PromotionalTeaserTitle { get; set; }

        [DefaultValue("Book now")]
        public string PromotionalTeaserBookNow { get; set; }

        [DefaultValue("Offers specific to you, {0}")]
        [DisplayName("Special offer module title (use {0} for the user's name) (e.g. Offers specific to you, {0})")]
        public string SpecialOffersTitle { get; set; }

        [DefaultValue("Promo code")]
        public string SpecialOffersPromoCode { get; set; }

        [DefaultValue("Terms and conditions apply")]
        public string SpecialOffersTermsAndConditionsApply { get; set; }

        [DefaultValue("Use this code")]
        public string SpecialOffersUseThisCode { get; set; }

        [DefaultValue("Book")]
        public string SpecialOffersBook { get; set; }

        [DefaultValue("Terms and conditions")]
        public string SpecialOffersTermsAndConditionsHeading { get; set; }

        [DefaultValue("Free")]
        public string SpecialOffersFree { get; set; }

        public string Welcome { get; set; }

        public string LogOff { get; set; }

        public string LogOn { get; set; }

        public string Change { get; set; }

        [DefaultValue("Telephone Numbers")]
        public string CreateAccountWhyAreWeAskingForTheseNumbersTooltipTitle { get; set; }

        [DefaultValue("We ask for this number so we can let you know if there are any changes or delays to your flight.")]
        public string CreateAccountWhyAreWeAskingForTheseNumbersTooltipBody { get; set; }

        [DefaultValue("Note: If you have previously signed up to receive special offers via the sign up form, leave these details blank if you would like to edit your current preferences after you log in.")]
        public string WarningTextForExistingSpecialOffersSubscribers { get; set; }

        [DefaultValue("This account does not exist, please register to create an account.")]
        public string AccountDoesNotExist { get; set; }

        //FFP Changes
        public string FrequentFlyerID { get; set; }
        public string RewardsLink { get; set; }
        public string ProfileLink { get; set; }
        public string BookingsLink { get; set; }
        public string VouchersLink { get; set; }
        public string PointsLink { get; set; }
        public string AboutFrequentFlyer { get; set; }
        public string Invalidcredentials { get; set; }
        public string RememberMe { get; set; }
    }
}
