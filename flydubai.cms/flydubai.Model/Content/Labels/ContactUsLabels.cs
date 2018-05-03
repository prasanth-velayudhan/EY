using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Contact Us Labels
    /// </summary>
    public class ContactUsLabels : LabelsBase
    {
        [Key]
        public int ContactUsLabelsId { get; set; }

        [DefaultValue("Your message")]
        public string ModuleTitle { get; set; }

        [DefaultValue("Fields marked {0} are mandatory")]
        [DisplayName("Message for mandatory fields (use {0} for asterisk) (e.g. Fields marked {0} are mandatory)")]
        public string MandatoryFields { get; set; }

        [DefaultValue("Title")]
        public string Title { get; set; }

        [DefaultValue("- Select -")]
        public string TitleSelect { get; set; }

        [DefaultValue("Mr,Ms,Miss,Mrs")]
        [DisplayName("Titles (separated by commas)")]
        public string Titles { get; set; }

        [DefaultValue("First name")]
        public string FirstName { get; set; }

        [DefaultValue("Middle name")]
        public string MiddleName { get; set; }

        [DefaultValue("Last name")]
        public string LastName { get; set; }

        [DefaultValue("Email")]
        public string Email { get; set; }

        [DefaultValue("Country")]
        public string Country { get; set; }

        [DefaultValue("Home number")]
        public string HomeNumber { get; set; }

        [DefaultValue("Mobile number")]
        public string MobileNumber { get; set; }

        [DefaultValue("Booking reference")]
        public string BookingReference { get; set; }

        [DefaultValue("- Choose a subject -")]
        public string Subject { get; set; }

        [DefaultValue("Comment / message")]
        public string Message { get; set; }

        [DefaultValue("Send a copy to my email address")]
        public string SendCopy { get; set; }

        [DefaultValue("Submit")]
        public string Submit { get; set; }

        [DisplayName("Small email us module: Header text")]
        [DefaultValue("Email Us")]
        public string SmallModuleHeadingText { get; set; }

        [DisplayName("Small email us module: FAQs link label (e.g. FAQs)")]
        [DefaultValue("FAQs")]
        public string SmallModuleFaqsLinkLabel { get; set; }

        [DisplayName("Small email us module: FAQs summary text (Important: use {0} for the faqs page hyperlink) (e.g. Click here to view the {0} page.)")]
        [DefaultValue("You'll find answers to our most frequently asked questions in our {0}.")]
        public string SmallModuleFaqsSummaryFormatString { get; set; }

        [DisplayName("Small email us module: Summary text")]
        [DefaultValue("However, if you're unable to find an answer to your question, you can contact us via our email form.")]
        public string SmallModuleSummaryText { get; set; }

        [DisplayName("Small email us module: Button text")]
        [DefaultValue("Email Us")]
        public string SmallModuleButtonText { get; set; }

        [DefaultValue("Your message has been successfully sent.")]
        public string SendMessageSuccess { get; set; }

        [DefaultValue("There was an error sending your message.")]
        public string SendMessageError { get; set; }

        [DefaultValue("Thank you")]
        public string SendMessageSuccessHeading { get; set; }

        [DefaultValue("There was an error")]
        public string SendMessageErrorHeading { get; set; }

        [DefaultValue("- Select country -")]
        public string CountryDropDownSelectText { get; set; }

        [DefaultValue("- Select country -")]
        public string HomeNumberCountryDropDownSelectText { get; set; }

        [DefaultValue("- Select country -")]
        public string MobileNumberCountryDropDownSelectText { get; set; }

        [DefaultValue("Subject")]
        public string SubjectLabel { get; set; }

        /// START A-5484 : WR-13 - Add additional dynamic field in the contact us form
        [DefaultValue("City")]
        public string City { get; set; }

        [DefaultValue("Address")]
        public string Address { get; set; }
        /// END A-5484 : WR-13 - Add additional dynamic field in the contact us form
    }
}
