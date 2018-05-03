namespace flydubai.Model.Labels
{
    using System.ComponentModel;

    /// <summary>
    /// Booking Wizard Labels
    /// </summary>
    public class BookingWizardLabels : BaseLabels
    {
        [DisplayName("Select Your Flight")]
        [DefaultValue("Select Your Flight")]
        public string SelectYourFlight { get; set; }

        [DisplayName("Passenger Details")]
        [DefaultValue("Passenger Details")]
        public string PassengerDetails { get; set; }

        [DisplayName("Optional Extras")]
        [DefaultValue("Optional Extras")]
        public string OptionalExtras { get; set; }

        [DefaultValue("Payment")]
        public string Payment { get; set; }

        [DefaultValue("Confirmation")]
        public string Confirmation { get; set; }
    }
}
