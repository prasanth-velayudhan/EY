namespace flydubai.Model.Content
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Contact Form
    /// </summary>
    public class ContactForm
    {
        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Country { get; set; }

        public string HomeNumber { get; set; }

        public string MobileNumber { get; set; }

        public string BookingReference { get; set; }

        public ContactSubjectVersion Subject { get; set; }

        public string Message { get; set; }

        public bool SendCopy { get; set; }

        /// START A-5484 : WR-13 - Add additional dynamic field in the contact us form        
        public string City { get; set; }

        public string Address { get; set; }
        /// END A-5484 : WR-13 - Add additional dynamic field in the contact us form
    }
}
