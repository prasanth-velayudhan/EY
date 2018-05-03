namespace flydubai.Model.Labels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Error Labels
    /// </summary>
    public class ErrorLabels : BaseLabels
    {
        [DefaultValue("Payment Failure")]
        public string PaymentFailure { get; set; }

        [DefaultValue("Session Expired")]
        public string SessionExpired { get; set; }

        [DefaultValue("Go to home page")]
        public string GoToHomePage { get; set; }

        public string ThePageYouAreLookingForCouldNotBeFound { get; set; }

        [DefaultValue("Return to manage booking page")]
        public string ReturnToViewBookingLinkText { get; set; }

        [DefaultValue("Sorry, something went wrong while creating your booking.  Please start this booking again or contact the call centre for assistance.")]
        public string MessageForUnrecoverableErrorDuringCreatePNR { get; set; }

        [DefaultValue("Sorry, something went wrong while modifying your booking.  Please try again later or contact the call centre for assistance.")]
        public string MessageForUnrecoverableErrorDuringModifyPNR { get; set; }
    }
}
