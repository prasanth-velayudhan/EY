using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Payment Labels
    /// </summary>
    public class MobilePaymentLabels : BaseLabels
    {
        public string Payment { get; set; }

        public string DoNotAcceptCardsFromCountries { get; set; }
        public string PayNow { get; set; }
        [DisplayName("Pay now bulleted text 1")]
        public string OnlyTakesAMinute { get; set; }
        [DisplayName("Pay now bulleted text 2")]
        public string SafeAndSecure { get; set; }
        [DisplayName("Pay now bulleted text 3")]
        public string GuaranteeYourFlight { get; set; }

        public string PayLater { get; set; }
        [DisplayName("Pay later bulleted text 1")]
        public string SomeElseCanPay { get; set; }
        [DisplayName("Pay later bulleted text 2")]
        public string EasyAndStraightforward { get; set; }
        [DisplayName("Pay later bulleted text 3")]
        public string ReservesTicket { get; set; }

        public string Includes { get; set; }
        public string HandBaggage { get; set; }
        public string CheckedBaggage { get; set; }
        public string Seats { get; set; }

        public string Insurance { get; set; }
        public string AllPassengersOnAllJourneys { get; set; }

        public string HaveAVoucher { get; set; }
        public string VoucherRef { get; set; }
        public string VoucherPin { get; set; }
        public string UseVoucher { get; set; }

        public string PaymentDetails { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string FirstNameOnCard { get; set; }
        public string LastNameOnCard { get; set; }
        public string ExpiryDate { get; set; }
        public string CVVNumber { get; set; }
        public string Last3Numbers { get; set; }

        public string TotalDueForthisBooking { get; set; }
        public string Voucher { get; set; }
        public string Value { get; set; }
        public string BalanceRemaining { get; set; }
        public string TheVoucherWillbeAppliedOnlyWhen { get; set; }

        public string IHaveReadTerms { get; set; }
        public string TermsAndConditions { get; set; }
        public string TermsAndConditionsLinkUrl { get; set; }
        public string BookFlight { get; set; }

        public string IfYouPayByCcCopy { get; set; }

        public string PayLaterCopy { get; set; }
        public string YourBookingWillBeCancelled { get; set; }
        public string YourBookingWillBeCancelled72 { get; set; }


        public string BackToTop { get; set; }

        public string OnVoucher { get; set; }
        public string HowWouldYouLikeToPayOutstandingBalance { get; set; }
        public string ExpiryDateYear { get; set; }
        public string BillingAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CityTown { get; set; }
        public string StateUsAndCanadaOnly { get; set; }
        public string ZipCodeUsAndCanadaOnly { get; set; }
        public string Country { get; set; }
        public string IfACreditCardIsUsedToPayOnBehalfCopy { get; set; }

        public string TotalAmountToBeChargedToYourCreditCard { get; set; }

        public string Pay { get; set; }

        public string IncludingCreditCardFeeOf { get; set; }

        public string BillingCountryDefaultText { get; set; }

        public string CardTypeDefaultText { get; set; }

        public string BillingStateDefaultText { get; set; }

        public string Hour { get; set; }
        public string Minute { get; set; }
        public string Minutes { get; set; }
        public string And { get; set; }

        //WR6 Refresh Alert mobile
        public string MobileRefreshAlert { get; set; }
        public string BookingReferencePNR { get; set; }
        public string CardVerification { get; set; }
        public string ProcessingYourPayment { get; set; }
        public string CookiesDisabledTitle { get; set; }
        public string CookiesDisabledMessage { get; set; }
        public string CookiesDisabledGoToBankButton { get; set; }
        public string CookiesDisabledCancelButton { get; set; }
        public string PleaseWaitWhilstWeConfirmYourBooking { get; set; }
        public string ThisWillOnlyTakeAFewMoments { get; set; }

        public string PaymentSlower { get; set; }
        //public string PaymentSlowerRetryOnly { get; set; }

        //public string Retry { get; set; }
        public string TNSPaymentFailureMessageOnPaynow { get; set; }

        public string TnsGenericMessage { get; set; }
        public string TnsBankDeclinedMessage { get; set; }
        public string TnsPartiallyProcessedMessage { get; set; }
        public string TnsTimeoutMessage { get; set; }
        public string TnsWrongInputMessage { get; set; }
        public string TnsWrongInputMessageCSC { get; set; }
        public string Mpesa { get; set; }
        public string MpesaHeader { get; set; }
        public string MpesaStep1 { get; set; }
        public string MpesaStep2 { get; set; }
        public string MpesaStep3 { get; set; }
        public string MpesaStep4 { get; set; }
        public string MpesaStep5 { get; set; }
        public string DiscountAppliedMessage { get; set; }

        //OTP changes
        public string OTPvalidationfailed { get; set; }
        public string OtpInfoMessage { get; set; }
        public string OtpHeading { get; set; }
        public string OtpMessage { get; set; }
        public string OtpAmountTxt { get; set; }
        public string OtpEnterOtpTxt { get; set; }
        public string OtpSubmitButtonTxt { get; set; }
        public string OtpHelpInfoMessage { get; set; }
        public string OtpPopUpHeader { get; set; }
        public string OtpPopUpSubmitButtonText { get; set; }
        public string OtpPopUpCancelButtonText { get; set; }
        
    }
}
