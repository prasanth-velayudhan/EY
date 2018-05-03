using System.ComponentModel;

namespace flydubai.Model.Labels
{
    using System.ComponentModel;

    /// <summary>
    /// Payment Labels
    /// </summary>
    public class PaymentLabels : BaseLabels
    {
        public string PleaseCheckDetailsAreCorrect { get; set; }

        public string SorryHavingTroubleProcessingYourPayment { get; set; }

        public string DontWorryTryAgainOrPayLater { get; set; }

        public string UnfortunaltelySeatsYouSelectedNoLongerAvailable { get; set; }

        public string YouCanEitherContinueReducedCostOf { get; set; }

        public string YourFlightWithoutSeatReservationsOr { get; set; }

        public string SelectAlternativeSeats { get; set; }

        public string PayNow { get; set; }

        public string PayLater { get; set; }

        public string PayNowBenefitOne { get; set; }

        public string PayNowBenefitTwo { get; set; }

        public string PayNowBenefitThree { get; set; }

        public string PaymentDetails { get; set; }

        public string FieldsMarked { get; set; }

        public string AreMandatory { get; set; }

        public string PaymentMethod { get; set; }

        public string DebitCardCreditCard { get; set; }

        public string Voucher { get; set; }

        public string AvailableCredit { get; set; }

        public string IsTheCardVoucherHolderTravelling { get; set; }

        public string IfYouPayWithCreditCardFlyDubaiWillAskToSeeIt { get; set; }

        public string IfYouPayWithCreditCardFlyDubaiWillAskToSeeItNoSelected { get; set; }

        public string IfYouPayWithCreditCardFlyDubaiWillAskToSeeItNoSelectedTA { get; set; }

        public string IfYouPayWithCreditCardFlyDubaiWillAskToSeeItTA { get; set; }

        public string Yes { get; set; }

        public string No { get; set; }

        public string BillingCountry { get; set; }

        public string CountryOfBillingAddress { get; set; }

        public string CardType { get; set; }

        public string CardNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ExpiryDate { get; set; }

        public string CvvNumber { get; set; }

        public string BillingAddress { get; set; }

        public string PleaseEnterYourBillingAddress { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostCode { get; set; }

        public string MandatoryForCardsIssuedInUsa { get; set; }

        public string MandatoryForCardsIssuedOnCanadaOrUsa { get; set; }

        public string TheNamedVoucherHolderMustBeAtravellerOnThisBooking { get; set; }

        public string EnterYourVoucherReferenceAndPin { get; set; }

        public string VoucherPayment { get; set; }

        public string EnterThe6CharacterCodeForYourVoucher { get; set; }

        public string VoucherReference { get; set; }

        public string VoucherPin { get; set; }

        public string VerifyVoucher { get; set; }

        public string TotalPaymentDue { get; set; }

        public string PleaseSelect { get; set; }

        public string SorryCardIsExpired { get; set; }

        public string TheZipCodeIsMandatory { get; set; }

        [DisplayName("The State Is Mandatory")]
        public string TheStateAndZipCodeAreMandatory { get; set; }

        [DisplayName("The State Is Mandatory")]
        public string TheCanadianStateAreMandatory { get; set; }

        public string InvalidCardNumber { get; set; }

        public string PleaseWaitWhilstWeConfirmYourBooking { get; set; }

        public string ThisWillOnlyTakeAFewMoments { get; set; }

        public string PleaseWaitWhilstWeConnectToThePaymentGateway { get; set; }

        public string PayLaterBenefitOne { get; set; }

        public string PayLaterBenefitTwo { get; set; }

        public string PayLaterBenefitThree { get; set; }

        [DisplayName("Pay Later Instructions Text For Paying Later At A Payment Point - must include a {0} placeholder for remaining time left to pay")]
        [DefaultValue("If you choose Pay later, you’ll need to pay for your flight(s) at a payment point within {0}.")]
        public string PayLaterInstructionsForPayingAtPaymentPointText { get; set; }

        public string Hours { get; set; }

        public string CvvNumberTooltip { get; set; }

        public string Hour { get; set; }

        public string Minute { get; set; }

        public string Minutes { get; set; }

        public string And { get; set; }

        public string CardVerification { get; set; }

        public string Loading { get; set; }

        public string UnfortunatelyOneOrMoreSeatsIsNoLongerAvailable { get; set; }

        public string YourFlightMustBePaidForNow { get; set; }

        public string MigsPaymentTimeout { get; set; }

        public string RedirectionMessage { get; set; }

        public string MigsTimeoutDescription { get; set; }

        public string BillingCountryDropDownListSelectText { get; set; }

        public string CardTypeDropDownSelectText { get; set; }

        public string ScrollDownToAcceptTermsConditionsAndProceed { get; set; }

        public string PayNowTabConsumer { get; set; }

        public string PayLaterTabConsumer { get; set; }

        public string PayNowTabTA { get; set; }

        public string PayLaterTabTA { get; set; }

        public string PayNowTabMobile { get; set; }

        public string PayLaterTabMobile { get; set; }

        public string PCILogo { get; set; }

        public string OR { get; set; }

        public string PayLaterButtonText { get; set; }

        // A-5446 Web release 2 FR-024
        public string TAToViewPaymentDetails { get; set; }
        public string TAClickHere { get; set; }
        public string TAPaymentDetails { get; set; }
        public string TACostBreakdown { get; set; }
        public string TAInvoice { get; set; }
        public string TABalanceDue { get; set; }
        public string TAVoucherReference { get; set; }
        public string TACardNumber { get; set; }
        public string TACreditCardWillBeChecked { get; set; }
        public string TAAirfare { get; set; }
        public string TATax { get; set; }
        public string TAOptionalExtras { get; set; }
        public string TATravelInsurance { get; set; }
        public string TATransactionFee { get; set; }
        public string TAPenaltyFee { get; set; }
        public string TADebitCreditCardFee { get; set; }
        public string TATotal { get; set; }
        public string TACash { get; set; }
        public string TAElectronicTicketNumber { get; set; }
        public string TARefundedtotravelAgent { get; set; }
        public string TARefundedThroughVoucherTo { get; set; }
        public string TARefundedToCreditCard { get; set; }
        public string TARefundedtoWBSP { get; set; }

        //FR-016 FZWR-35 A-5851 Web Release 3  FZWR-724 :FZWR-725 Start 
        public string TAPayNowBenefitOne { get; set; }
        public string TAPayLaterBenefitOne { get; set; }
        public string TAPayNowBenefitTwo { get; set; }
        public string TAPayLaterBenefitTwo { get; set; }
        public string TAPayNowBenefitThree { get; set; }
        public string TAPayLaterBenefitThree { get; set; }
        //FR-016 FZWR-35 A-5851 Web Release 3  FZWR-724 : End

        //WR-5 FZWR 145 A-5453
        public string CookiesDisabledTitle { get; set; }
        public string CookiesDisabledMessage { get; set; }
        public string CookiesDisabledGoToBankButton { get; set; }
        public string CookiesDisabledCancelButton { get; set; }
        //WR-5 FZWR 145 A-5453

        //WR-6 FZWR-401 A-5453
        public string PaymentPageRefreshAlert { get; set; }
        public string PaymentPageFailureAlert { get; set; }
        //WR-6 FZWR-401 A-5453
        //OFEE Changes
        public string ToggleInterstitialLabel { get; set; }
        public string ToggleInterstitialLoadingLabel { get; set; }

        public string CcInitialWarningMessage { get; set; }
        public string CcReattemptWarningMessage { get; set; }

        public string ProcessingYourPayment { get; set; }

        public string PaymentSlower { get; set; }
        //public string PaymentSlowerRetryOnly { get; set; }
        //public string Retry { get; set; }
        public string TNSPaymentFailureMessageOnPaynow { get; set; }

        //public string TnsFailurePopupHeader { get; set; }
        //public string TnsFailurePopupContent { get; set; }
        //public string TnsFailurePopupTermsAndConditionHeader { get; set; }
        //public string TnsFailurePopupTermsAndCondition1 { get; set; }
        //public string TnsFailurePopupTermsAndCondition2 { get; set; }

        //public string TnsFailurePopupPaylaterContentHeader { get; set; }
        //public string TnsFailurePopupPaylaterContent1 { get; set; }
        //public string TnsFailurePopupPaylaterContent2 { get; set; }

        //public string TnsFailurePopupTotalPaymentLabel { get; set; }
        //public string TnsFailurePaylaterButton { get; set; }
        //public string TnsFailurePayTryAgainButton { get; set; }

        public string TnsGenericMessage { get; set; }
        public string TnsBankDeclinedMessage { get; set; }
        public string TnsPartiallyProcessedMessage { get; set; }
        public string TnsTimeoutMessage { get; set; }
        public string TnsWrongInputMessage { get; set; }
        public string TnsWrongInputMessageCSC { get; set; }

        //FFP Changes
        public string Points { get; set; }
        public string PaybyPoints { get; set; }
        public string MaxPoints { get; set; }
        public string RadeemPoints { get; set; }
        public string MaxPointsExeeds { get; set; }
        public string UsePoints { get; set; }
        public string PointsPayment { get; set; }
        public string PointsRedeemed { get; set; }
        public string AmountPaid { get; set; }
        public string StillNeedtoPay { get; set; }

        public string DiscountAppliedMessage { get; set; }

        //interline changes
        public string PleaseWaitWhilstWeConfirmYourInterlineBooking { get; set; }
        public string InterlineBookingPaymentTimeout { get; set; }

        public string Bsp { get; set; }
        public string BspDisabledMessage { get; set; }
        public string WbspFee { get; set; }
        public string BSPClickMessage { get; set; }

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
