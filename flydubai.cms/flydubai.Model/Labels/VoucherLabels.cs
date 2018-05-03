using System.ComponentModel;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Voucher Labels
    /// </summary>
    public class VoucherLabels : BaseLabels
    {
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

        public string TheStateAndZipCodeAreMandatoryForCanadaUSA { get; set; }

        public string InvalidCardNumber { get; set; }

        public string PleaseWaitWhilstWeConfirmYourBooking { get; set; }

        public string ThisWillOnlyTakeAFewMoments { get; set; }

        public string PleaseWaitWhilstWeConnectToThePaymentGateway { get; set; }

        public string PayLaterBenefitOne { get; set; }

        public string PayLaterBenefitTwo { get; set; }
        
        public string PayLaterBenefitThree { get; set; }

        public string ChoosingPayLaterRequiresPayingWithin { get; set; }

        public string HoursAtPaymentPoint { get; set; }

        public string YourBookingWillBeCancelledIfNotPaidWithin { get; set; }

        public string Hours { get; set; }

        [DefaultValue("My vouchers")]
        public string MyVouchersModuleTitle { get; set; }

        [DefaultValue("Viewing {0}-{1} of {2} results")]
        [DisplayName("Pagination text (use {0} for start of current page, {1} for end of current page, {2} for total results) (e.g. Viewing {0}-{1} of {2} results)")]
        public string MyVouchersPaginationText { get; set; }

        [DefaultValue("Next")]
        public string MyVouchersPaginationNext { get; set; }

        [DefaultValue("Previous")]
        public string MyVouchersPaginationPrevious { get; set; }

        [DefaultValue("Sort by")]
        public string MyVouchersSortBy { get; set; }

        [DefaultValue("Voucher ref.")]
        public string MyVouchersReference { get; set; }

        [DefaultValue("Issued to")]
        public string MyVouchersIssuedTo { get; set; }

        [DefaultValue("Description")]
        public string MyVouchersDescription { get; set; }

        [DefaultValue("Expiry date")]
        public string MyVouchersExpiryDate { get; set; }

        [DefaultValue("Voucher amount")]
        public string MyVouchersVoucherAmount { get; set; }

        [DefaultValue("Email my voucher")]
        public string MyVouchersEmailMyVoucher { get; set; }

        [DefaultValue("Vouchers are not transferrable.")]
        public string MyVouchersNotTransferrableText { get; set; }

        [DefaultValue("No vouchers")]
        public string MyVouchersNoVouchers { get; set; }

        [DefaultValue("Expiry date")]
        public string SortExpiryDate { get; set; }

        [DefaultValue("Currency")]
        public string SortCurrency { get; set; }

        public string BalanceOnYourVoucher { get; set; }

        public string YourVoucherHasBeenVerified { get; set; }

        public string UseThisVoucher { get; set; }

        public string TryAgain { get; set; }

        public string EnterTheSixCharacterCodeForYourVoucher { get; set; }

        public string Value { get; set; }

        public string YouStillNeedToPay { get; set; }

        [DefaultValue("Details of your voucher have been sent to your registered email address.")]
        public string EmailVoucherSuccessMessage { get; set; }

        [DefaultValue("There was a problem sending your voucher. Please try again later.")]
        public string EmailVoucherErrorMessage { get; set; }

        [DefaultValue("Sorry , there is no usable amount in this voucher,try another one.")]
        public string NoUsableAmount { get; set; }

        [DefaultValue("Total usable amount in this voucher is {currency} {amount}")]
        public string TotalUsableAmount { get; set; }
    }
}
