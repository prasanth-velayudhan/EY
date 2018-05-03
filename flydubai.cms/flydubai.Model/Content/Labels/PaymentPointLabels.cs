using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Payment Point Labels
    /// </summary>
    [DisplayName("Payment Point Labels")]
    public class PaymentPointLabels : LabelsBase
    {
        [Key]
        public int PaymentPointLabelsId { get; set; }

        [DefaultValue("Find your nearest payment points")]
        [DisplayName("Heading text")]
        public string HeadingText { get; set; }
        
        [DefaultValue("Please enter you country and city to see your nearest payment point:")]
        [DisplayName("Search Instructions text")]
        public string SearchInstructions { get; set; }

        [DefaultValue("Country")]
        [DisplayName("Country Label")]
        public string CountryLabel { get; set; }

        [DefaultValue("City/Town")]
        [DisplayName("City/Town Label")]
        public string CityLabel { get; set; }

        [DefaultValue("Partner Type")]
        [DisplayName("Partner Type Text")]
        public string PartnerType { get; set; }

        [DefaultValue("Locate")]
        [DisplayName("Locate Button Text")]
        public string LocateButtonText { get; set; }

        [DefaultValue("Print Map")]
        [DisplayName("Print Map Button Text")]
        public string PrintMapButtonText { get; set; }

        [DefaultValue("Email Map")]
        [DisplayName("Email Map Button Text")]
        public string EmailMapButtonText { get; set; }

        [DefaultValue("Results found: {0}")]
        [DisplayName("Results found format. Example: Results found: {0}")]
        public string ResultsFoundFormat { get; set; }

        [DefaultValue("Please Select")]
        [DisplayName("Blank Dropdown List Option Text")]
        public string BlankDropDownOptionText { get; set; }

        [DefaultValue("No Payment Points could be located.")]
        [DisplayName("No Results Text")]
        public string NoResults { get; set; }

        [DefaultValue("Payment point locator")]
        [DisplayName("Payment Point Locator Heading")]
        public string PaymentPointLocatorHeading { get; set; }

        [DefaultValue("Select your country and city to see your nearest payment point.")]
        [DisplayName("Payment Point Locator Instructions")]
        public string PaymentPointLocatorInstructions { get; set; }

        [DefaultValue("Email Address")]
        [DisplayName("Email Address")]
        public string EmailPaymentPointsLegend { get; set; }

        [DefaultValue("Send")]
        [DisplayName("Send")]
        public string EmailPaymentPointsSendButton { get; set; }

        [DefaultValue("Cancel")]
        [DisplayName("Cancel")]
        public string EmailPaymentPointsCancelButton { get; set; }

        [DefaultValue("Email has failed")]
        [DisplayName("Email has failed")]
        public static string PaymentPointsEmailFailError { get; set; }

        [DefaultValue("A valid email address needs to be entered")]
        [DisplayName("A valid email address needs to be entered")]
        public static string PaymentPointsValidEmailError { get; set; }

        [DefaultValue("Success")]
        [DisplayName("Payment points email success label.")]
        public string PaymentPointsEmailSuccess { get; set; }

        [DefaultValue("Payment points map")]
        [DisplayName("Payment points email subject label.")]
        public string PaymentPointsEmailSubject { get; set; }
    }
}
