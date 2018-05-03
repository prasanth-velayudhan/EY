using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Sign Up Labels
    /// </summary>
    [DisplayName("Special offers sign up labels")]
    public class SignUpLabels : LabelsBase
    {
        [Key]
        public int SignUpLabelsId { get; set; }

        [DefaultValue("Confirmation")]
        [DisplayName("Header: Confirmation")]
        public string ConfrimationHeader { get; set; }

        [DefaultValue("Receive Special Offers")]
        [DisplayName("Header: Default header when no confirmation is displayed.")]
        public string DefaultHeader { get; set; }

        [DefaultValue("Your details")]
        [DisplayName("Contact details header")]
        public string YourDetailsHeader { get; set; }

        [DefaultValue("Title")]
        [DisplayName("Contact title label")]
        public string ContactTitle { get; set; }

        [DefaultValue("Mr, Ms, Mrs, Miss")]
        [DisplayName("Allowed contact title values (must be a comma separated list - for example: Mr, Ms, Mrs, Miss)")]
        public string AllowedContactTitles { get; set; }

        [DefaultValue("Select")]
        [DisplayName("Contact title default option")]
        public string DefaultTitleOption { get; set; }

        [DefaultValue("First name")]
        [DisplayName("Contact first name label")]
        public string ContactFirstName { get; set; }

        [DefaultValue("Last name")]
        [DisplayName("Contact last name label")]
        public string ContactLastName { get; set; }

        [DefaultValue("Email")]
        [DisplayName("Contact email label")]
        public string ContactEmail { get; set; }

        [DefaultValue("Country")]
        [DisplayName("Contact country label")]
        public string ContactCountry { get; set; }

        [DefaultValue("Your preferences")]
        [DisplayName("Preferences header")]
        public string YouPreferencesHeader { get; set; }

        [DefaultValue("Please subscribe me to flydubai offers:")]
        [DisplayName("Preferences introduction text")]
        public string PreferencesIntroductionText { get; set; }

        [DefaultValue("Preferred Language")]
        [DisplayName("Preferred language label")]
        public string PreferredLanguageLabel { get; set; }

        [DefaultValue("English")]
        [DisplayName("Preferred language - English label")]
        public string PreferredLanguageEnglish { get; set; }

        [DefaultValue("Arabic")]
        [DisplayName("Preferred language - Arabic label")]
        public string PreferredLanguageArabic { get; set; }

        [DefaultValue("Receive offers from all destinations")]
        [DisplayName("Preference label - All destinations label")]
        public string ReceiveOffersFromAllDestinations { get; set; }

        [DefaultValue("OR receive offers for the following destinations")]
        [DisplayName("Preference label: Pick destinations label")]
        public string ReceiveOffersFromFollowingDestinations { get; set; }

        [DefaultValue("Select up to 3 specific destinations")]
        [DisplayName("Preference label: Pick destinations instructions")]
        public string PickDestinationInstructions { get; set; }

        [DefaultValue("Select destination")]
        [DisplayName("Preference label: Default destination option")]
        public string DefaultDestinationOption { get; set; }

        [DefaultValue("Sign up for flydubai Special Offers")]
        [DisplayName("Preference label: Sign up to special offers")]
        public string SignUpToSpecialOffers { get; set; }

        [DefaultValue("Receive updates on the latest flydubai promotions for your country and preferred departure airport.")]
        [DisplayName("Preference label: Sign up to special offers summary text")]
        public string SignUpToSpecialOffersSummary { get; set; }

        [DefaultValue("Sign up for flydubai Monthly Newsletters and Announcements")]
        [DisplayName("Preference label: Sign up to monthly news and announcements")]
        public string SignUpToMonthlyNews { get; set; }

        [DefaultValue("All the latest news about new routes, service and products. Important announcements such as service or product changes are also included.")]
        [DisplayName("Preference label: Sign up to monthly news and announcements summary text")]
        public string SignUpToMonthlyNewsSummary { get; set; }

        [DefaultValue("Sign up for flydubai Partner Promotions")]
        [DisplayName("Preference label: Sign up to partner promotions")]
        public string SignUpToPartnerPromotions { get; set; }

        [DefaultValue("flydubai will never share your details without your consent. Select this option if you would like to receive special offers from our approved partners.")]
        [DisplayName("Preference label: Sign up to partner promotions summary text")]
        public string SignUpToPartnerPromotionsSummary { get; set; }

        [DefaultValue("Skip")]
        [DisplayName("Skip button text")]
        public string SkipButton { get; set; }

        [DefaultValue("Sumbit")]
        [DisplayName("Submit button text")]
        public string SubmitButton { get; set; }

        [DefaultValue("Sign up to receive our Newsletter and be one of the first to receive special offers from flydubai. Just enter your email address below, then click submit.")]
        [DisplayName("Small sign up module summary text")]
        public string SmallModuleSummaryText { get; set; }

        [DefaultValue("example@domain.com")]
        [DisplayName("Email example text")]
        public string EmailExample { get; set; }

        [DefaultValue("Sign Up")]
        [DisplayName("Newsletter signup button")]
        public string NewsletterSignupButton { get; set; }

        [DefaultValue("Receive our newsletter")]
        [DisplayName("Newsletter signup small header text")]
        public string NewsletterSignupHeader { get; set; }
    }
}
