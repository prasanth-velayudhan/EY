using System;

namespace Ey.Common
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using StructureMap;

    using Ey.Common.Contracts.Model;


    /// <summary>
    /// Exception Resource
    /// </summar>y
    public static class ExceptionResource
    {
        /// <summary>
        /// Gets the exception message.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Error message string</returns>
        public static string GetExceptionMessage(string key)
        {
            try
            {
                return StructureMapObjectFactory.Container.GetInstance<IExceptionCache>().GetExceptionMessage(key);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string ERR0001 { get { return GetExceptionMessage("ERR0001"); } }

        public static string ERR3400 { get { return GetExceptionMessage("ERR3400"); } }

        public static string ERR3401 { get { return GetExceptionMessage("ERR3401"); } }

        public static string ERR3402 { get { return GetExceptionMessage("ERR3402"); } }

        public static string ERR3403 { get { return GetExceptionMessage("ERR3403"); } }

        public static string ERR3415 { get { return GetExceptionMessage("ERR3415"); } }

        public static string ERR3418 { get { return GetExceptionMessage("ERR3418"); } }

        public static string OptionalExtrasInsuranceIsRequired { get { return GetExceptionMessage("OptionalExtrasInsuranceIsRequired"); } }

        public static string OptionalExtrasSeatingRequiredAllFlights { get { return GetExceptionMessage("OptionalExtrasSeatingRequiredAllFlights"); } }

        public static string PaymentCardNumberIsRequired { get { return GetExceptionMessage("PaymentCardNumberIsRequired"); } }

        public static string PaymentFirstNameIsRequired { get { return GetExceptionMessage("PaymentFirstNameIsRequired"); } }

        public static string PaymentLastNameIsRequired { get { return GetExceptionMessage("PaymentLastNameIsRequired"); } }

        public static string PaymentCvvIsRequired { get { return GetExceptionMessage("PaymentCvvIsRequired"); } }

        public static string PaymentAdress1IsRequired { get { return GetExceptionMessage("PaymentAdress1IsRequired"); } }

        public static string PaymentCityRequired { get { return GetExceptionMessage("PaymentCityRequired"); } }

        public static string PaymentPostccodeRequired { get { return GetExceptionMessage("PaymentPostccodeRequired"); } }

        public static string PaymentVoucherReferenceRequired { get { return GetExceptionMessage("PaymentVoucherReferenceRequired"); } }

        public static string PaymentVoucherPinRequired { get { return GetExceptionMessage("PaymentVoucherPinRequired"); } }

        public static string PaymentCvvIsInvalid { get { return GetExceptionMessage("PaymentCvvIsInvalid"); } }

        public static string PaymentCardNumberIsInvalid { get { return GetExceptionMessage("PaymentCardNumberIsInvalid"); } }

        public static string HumanInvalidTitle { get { return GetExceptionMessage("HumanInvalidTitle"); } }

        public static string HumanInvalidFirstName { get { return GetExceptionMessage("HumanInvalidFirstName"); } }

        public static string HumanInvalidLastName { get { return GetExceptionMessage("HumanInvalidLastName"); } }

        public static string HumanInvalidEmail { get { return GetExceptionMessage("HumanInvalidEmail"); } }


        // TA Invalid Login Details
        public static string HumanUserNameInvalid { get { return GetExceptionMessage("HumanUserNameInvalid"); } }

        public static string HumanTARequiredPassword { get { return GetExceptionMessage("HumanTARequiredPassword"); } }



        public static string HumanInvalidHomeNumber { get { return GetExceptionMessage("HumanInvalidHomeNumber"); } }

        public static string HumanInvalidMobileNumber { get { return GetExceptionMessage("HumanInvalidMobileNumber"); } }

        public static string HumanInvalidDateOfBirth { get { return GetExceptionMessage("HumanInvalidDateOfBirth"); } }

        public static string HumanRequiredPassword { get { return GetExceptionMessage("HumanRequiredPassword"); } }

        public static string HumanPasswordsDontMatch { get { return GetExceptionMessage("HumanPasswordsDontMatch"); } }

        public static string HumanInvalidPassword { get { return GetExceptionMessage("HumanInvalidPassword"); } }

        public static string PassengerInfantTooOld { get { return GetExceptionMessage("PassengerInfantTooOld"); } }

        public static string PassengerInfantTooYoung { get { return GetExceptionMessage("PassengerInfantTooYoung"); } }

        public static string PassengerChildTooOld { get { return GetExceptionMessage("PassengerChildTooOld"); } }

        public static string PassengerChildTooYoung { get { return GetExceptionMessage("PassengerChildTooYoung"); } }

        public static string PassengerHasMoreThanOneInfant { get { return GetExceptionMessage("PassengerHasMoreThanOneInfant"); } }
        public static string PassengerInfantMustBeAssignedToAnAdult { get { return GetExceptionMessage("PassengerInfantMustBeAssignedToAnAdult"); } }

        public static string PassengerDateOfBirthRequired { get { return GetExceptionMessage("PassengerDateOfBirthRequired"); } }

        public static string PassengerPhoneCountryCodeRequired { get { return GetExceptionMessage("PassengerPhoneCountryCodeRequired"); } }
        public static string PassengerPhoneAreaCodeRequired { get { return GetExceptionMessage("PassengerPhoneAreaCodeRequired"); } }
        public static string PassengerPhoneNumberRequired { get { return GetExceptionMessage("PassengerPhoneNumberRequired"); } }


        //validation for flight search
        public static string AirportDoesNotExistValidation { get { return GetExceptionMessage("AirportDoesNotExistValidation"); } }

        public static string DepartureDateRequiredIfOriginValidation { get { return GetExceptionMessage("DepartureDateRequiredIfOriginValidation"); } }

        public static string DepartureDateRequiredValidation { get { return GetExceptionMessage("DepartureDateRequiredValidation"); } }

        public static string DestinationRequiredIfOriginValidation { get { return GetExceptionMessage("DestinationRequiredIfOriginValidation"); } }

        public static string DestinationRequiredValidation { get { return GetExceptionMessage("DestinationRequiredValidation"); } }

        public static string DuplicateFlightValidation { get { return GetExceptionMessage("DuplicateFlightValidation"); } }

        public static string FlyingBackValidation { get { return GetExceptionMessage("FlyingBackValidation"); } }

        public static string FutureDateValidation { get { return GetExceptionMessage("FutureDateValidation"); } }

        public static string InfantPassengerValidation { get { return GetExceptionMessage("InfantPassengerValidation"); } }

        public static string JourneyValidationPrefix { get { return GetExceptionMessage("JourneyValidationPrefix"); } }

        public static string NotADateValildation { get { return GetExceptionMessage("NotADateValildation"); } }

        public static string OriginRequiredValidation { get { return GetExceptionMessage("OriginRequiredValidation"); } }

        public static string PassengersValidationPrefix { get { return GetExceptionMessage("PassengersValidationPrefix"); } }

        public static string PromoCodeValidation { get { return GetExceptionMessage("PromoCodeValidation"); } }

        public static string TotalPassengerValidation { get { return GetExceptionMessage("TotalPassengerValidation"); } }

        public static string ReturnDateRequiredForRoundTrip { get { return GetExceptionMessage("ReturnDateRequiredForRoundTrip"); } }

        public static string DestinationAirportNotFlownTo { get { return GetExceptionMessage("DestinationAirportNotFlownTo"); } }

        public static string PleaseSelectFlightToContinue { get { return GetExceptionMessage("PleaseSelectFlightToContinue"); } }

        public static string ReturnDateBeforeOutboundDate { get { return GetExceptionMessage("ReturnDateBeforeOutboundDate"); } }

        public static string PleaseChangeDatesAndTryAgain { get { return GetExceptionMessage("PleaseChangeDatesAndTryAgain"); } }

        public static string SessionExpired { get { return GetExceptionMessage("SessionExpired"); } }

        public static string UnexpectedException { get { return GetExceptionMessage("UnexpectedException"); } }

        public const string AccountEmailRequiredKey = "AccountEmailRequired";
        public static string AccountEmailRequired { get { return GetExceptionMessage("AccountEmailRequired"); } }

        public const string AccountStaffIdRequiredKey = "AccountStaffIdRequired";
        public static string AccountStaffIdRequired { get { return GetExceptionMessage("AccountStaffIdRequired"); } }

        public const string AccountPasswordRequiredKey = "AccountPasswordRequired";
        public static string AccountPasswordRequired { get { return GetExceptionMessage("AccountPasswordRequired"); } }

        public static string PaymentFailure { get { return GetExceptionMessage("PaymentFailure"); } }

        public static string SeatingAllOrNoPassengers { get { return GetExceptionMessage("SeatingAllOrNoPassengers"); } }
        public static string SeatingOwnSeat { get { return GetExceptionMessage("SeatingOwnSeat"); } }
        public static string SeatingTwoInfantsAisle { get { return GetExceptionMessage("SeatingTwoInfantsAisle"); } }
        public static string SeatingAllFlightsOrNone { get { return GetExceptionMessage("SeatingAllFlightsOrNone"); } }
        public static string SeatingFailedAssign { get { return GetExceptionMessage("SeatingFailedAssign"); } }
        public static string PayMustAcceptTerms { get { return GetExceptionMessage("PayMustAcceptTerms"); } }
        public static string PayExpiryMonthRequired { get { return GetExceptionMessage("PayExpiryMonthRequired"); } }
        public static string PayExpiryYearRequired { get { return GetExceptionMessage("PayExpiryYearRequired"); } }
        public static string PayCountryRequired { get { return GetExceptionMessage("PayCountryRequired"); } }
        public static string PayStateRequired { get { return GetExceptionMessage("PayStateRequired"); } }
        public static string PayZipRequired { get { return GetExceptionMessage("PayZipRequired"); } }
        public static string PayCardExpired { get { return GetExceptionMessage("PayCardExpired"); } }
        public static string PayWrongCardType { get { return GetExceptionMessage("PayWrongCardType"); } }
        public static string PayPaymentFailure { get { return GetExceptionMessage("PayPaymentFailure"); } }
        public static string PayDetailsNotValid { get { return GetExceptionMessage("PayDetailsNotValid"); } }
        public static string PayErrorWhileProcessing { get { return GetExceptionMessage("PayErrorWhileProcessing"); } }
        public static string TicketReferenceRequired { get { return GetExceptionMessage("TicketReferenceRequired"); } }
        public static string TicketLastNameRequired { get { return GetExceptionMessage("TicketLastNameRequired"); } }
        public static string TicketCouldNotFindBooking { get { return GetExceptionMessage("TicketCouldNotFindBooking"); } }
        public static string StatusArrivalTimeRequired { get { return GetExceptionMessage("StatusArrivalTimeRequired"); } }
        public static string StatusFlightNumberRequired { get { return GetExceptionMessage("StatusFlightNumberRequired"); } }
        public static string StatusFlightNumInvalid { get { return GetExceptionMessage("StatusFlightNumInvalid"); } }
        public static string AccountInvalidCredentials { get { return GetExceptionMessage("AccountInvalidCredentials"); } }
        public static string TimetableProblemWithSelection { get { return GetExceptionMessage("TimetableProblemWithSelection"); } }
        public static string BusinessTicketCouldNotFindBooking { get { return GetExceptionMessage("BusinessTicketCouldNotFindBooking"); } }//Added by a-5467 - Platinum changes - Block Business/Mixed PNRs

        //the buses ..
        public static string BusStationDoesNotExist { get { return GetExceptionMessage("BusStationDoesNotExist"); } }
        public static string PleaseEnterStartingStation { get { return GetExceptionMessage("PleaseEnterStartingStation"); } }
        public static string NoStationsFound { get { return GetExceptionMessage("NoStationsFound"); } }
        public static string OriginStationIsRequired { get { return GetExceptionMessage("OriginStationIsRequired"); } }
        public static string DestinationStationIsRequired { get { return GetExceptionMessage("DestinationStationIsRequired"); } }

        public static string InvalidPassport { get { return GetExceptionMessage("InvalidPassport"); } }

        public static string PassengerPhoneAreaCodeInvalid { get { return GetExceptionMessage("PassengerPhoneAreaCodeInvalid"); } }

        public static string PassengerPhoneNumberInvalid { get { return GetExceptionMessage("PassengerPhoneNumberInvalid"); } }

        public static string HumanInvalidMiddleName { get { return GetExceptionMessage("HumanInvalidMiddleName"); } }

        public static string PassengerAdultInRestrictedSeatCannotHaveInfantsAssigned { get { return GetExceptionMessage("PassengerAdultInRestrictedSeatCannotHaveInfantsAssigned"); } }

        public static string PaymentAddress1Invalid { get { return GetExceptionMessage("PaymentAddress1Invalid"); } }

        public static string PaymentAddress2Invalid { get { return GetExceptionMessage("PaymentAddress2Invalid"); } }

        public static string PaymentCityInvalid { get { return GetExceptionMessage("PaymentCityInvalid"); } }

        public static string PaymentBillingCountryIsRequired { get { return GetExceptionMessage("PaymentBillingCountryIsRequired"); } }

        public static string PaymentCardTypeIsRequired { get { return GetExceptionMessage("PaymentCardTypeIsRequired"); } }

        public static string AttemptToOverbookSoldOutFlight { get { return GetExceptionMessage("AttemptToOverbookSoldOutFlight"); } }

        public static string AnUnrecoverableErrorHasOccurredDuringCreateBooking { get { return GetExceptionMessage("AnUnrecoverableErrorHasOccurredDuringCreateBooking"); } }

        public static string AnUnrecoverableErrorHasOccurredDuringModifyBooking { get { return GetExceptionMessage("AnUnrecoverableErrorHasOccurredDuringModifyBooking"); } }

        public static string UseVoucherExpired { get { return GetExceptionMessage("UseVoucherExpired"); } }

        public static string HumanRequiredHomeCountryCode { get { return GetExceptionMessage("HumanRequiredHomeCountryCode"); } }

        public static string HumanRequiredMobileCountryCode { get { return GetExceptionMessage("HumanRequiredMobileCountryCode"); } }

        public static string NoFlights
        {
            get { return GetExceptionMessage("NoFlights"); }
        }

        // Reports  FLYD - 331

        public static string PaymentPointsEmailFail { get { return GetExceptionMessage("PaymentPointsEmailFail"); } }

        public static string PaymentPointsValidEmail { get { return GetExceptionMessage("PaymentPointsValidEmail"); } }

        public static string IsFutureDateValidation { get { return GetExceptionMessage("IsFutureDateValidation"); } }

        public static string HasValidParseString { get { return GetExceptionMessage("HasValidParseString"); } }

        public static string PleaseEnterEmailId { get { return GetExceptionMessage("PleaseEnterEmailId"); } }
        public static string ReportStartDateValidation { get { return GetExceptionMessage("ReportStartDateValidation"); } }
        public static string ReportEndDateValidation { get { return GetExceptionMessage("ReportEndDateValidation"); } }

        public static string TransactionStartDateValidation { get { return GetExceptionMessage("TransactionStartDateValidation"); } }
        public static string TransactionEndDateValidation { get { return GetExceptionMessage("TransactionEndDateValidation"); } }

        public static string InsufficientAvailableCredit { get { return GetExceptionMessage("InsufficientAvailableCredit"); } }

        //WR44 Create additional widget for online check-in on all content pages.
        public static string OLCIEnterLastName { get { return GetExceptionMessage("OLCIEnterLastName"); } }
        public static string OLCIEnterBookingRef { get { return GetExceptionMessage("OLCIEnterBookingRef"); } }

        //WR5 CR003
        public static string INFtoCHDValidation { get { return GetExceptionMessage("INFtoCHDValidation"); } }
        public static string CHDtoADTValidation { get { return GetExceptionMessage("CHDtoADTValidation"); } }
        public static string INFtoCHDChangeDateValidation { get { return GetExceptionMessage("INFtoCHDChangeDateValidation"); } }
        public static string CHDtoADTChangeDateValidation { get { return GetExceptionMessage("CHDtoADTChangeDateValidation"); } }
        //WR6 415-410-409-408-407-406-405
        public static string PaymentError { get { return GetExceptionMessage("PaymentError"); } }
        public static string PaymentAlert3DSecure { get { return GetExceptionMessage("PaymentAlert3DSecure"); } }
        public static string PaymentErrorMobile { get { return GetExceptionMessage("PaymentErrorMobile"); } }

        public static string FLXBaggageMessage { get { return GetExceptionMessage("FLXBaggageMessage"); } }
        public static string FLXMealMessage { get { return GetExceptionMessage("FLXMealMessage"); } }
        public static string FLXIfeMessage { get { return GetExceptionMessage("FLXIfeMessage"); } }
        public static string FLXSeatingMessage { get { return GetExceptionMessage("FLXSeatingMessage"); } }

        public static string MobileFLXBaggageMessage { get { return GetExceptionMessage("MobileFLXBaggageMessage"); } }
        public static string MobileFLXMealMessage { get { return GetExceptionMessage("MobileFLXMealMessage"); } }
        public static string MobileFLXIfeMessage { get { return GetExceptionMessage("MobileFLXIfeMessage"); } }
        public static string MobileFLXSeatingMessage { get { return GetExceptionMessage("MobileFLXSeatingMessage"); } }

    }
}
