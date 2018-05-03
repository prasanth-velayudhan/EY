using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using flydubai.Common.Model;
using flydubai.Model;
using flydubai.Model.Booking;
using flydubai.Model.Common;
using flydubai.Model.Content;
using flydubai.Model.Content.Enum;

using Splendid.Common;
using Splendid.Common.ByteExtensions;
using Splendid.Common.StringExtensions;

namespace flydubai.DatabaseServices
{
    using flydubai.Common;

    /// <summary>
    /// Initializes the Entity Framework Context
    /// </summary>
    /// <remarks></remarks>
    public class FlyDubaiContextInitialiser : CreateDatabaseIfNotExists<FlydubaiContext>
    {
        private FlydubaiContext context;

        /// <summary>
        /// Seeds the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <remarks></remarks>
        protected override void Seed(FlydubaiContext context)
        {
            this.context = context;

            this.LoadExceptionMessages();
            this.LoadCountries();
            this.LoadCodeTypes();

            this.LoadLanguages();
            this.LoadMembers();
            this.LoadDestinationCategories();
            this.LoadDepartureWindows();
            this.LoadApplicationSettings();

            this.context.HandBaggage.Add(new HandBaggage { Weight = 7 });

            this.context.BusinessHandBaggage.Add(new BusinessHandBaggage { Weight = 15 });//Added by a-5467 - Platinum changes

            context.SaveChanges();
        }

        private void LoadApplicationSettings()
        {
            this.context.WebsiteSettings.Add(new WebsiteSetting { Key = "HideMonthResults", Value = bool.FalseString });
            this.context.WebsiteSettings.Add(new WebsiteSetting { Key = "FlightSearchMaxMonthsAhead", Value = "11" });
        }

        private void LoadDepartureWindows()
        {
            this.context.DepartureWindows.Add(new DepartureWindow { DepartureWindowId = 1, Name = "Amend Booking", Minutes = 180 });
            this.context.DepartureWindows.Add(new DepartureWindow { DepartureWindowId = 2, Name = "Amend SSR", Minutes = 120 });
        }

        private void LoadExceptionMessages()
        {
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "ERR001", Language = "en", Value = "Voucher PIN does not match voucher code", Area = "Voucher" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "ERR3400", Language = "en", Value = "Voucher is expired", Area = "Voucher" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "ERR3401", Language = "en", Value = "Voucher has no available balance", Area = "Voucher" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "ERR3402", Language = "en", Value = "Voucher limit not sufficient", Area = "Voucher" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "ERR3403", Language = "en", Value = "Voucher has not been assigned. Please refer consumer to Airline Call Center for assistance", Area = "Voucher" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "ERR3415", Language = "en", Value = "Voucher owner was not found to be a passenger", Area = "Voucher" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "ERR3418", Language = "en", Value = "Voucher failed validation. Due to invalid Password/PIN", Area = "Voucher" });

            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "HumanInvalidTitle", Language = "en", Value = "HumanInvalidTitle", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "HumanInvalidFirstName", Language = "en", Value = "HumanInvalidFirstName", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "HumanInvalidLastName", Language = "en", Value = "HumanInvalidLastName", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "HumanInvalidEmail", Language = "en", Value = "HumanInvalidEmail", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "HumanInvalidHomeNumber", Language = "en", Value = "HumanInvalidHomeNumber", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "HumanInvalidMobileNumber", Language = "en", Value = "HumanInvalidMobileNumber", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "HumanInvalidDateOfBirth", Language = "en", Value = "HumanInvalidDateOfBirth", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "HumanRequiredPassword", Language = "en", Value = "HumanRequiredPassword", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "HumanPasswordsDontMatch", Language = "en", Value = "HumanPasswordsDontMatch", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage
                    {
                        Key = "OptionalExtrasInsuranceIsRequired",
                        Language = "en",
                        Value = "OptionalExtrasInsuranceIsRequired",
                        Area = "OptionalExtras"
                    });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage
                    {
                        Key = "OptionalExtrasSeatingRequiredAllFlights",
                        Language = "en",
                        Value = "OptionalExtrasSeatingRequiredAllFlights",
                        Area = "OptionalExtras"
                    });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage
                    { Key = "PaymentCardNumberIsRequired", Language = "en", Value = "PaymentCardNumberIsRequired", Area = "Payment" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "PaymentFirstNameIsRequired", Language = "en", Value = "PaymentFirstNameIsRequired", Area = "Payment" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "PaymentLastNameIsRequired", Language = "en", Value = "PaymentLastNameIsRequired", Area = "Payment" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "PaymentCvvIsRequired", Language = "en", Value = "PaymentCvvIsRequired", Area = "Payment" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "PaymentAdress1IsRequired", Language = "en", Value = "PaymentAdress1IsRequired", Area = "Payment" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "PaymentCityRequired", Language = "en", Value = "PaymentCityRequired", Area = "Payment" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "PaymentPostccodeRequired", Language = "en", Value = "PaymentPostccodeRequired", Area = "Payment" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage
                    {
                        Key = "PaymentVoucherReferenceRequired",
                        Language = "en",
                        Value = "PaymentVoucherReferenceRequired",
                        Area = "Payment"
                    });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "PaymentVoucherPinRequired", Language = "en", Value = "PaymentVoucherPinRequired", Area = "Voucher" });
            this.context.ExceptionMessages.Add(
                new ExceptionMessage { Key = "PaymentCvvIsInvalid", Language = "en", Value = "PaymentCvvIsInvalid", Area = "Payment" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PaymentCardNumberIsInvalid", Language = "en", Value = "PaymentCardNumberIsInvalid", Area = "Payment" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "HumanInvalidPassword", Language = "en", Value = "HumanInvalidPassword", Area = "Payment" });

            //search messages
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "AirportDoesNotExistValidation", Language = "en", Value = "Airport does not exist", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "DepartureDateRequiredIfOriginValidation", Language = "en", Value = "Departure date is required if origin specified", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "DepartureDateRequiredValidation", Language = "en", Value = "The departure date is required", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "DestinationRequiredIfOriginValidation", Language = "en", Value = "Destination is required if origin specified", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "DestinationRequiredValidation", Language = "en", Value = "The destination airport is required", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "DuplicateFlightValidation", Language = "en", Value = "This appears to be a duplicate, since no two flights can be the same please change and try again.", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "FlyingBackValidation", Language = "en", Value = "Date must be after your departure date.", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "FutureDateValidation", Language = "en", Value = "Must be today or later", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "InfantPassengerValidation", Language = "en", Value = "For legal reasons the number of infants must not exceed the number of adults.", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "JourneyValidationPrefix", Language = "en", Value = "Journey", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "NotADateValildation", Language = "en", Value = "Not a date", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "OriginRequiredValidation", Language = "en", Value = "The origin airport is required", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengersValidationPrefix", Language = "en", Value = "Passengers: ", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PromoCodeValidation", Language = "en", Value = "Please enter a valid Promotional Code.", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "TotalPassengerValidation", Language = "en", Value = "The total number of passengers must be less than 9.", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "ReturnDateRequiredForRoundTrip", Language = "en", Value = "Return date is required for round-trips", Area = "search" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "DestinationAirportNotFlownTo", Language = "en", Value = "We don’t fly on your chosen route, please select another airport from the list below." });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PleaseSelectFlightToContinue", Language = "en", Value = "Please select a flight to Continue" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "FlyingBackValidationMulticity", Language = "en", Value = "Date must be after the departure date of previous flight.", Area = "search" });

            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerInfantTooOld", Language = "en", Value = "Infant passengers must be under 2 years old", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerInfantTooYoung", Language = "en", Value = "Passengers must be over 14 days old to fly", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerChildTooOld", Language = "en", Value = "Child passengers must be under 12 years of age", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerChildTooYoung", Language = "en", Value = "Child passengers must be over 2 years of age", Area = "PassengerDetails" });

            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerHasMoreThanOneInfant", Language = "en", Value = "Adult passengers may only be assigned one infant", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerInfantMustBeAssignedToAnAdult", Language = "en", Value = "Infant passengers must be assigned to an adult", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerDateOfBirthRequired", Language = "en", Value = "The date of birth is required", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerPhoneCountryCodeRequired", Language = "en", Value = "The Country dialling code is required", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerPhoneAreaCodeRequired", Language = "en", Value = "The area dialling code is required", Area = "PassengerDetails" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PassengerPhoneNumberRequired", Language = "en", Value = "The phone number is required", Area = "PassengerDetails" });

            //mobile messages
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "SeatingAllOrNoPassengers", Language = "en", Value = "Either all or no passengers in your party must select a seat", Area = "mobile-extras" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "SeatingOwnSeat", Language = "en", Value = "Passengers must have their own seat", Area = "mobile-extras" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "SeatingTwoInfantsAisle", Language = "en", Value = "Cannot seat two infants in the same row and on the same side of the aisle", Area = "mobile-extras" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "SeatingAllFlightsOrNone", Language = "en", Value = "You must select seats for all flights or for none", Area = "mobile-extras" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "SeatingFailedAssign", Language = "en", Value = "Failed to assign seats. Please try again.", Area = "mobile-extras" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayMustAcceptTerms", Language = "en", Value = "You must accept the terms and conditions", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayExpiryMonthRequired", Language = "en", Value = "The card expiry month is required", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayExpiryYearRequired", Language = "en", Value = "The card expiry year is required", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayCountryRequired", Language = "en", Value = "The country is required", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayStateRequired", Language = "en", Value = "State is required for USA and Canada", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayZipRequired", Language = "en", Value = "Zip Code is required for USA and Candada", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayCardExpired", Language = "en", Value = "Card has expired", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayWrongCardType", Language = "en", Value = "Card type does not match card number", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "TicketReferenceRequired", Language = "en", Value = "Your booking reference is required", Area = "mobile-ticket" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "TicketLastNameRequired", Language = "en", Value = "The surname of one of the passengers is required", Area = "mobile-ticket" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "StatusArrivalTimeRequired", Language = "en", Value = "The arrival time is required", Area = "mobile-status" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "StatusFlightNumInvalid", Language = "en", Value = "Invalid flight number", Area = "mobile-status" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "StatusFlightNumberRequired", Language = "en", Value = "The flight number is required", Area = "mobile-status" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "AccountInvalidCredentials", Language = "en", Value = "Your Email address or password is incorrect", Area = "mobile-account" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "TicketCouldNotFindBooking", Language = "en", Value = "Could not find your booking", Area = "mobile-ticket" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayPaymentFailure", Language = "en", Value = "Your payment has failed.  Please try again.", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayDetailsNotValid", Language = "en", Value = "Your credit card details are not valid.  Please amend and try again.", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PayErrorWhileProcessing", Language = "en", Value = "There was an error processing your payment.  Please try again.", Area = "mobile-pay" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "TimetableProblemWithSelection", Language = "en", Value = "There was a problem with your selection", Area = "mobile-timetable" });

            //bus station
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "BusStationDoesNotExist", Language = "en", Value = "This bus station doesn't exist", Area = "bus-service" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "PleaseEnterStartingStation", Language = "en", Value = "Please enter a starting station", Area = "bus-service" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "NoStationsFound", Language = "en", Value = "No stations found", Area = "bus-service" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "OriginStationIsRequired", Language = "en", Value = "The originating station is required", Area = "bus-service" });
            this.context.ExceptionMessages.Add(new ExceptionMessage { Key = "DestinationStationIsRequired", Language = "en", Value = "The destination station is required", Area = "bus-service" });

        }

        private void LoadCountries()
        {
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AF", AlphaNumeric3 = "AFG", IsoNumeric = "4", TelephoneCode = "93", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "AFGHANISTAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AX", AlphaNumeric3 = "ALA", IsoNumeric = "248", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ALAND ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AL", AlphaNumeric3 = "ALB", IsoNumeric = "8", TelephoneCode = "355", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ALBANIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "DZ", AlphaNumeric3 = "DZA", IsoNumeric = "12", TelephoneCode = "213", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ALGERIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AS", AlphaNumeric3 = "ASM", IsoNumeric = "16", TelephoneCode = "1-684", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "AMERICAN SAMOA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AD", AlphaNumeric3 = "AND", IsoNumeric = "20", TelephoneCode = "376", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ANDORRA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AO", AlphaNumeric3 = "AGO", IsoNumeric = "24", TelephoneCode = "244", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ANGOLA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AI", AlphaNumeric3 = "AIA", IsoNumeric = "660", TelephoneCode = "1-264", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ANGUILLA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AQ", AlphaNumeric3 = "ATA", IsoNumeric = "10", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ANTARCTICA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AG", AlphaNumeric3 = "ATG", IsoNumeric = "28", TelephoneCode = "1-268", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ANTIGUA AND BARBUDA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AR", AlphaNumeric3 = "ARG", IsoNumeric = "32", TelephoneCode = "54", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ARGENTINA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AM", AlphaNumeric3 = "ARM", IsoNumeric = "51", TelephoneCode = "7", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ARMENIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AW", AlphaNumeric3 = "ABW", IsoNumeric = "533", TelephoneCode = "297", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ARUBA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AU", AlphaNumeric3 = "AUS", IsoNumeric = "36", TelephoneCode = "61", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "AUSTRALIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AT", AlphaNumeric3 = "AUT", IsoNumeric = "40", TelephoneCode = "43", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "AUSTRIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AZ", AlphaNumeric3 = "AZE", IsoNumeric = "31", TelephoneCode = "994", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "AZERBAIJAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BS", AlphaNumeric3 = "BHS", IsoNumeric = "44", TelephoneCode = "1-242", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BAHAMAS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BH", AlphaNumeric3 = "BHR", IsoNumeric = "48", TelephoneCode = "973", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BAHRAIN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BD", AlphaNumeric3 = "BGD", IsoNumeric = "50", TelephoneCode = "880", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BANGLADESH" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BB", AlphaNumeric3 = "BRB", IsoNumeric = "52", TelephoneCode = "1-246", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BARBADOS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BY", AlphaNumeric3 = "BLR", IsoNumeric = "112", TelephoneCode = "375", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BELARUS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BE", AlphaNumeric3 = "BEL", IsoNumeric = "56", TelephoneCode = "32", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BELGIUM" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BZ", AlphaNumeric3 = "BLZ", IsoNumeric = "84", TelephoneCode = "501", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BELIZE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BJ", AlphaNumeric3 = "BEN", IsoNumeric = "204", TelephoneCode = "229", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BENIN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BM", AlphaNumeric3 = "BMU", IsoNumeric = "60", TelephoneCode = "1-441", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BERMUDA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BT", AlphaNumeric3 = "BTN", IsoNumeric = "64", TelephoneCode = "975", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BHUTAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BO", AlphaNumeric3 = "BOL", IsoNumeric = "68", TelephoneCode = "591", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BOLIVIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BQ", AlphaNumeric3 = "BES", IsoNumeric = "535", TelephoneCode = "599", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BONAIRE, ST. EUSTATIUS, AND SABA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BA", AlphaNumeric3 = "BIH", IsoNumeric = "70", TelephoneCode = "387", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BOSNIA AND HERZEGOVINA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BW", AlphaNumeric3 = "BWA", IsoNumeric = "72", TelephoneCode = "267", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BOTSWANA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BV", AlphaNumeric3 = "BVT", IsoNumeric = "74", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BOUVET ISLAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BR", AlphaNumeric3 = "BRA", IsoNumeric = "76", TelephoneCode = "55", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BRAZIL" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "IO", AlphaNumeric3 = "IOT", IsoNumeric = "86", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BRITISH INDIAN OCEAN TERRITORY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BN", AlphaNumeric3 = "BRN", IsoNumeric = "96", TelephoneCode = "673", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BRUNEI DARUSSALAM" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BG", AlphaNumeric3 = "BGR", IsoNumeric = "100", TelephoneCode = "359", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BULGARIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BF", AlphaNumeric3 = "BFA", IsoNumeric = "854", TelephoneCode = "226", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BURKINA FASO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BI", AlphaNumeric3 = "BDI", IsoNumeric = "108", TelephoneCode = "257", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "BURUNDI" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KH", AlphaNumeric3 = "KHM", IsoNumeric = "116", TelephoneCode = "855", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CAMBODIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CM", AlphaNumeric3 = "CMR", IsoNumeric = "120", TelephoneCode = "237", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CAMEROON" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CA", AlphaNumeric3 = "CAN", IsoNumeric = "124", TelephoneCode = "1", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CANADA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CV", AlphaNumeric3 = "CPV", IsoNumeric = "132", TelephoneCode = "238", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CAPE VERDE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KY", AlphaNumeric3 = "CYM", IsoNumeric = "136", TelephoneCode = "1-345", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CAYMAN ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CF", AlphaNumeric3 = "CAF", IsoNumeric = "140", TelephoneCode = "236", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CENTRAL AFRICAN REPUBLIC" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TD", AlphaNumeric3 = "TCD", IsoNumeric = "148", TelephoneCode = "235", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CHAD" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CL", AlphaNumeric3 = "CHL", IsoNumeric = "152", TelephoneCode = "56", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CHILE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CN", AlphaNumeric3 = "CHN", IsoNumeric = "156", TelephoneCode = "86", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CHINA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CX", AlphaNumeric3 = "CXR", IsoNumeric = "162", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CHRISTMAS ISLAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CC", AlphaNumeric3 = "CCK", IsoNumeric = "166", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "COCOS ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CO", AlphaNumeric3 = "COL", IsoNumeric = "170", TelephoneCode = "57", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "COLOMBIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KM", AlphaNumeric3 = "COM", IsoNumeric = "174", TelephoneCode = "269", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "COMOROS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CG", AlphaNumeric3 = "COG", IsoNumeric = "178", TelephoneCode = "242", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CONGO, REPUBLIC OF" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CD", AlphaNumeric3 = "COD", IsoNumeric = "180", TelephoneCode = "243", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CONGO, THE DEMOCRATIC REPUBLIC OF THE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CK", AlphaNumeric3 = "COK", IsoNumeric = "184", TelephoneCode = "682", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "COOK ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CR", AlphaNumeric3 = "CRI", IsoNumeric = "188", TelephoneCode = "506", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "COSTA RICA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CI", AlphaNumeric3 = "CIV", IsoNumeric = "384", TelephoneCode = "225", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "IVORY COAST" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "HR", AlphaNumeric3 = "HRV", IsoNumeric = "191", TelephoneCode = "385", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CROATIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CU", AlphaNumeric3 = "CUB", IsoNumeric = "192", TelephoneCode = "53", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CUBA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CW", AlphaNumeric3 = "CUW", IsoNumeric = "531", TelephoneCode = "599", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CURAÇAO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CY", AlphaNumeric3 = "CYP", IsoNumeric = "196", TelephoneCode = "357", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CYPRUS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CZ", AlphaNumeric3 = "CZE", IsoNumeric = "203", TelephoneCode = "420", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "CZECH REPUBLIC" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "DK", AlphaNumeric3 = "DNK", IsoNumeric = "208", TelephoneCode = "45", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "DENMARK" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "DJ", AlphaNumeric3 = "DJI", IsoNumeric = "262", TelephoneCode = "253", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "DJIBOUTI" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "DM", AlphaNumeric3 = "DMA", IsoNumeric = "212", TelephoneCode = "1-767", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "DOMINICA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "DO", AlphaNumeric3 = "DOM", IsoNumeric = "214", TelephoneCode = "1-809", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "DOMINICAN REPUBLIC" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "EC", AlphaNumeric3 = "ECU", IsoNumeric = "218", TelephoneCode = "593", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ECUADOR" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "EG", AlphaNumeric3 = "EGY", IsoNumeric = "818", TelephoneCode = "20", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "EGYPT" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SV", AlphaNumeric3 = "SLV", IsoNumeric = "222", TelephoneCode = "503", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "EL SALVADOR" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GQ", AlphaNumeric3 = "GNQ", IsoNumeric = "226", TelephoneCode = "240", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "EQUATORIAL GUINEA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ER", AlphaNumeric3 = "ERI", IsoNumeric = "232", TelephoneCode = "291", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ERITREA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "EE", AlphaNumeric3 = "EST", IsoNumeric = "233", TelephoneCode = "372", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ESTONIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ET", AlphaNumeric3 = "ETH", IsoNumeric = "231", TelephoneCode = "251", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ETHIOPIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "FO", AlphaNumeric3 = "FRO", IsoNumeric = "234", TelephoneCode = "298", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "FAEROE ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "FK", AlphaNumeric3 = "FLK", IsoNumeric = "238", TelephoneCode = "500", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "FALKLAND ISLANDS (MALVINAS)" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "FJ", AlphaNumeric3 = "FJI", IsoNumeric = "242", TelephoneCode = "679", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "FIJI" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "FI", AlphaNumeric3 = "FIN", IsoNumeric = "246", TelephoneCode = "358", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "FINLAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "FR", AlphaNumeric3 = "FRA", IsoNumeric = "250", TelephoneCode = "33", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "FRANCE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GF", AlphaNumeric3 = "GUF", IsoNumeric = "254", TelephoneCode = "594", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "FRENCH GUIANA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PF", AlphaNumeric3 = "PYF", IsoNumeric = "258", TelephoneCode = "689", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "FRENCH POLYNESIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TF", AlphaNumeric3 = "ATF", IsoNumeric = "260", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "FRENCH SOUTHERN TERRITORIES" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GA", AlphaNumeric3 = "GAB", IsoNumeric = "266", TelephoneCode = "241", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GABON" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GM", AlphaNumeric3 = "GMB", IsoNumeric = "270", TelephoneCode = "220", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GAMBIA, THE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GE", AlphaNumeric3 = "GEO", IsoNumeric = "268", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GEORGIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "DE", AlphaNumeric3 = "DEU", IsoNumeric = "276", TelephoneCode = "49", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GERMANY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GH", AlphaNumeric3 = "GHA", IsoNumeric = "288", TelephoneCode = "233", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GHANA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GI", AlphaNumeric3 = "GIB", IsoNumeric = "292", TelephoneCode = "350", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GIBRALTAR" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GB", AlphaNumeric3 = "GBR", IsoNumeric = "826", TelephoneCode = "44", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GREAT BRITAIN (United Kingdom)" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GR", AlphaNumeric3 = "GRC", IsoNumeric = "300", TelephoneCode = "30", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GREECE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GL", AlphaNumeric3 = "GRL", IsoNumeric = "304", TelephoneCode = "299", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GREENLAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GD", AlphaNumeric3 = "GRD", IsoNumeric = "308", TelephoneCode = "1-473", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GRENADA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GP", AlphaNumeric3 = "GLP", IsoNumeric = "312", TelephoneCode = "590", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GUADELOUPE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GU", AlphaNumeric3 = "GUM", IsoNumeric = "316", TelephoneCode = "1-671", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GUAM" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GT", AlphaNumeric3 = "GTM", IsoNumeric = "320", TelephoneCode = "502", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GUATEMALA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GN", AlphaNumeric3 = "GIN", IsoNumeric = "324", TelephoneCode = "224", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GUINEA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GW", AlphaNumeric3 = "GNB", IsoNumeric = "624", TelephoneCode = "245", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GUINEA-BISSAU" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GY", AlphaNumeric3 = "GUY", IsoNumeric = "328", TelephoneCode = "592", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "GUYANA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "HT", AlphaNumeric3 = "HTI", IsoNumeric = "332", TelephoneCode = "509", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "HAITI" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "HM", AlphaNumeric3 = "HMD", IsoNumeric = "334", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "HEARD ISLAND AND MCDONALD ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "HN", AlphaNumeric3 = "HND", IsoNumeric = "340", TelephoneCode = "504", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "HONDURAS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "HK", AlphaNumeric3 = "HKG", IsoNumeric = "344", TelephoneCode = "852", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "HONG KONG" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "HU", AlphaNumeric3 = "HUN", IsoNumeric = "348", TelephoneCode = "36", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "HUNGARY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "IS", AlphaNumeric3 = "ISL", IsoNumeric = "352", TelephoneCode = "354", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ICELAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "IN", AlphaNumeric3 = "IND", IsoNumeric = "356", TelephoneCode = "91", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "INDIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ID", AlphaNumeric3 = "IDN", IsoNumeric = "360", TelephoneCode = "62", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "INDONESIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "IR", AlphaNumeric3 = "IRN", IsoNumeric = "364", TelephoneCode = "98", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "IRAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "IQ", AlphaNumeric3 = "IRQ", IsoNumeric = "368", TelephoneCode = "964", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "IRAQ" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "IE", AlphaNumeric3 = "IRL", IsoNumeric = "372", TelephoneCode = "353", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "IRELAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "IM", AlphaNumeric3 = "IMN", IsoNumeric = "833", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ISLE OF MAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "IL", AlphaNumeric3 = "ISR", IsoNumeric = "376", TelephoneCode = "972", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ISRAEL" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "IT", AlphaNumeric3 = "ITA", IsoNumeric = "380", TelephoneCode = "39", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ITALY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "JM", AlphaNumeric3 = "JAM", IsoNumeric = "388", TelephoneCode = "1-876", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "JAMAICA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "JP", AlphaNumeric3 = "JPN", IsoNumeric = "392", TelephoneCode = "81", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "JAPAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "JO", AlphaNumeric3 = "JOR", IsoNumeric = "400", TelephoneCode = "962", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "JORDAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KZ", AlphaNumeric3 = "KAZ", IsoNumeric = "398", TelephoneCode = "7", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "KAZAKHSTAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KE", AlphaNumeric3 = "KEN", IsoNumeric = "404", TelephoneCode = "254", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "KENYA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KI", AlphaNumeric3 = "KIR", IsoNumeric = "296", TelephoneCode = "686", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "KIRIBATI" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KP", AlphaNumeric3 = "PRK", IsoNumeric = "408", TelephoneCode = "850", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NORTH KOREA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KR", AlphaNumeric3 = "KOR", IsoNumeric = "410", TelephoneCode = "82", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SOUTH KOREA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KW", AlphaNumeric3 = "KWT", IsoNumeric = "414", TelephoneCode = "965", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "KUWAIT" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KG", AlphaNumeric3 = "KGZ", IsoNumeric = "417", TelephoneCode = "996", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "KYRGYZSTAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LA", AlphaNumeric3 = "LAO", IsoNumeric = "418", TelephoneCode = "856", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "LAO PEOPLE'S DEMOCRATIC REPUBLIC" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LV", AlphaNumeric3 = "LVA", IsoNumeric = "428", TelephoneCode = "371", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "LATVIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LB", AlphaNumeric3 = "LBN", IsoNumeric = "422", TelephoneCode = "961", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "LEBANON" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LS", AlphaNumeric3 = "LSO", IsoNumeric = "426", TelephoneCode = "266", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "LESOTHO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LR", AlphaNumeric3 = "LBR", IsoNumeric = "430", TelephoneCode = "231", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "LIBERIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LY", AlphaNumeric3 = "LBY", IsoNumeric = "434", TelephoneCode = "218", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "LIBYA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LI", AlphaNumeric3 = "LIE", IsoNumeric = "438", TelephoneCode = "423", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "LIECHTENSTEIN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LT", AlphaNumeric3 = "LTU", IsoNumeric = "440", TelephoneCode = "370", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "LITHUANIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LU", AlphaNumeric3 = "LUX", IsoNumeric = "442", TelephoneCode = "352", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "LUXEMBOURG" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MO", AlphaNumeric3 = "MAC", IsoNumeric = "446", TelephoneCode = "853", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MACAO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MK", AlphaNumeric3 = "MKD", IsoNumeric = "807", TelephoneCode = "389", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MACEDONIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MG", AlphaNumeric3 = "MDG", IsoNumeric = "450", TelephoneCode = "261", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MADAGASCAR" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MW", AlphaNumeric3 = "MWI", IsoNumeric = "454", TelephoneCode = "265", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MALAWI" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MY", AlphaNumeric3 = "MYS", IsoNumeric = "458", TelephoneCode = "60", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MALAYSIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MV", AlphaNumeric3 = "MDV", IsoNumeric = "462", TelephoneCode = "960", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MALDIVES" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ML", AlphaNumeric3 = "MLI", IsoNumeric = "466", TelephoneCode = "223", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MALI" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MT", AlphaNumeric3 = "MLT", IsoNumeric = "470", TelephoneCode = "356", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MALTA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MH", AlphaNumeric3 = "MHL", IsoNumeric = "584", TelephoneCode = "692", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MARSHALL ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MQ", AlphaNumeric3 = "MTQ", IsoNumeric = "474", TelephoneCode = "596", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MARTINIQUE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MR", AlphaNumeric3 = "MRT", IsoNumeric = "478", TelephoneCode = "222", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MAURITANIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MU", AlphaNumeric3 = "MUS", IsoNumeric = "480", TelephoneCode = "230", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MAURITIUS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "YT", AlphaNumeric3 = "MYT", IsoNumeric = "175", TelephoneCode = "269", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MAYOTTE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MX", AlphaNumeric3 = "MEX", IsoNumeric = "484", TelephoneCode = "52", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MEXICO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "FM", AlphaNumeric3 = "FSM", IsoNumeric = "583", TelephoneCode = "691", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MICRONESIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MD", AlphaNumeric3 = "MDA", IsoNumeric = "498", TelephoneCode = "373", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MOLDOVA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MC", AlphaNumeric3 = "MCO", IsoNumeric = "492", TelephoneCode = "377", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MONACO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MN", AlphaNumeric3 = "MNG", IsoNumeric = "496", TelephoneCode = "976", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MONGOLIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ME", AlphaNumeric3 = "MNE", IsoNumeric = "499", TelephoneCode = "382", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MONTENEGRO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MS", AlphaNumeric3 = "MSR", IsoNumeric = "500", TelephoneCode = "1-664", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MONTSERRAT" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MA", AlphaNumeric3 = "MAR", IsoNumeric = "504", TelephoneCode = "212", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MOROCCO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MZ", AlphaNumeric3 = "MOZ", IsoNumeric = "508", TelephoneCode = "258", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MOZAMBIQUE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MM", AlphaNumeric3 = "MMR", IsoNumeric = "104", TelephoneCode = "95", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "MYANMAR" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NA", AlphaNumeric3 = "NAM", IsoNumeric = "516", TelephoneCode = "264", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NAMIBIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NR", AlphaNumeric3 = "NRU", IsoNumeric = "520", TelephoneCode = "674", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NAURU" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NP", AlphaNumeric3 = "NPL", IsoNumeric = "524", TelephoneCode = "977", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NEPAL" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NL", AlphaNumeric3 = "NLD", IsoNumeric = "528", TelephoneCode = "31", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NETHERLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AN", AlphaNumeric3 = "ANT", IsoNumeric = "530", TelephoneCode = "599", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NETHERLANDS ANTILLES" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NC", AlphaNumeric3 = "NCL", IsoNumeric = "540", TelephoneCode = "687", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NEW CALEDONIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NZ", AlphaNumeric3 = "NZL", IsoNumeric = "554", TelephoneCode = "64", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NEW ZEALAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NI", AlphaNumeric3 = "NIC", IsoNumeric = "558", TelephoneCode = "505", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NICARAGUA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NE", AlphaNumeric3 = "NER", IsoNumeric = "562", TelephoneCode = "227", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NIGER" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NG", AlphaNumeric3 = "NGA", IsoNumeric = "566", TelephoneCode = "234", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NIGERIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NU", AlphaNumeric3 = "NIU", IsoNumeric = "570", TelephoneCode = "683", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NIUE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NF", AlphaNumeric3 = "NFK", IsoNumeric = "574", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NORFOLK ISLAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MP", AlphaNumeric3 = "MNP", IsoNumeric = "580", TelephoneCode = "1-670", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NORTHERN MARIANA ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "NO", AlphaNumeric3 = "NOR", IsoNumeric = "578", TelephoneCode = "47", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "NORWAY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "OM", AlphaNumeric3 = "OMN", IsoNumeric = "512", TelephoneCode = "968", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "OMAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PK", AlphaNumeric3 = "PAK", IsoNumeric = "586", TelephoneCode = "92", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PAKISTAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PW", AlphaNumeric3 = "PLW", IsoNumeric = "585", TelephoneCode = "680", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PALAU" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PS", AlphaNumeric3 = "PSE", IsoNumeric = "275", TelephoneCode = "970", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PALESTINIAN TERRITORIES" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PA", AlphaNumeric3 = "PAN", IsoNumeric = "591", TelephoneCode = "507", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PANAMA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PG", AlphaNumeric3 = "PNG", IsoNumeric = "598", TelephoneCode = "675", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PAPUA NEW GUINEA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PY", AlphaNumeric3 = "PRY", IsoNumeric = "600", TelephoneCode = "595", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PARAGUAY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PE", AlphaNumeric3 = "PER", IsoNumeric = "604", TelephoneCode = "51", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PERU" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PH", AlphaNumeric3 = "PHL", IsoNumeric = "608", TelephoneCode = "63", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PHILIPPINES" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PN", AlphaNumeric3 = "PCN", IsoNumeric = "612", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PITCAIRN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PL", AlphaNumeric3 = "POL", IsoNumeric = "616", TelephoneCode = "48", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "POLAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PT", AlphaNumeric3 = "PRT", IsoNumeric = "620", TelephoneCode = "351", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PORTUGAL" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PR", AlphaNumeric3 = "PRI", IsoNumeric = "630", TelephoneCode = "1", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "PUERTO RICO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "QA", AlphaNumeric3 = "QAT", IsoNumeric = "634", TelephoneCode = "974", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "QATAR" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "RE", AlphaNumeric3 = "REU", IsoNumeric = "638", TelephoneCode = "262", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "RÉUNION" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "RO", AlphaNumeric3 = "ROM", IsoNumeric = "642", TelephoneCode = "40", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ROMANIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "RU", AlphaNumeric3 = "RUS", IsoNumeric = "643", TelephoneCode = "7", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "RUSSIAN FEDERATION" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "RW", AlphaNumeric3 = "RWA", IsoNumeric = "646", TelephoneCode = "250", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "RWANDA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "BL", AlphaNumeric3 = "BLM", IsoNumeric = "652", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAINT BARTHÉLEMY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SH", AlphaNumeric3 = "SHN", IsoNumeric = "654", TelephoneCode = "290", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAINT HELENA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "KN", AlphaNumeric3 = "KNA", IsoNumeric = "659", TelephoneCode = "1-869", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAINT KITTS AND NEVIS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LC", AlphaNumeric3 = "LCA", IsoNumeric = "662", TelephoneCode = "1-758", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAINT LUCIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "MF", AlphaNumeric3 = "MAF", IsoNumeric = "663", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAINT MARTIN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "PM", AlphaNumeric3 = "SPM", IsoNumeric = "666", TelephoneCode = "508", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAINT PIERRE AND MIQUELON" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "VC", AlphaNumeric3 = "VCT", IsoNumeric = "670", TelephoneCode = "1-784", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAINT VINCENT AND THE GRENADINES" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "WS", AlphaNumeric3 = "WSM", IsoNumeric = "882", TelephoneCode = "685", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAMOA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SM", AlphaNumeric3 = "SMR", IsoNumeric = "674", TelephoneCode = "378", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAN MARINO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ST", AlphaNumeric3 = "STP", IsoNumeric = "678", TelephoneCode = "239", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAO TOME AND PRINCIPE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SA", AlphaNumeric3 = "SAU", IsoNumeric = "682", TelephoneCode = "966", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SAUDI ARABIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SN", AlphaNumeric3 = "SEN", IsoNumeric = "686", TelephoneCode = "221", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SENEGAL" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "RS", AlphaNumeric3 = "SRB", IsoNumeric = "688", TelephoneCode = "381", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SERBIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SC", AlphaNumeric3 = "SYC", IsoNumeric = "690", TelephoneCode = "248", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SEYCHELLES" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SL", AlphaNumeric3 = "SLE", IsoNumeric = "694", TelephoneCode = "232", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SIERRA LEONE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SG", AlphaNumeric3 = "SGP", IsoNumeric = "702", TelephoneCode = "65", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SINGAPORE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SX", AlphaNumeric3 = "SXM", IsoNumeric = "534", TelephoneCode = "599", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SINT MAARTEN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SK", AlphaNumeric3 = "SVK", IsoNumeric = "703", TelephoneCode = "421", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SLOVAKIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SI", AlphaNumeric3 = "SVN", IsoNumeric = "705", TelephoneCode = "386", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SLOVENIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SB", AlphaNumeric3 = "SLB", IsoNumeric = "90", TelephoneCode = "677", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SOLOMON ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SO", AlphaNumeric3 = "SOM", IsoNumeric = "706", TelephoneCode = "252", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SOMALIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ZA", AlphaNumeric3 = "ZAF", IsoNumeric = "710", TelephoneCode = "27", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SOUTH AFRICA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GS", AlphaNumeric3 = "SGS", IsoNumeric = "239", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ES", AlphaNumeric3 = "ESP", IsoNumeric = "724", TelephoneCode = "34", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SPAIN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "LK", AlphaNumeric3 = "LKA", IsoNumeric = "144", TelephoneCode = "94", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SRI LANKA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SD", AlphaNumeric3 = "SDN", IsoNumeric = "736", TelephoneCode = "249", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SUDAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SR", AlphaNumeric3 = "SUR", IsoNumeric = "740", TelephoneCode = "597", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SURINAME" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SJ", AlphaNumeric3 = "SJM", IsoNumeric = "744", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SVALBARD AND JAN MAYEN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SZ", AlphaNumeric3 = "SWZ", IsoNumeric = "748", TelephoneCode = "268", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SWAZILAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SE", AlphaNumeric3 = "SWE", IsoNumeric = "752", TelephoneCode = "46", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SWEDEN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "CH", AlphaNumeric3 = "CHE", IsoNumeric = "756", TelephoneCode = "41", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SWITZERLAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "SY", AlphaNumeric3 = "SYR", IsoNumeric = "760", TelephoneCode = "963", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "SYRIAN ARAB REPUBLIC" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TW", AlphaNumeric3 = "TWN", IsoNumeric = "158", TelephoneCode = "886", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TAIWAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TJ", AlphaNumeric3 = "TJK", IsoNumeric = "762", TelephoneCode = "992", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TAJIKISTAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TZ", AlphaNumeric3 = "TZA", IsoNumeric = "834", TelephoneCode = "255", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TANZANIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TH", AlphaNumeric3 = "THA", IsoNumeric = "764", TelephoneCode = "66", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "THAILAND" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TP", AlphaNumeric3 = "TMP", IsoNumeric = "626", TelephoneCode = "670", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TIMOR-LESTE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TG", AlphaNumeric3 = "TGO", IsoNumeric = "768", TelephoneCode = "228", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TOGO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TK", AlphaNumeric3 = "TKL", IsoNumeric = "772", TelephoneCode = "690", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TOKELAU" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TO", AlphaNumeric3 = "TON", IsoNumeric = "776", TelephoneCode = "676", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TONGA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TT", AlphaNumeric3 = "TTO", IsoNumeric = "780", TelephoneCode = "1-868", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TRINIDAD AND TOBAGO" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TN", AlphaNumeric3 = "TUN", IsoNumeric = "788", TelephoneCode = "216", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TUNISIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TR", AlphaNumeric3 = "TUR", IsoNumeric = "792", TelephoneCode = "90", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TURKEY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TM", AlphaNumeric3 = "TKM", IsoNumeric = "795", TelephoneCode = "993", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TURKMENISTAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TC", AlphaNumeric3 = "TCA", IsoNumeric = "796", TelephoneCode = "1-649", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TURKS AND CAICOS ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "TV", AlphaNumeric3 = "TUV", IsoNumeric = "798", TelephoneCode = "688", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "TUVALU" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "UG", AlphaNumeric3 = "UGA", IsoNumeric = "800", TelephoneCode = "256", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "UGANDA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "UA", AlphaNumeric3 = "UKR", IsoNumeric = "804", TelephoneCode = "380", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "UKRAINE" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "AE", AlphaNumeric3 = "ARE", IsoNumeric = "784", TelephoneCode = "971", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "UNITED ARAB EMIRATES" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "GB", AlphaNumeric3 = "GBR", IsoNumeric = "826", TelephoneCode = "44", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "UNITED KINGDOM" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "US", AlphaNumeric3 = "USA", IsoNumeric = "840", TelephoneCode = "1", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "UNITED STATES" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "UM", AlphaNumeric3 = "UMI", IsoNumeric = "581", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "UNITED STATES MINOR OUTLYING ISLANDS" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "UY", AlphaNumeric3 = "URY", IsoNumeric = "858", TelephoneCode = "598", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "URUGUAY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "UZ", AlphaNumeric3 = "UZB", IsoNumeric = "860", TelephoneCode = "998", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "UZBEKISTAN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "VU", AlphaNumeric3 = "VUT", IsoNumeric = "548", TelephoneCode = "678", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "VANUATU" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "VA", AlphaNumeric3 = "VAT", IsoNumeric = "336", TelephoneCode = "379", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "VATICAN CITY" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "VE", AlphaNumeric3 = "VEN", IsoNumeric = "862", TelephoneCode = "58", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "VENEZUELA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "VN", AlphaNumeric3 = "VNM", IsoNumeric = "704", TelephoneCode = "84", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "VIET NAM" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "VG", AlphaNumeric3 = "VGB", IsoNumeric = "92", TelephoneCode = "1-284", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "VIRGIN ISLANDS, BRITISH" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "VI", AlphaNumeric3 = "VIR", IsoNumeric = "850", TelephoneCode = "1-340", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "VIRGIN ISLANDS, U.S." } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "WF", AlphaNumeric3 = "WLF", IsoNumeric = "876", TelephoneCode = "681", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "WALLIS AND FUTUNA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "EH", AlphaNumeric3 = "ESH", IsoNumeric = "732", TelephoneCode = "", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "WESTERN SAHARA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "YE", AlphaNumeric3 = "YEM", IsoNumeric = "887", TelephoneCode = "967", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "YEMEN" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ZM", AlphaNumeric3 = "ZMB", IsoNumeric = "894", TelephoneCode = "260", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ZAMBIA" } } });
            this.context.Countries.Add(new Country { AlphaNumeric2 = "ZW", AlphaNumeric3 = "ZWE", IsoNumeric = "716", TelephoneCode = "263", Localised = new List<CountryLocalised> { new CountryLocalised { Language = "en", Name = "ZIMBABWE" } } });
        }

        private void LoadLanguages()
        {
            this.context.Languages.Add(new Language
            {
                Code = "en",
                DefaultLocale = "en-GB",
                Name = "English",
                IsLive = true,
                IsRightToLeft = false
            });

            this.context.Languages.Add(new Language
            {
                Code = "ar",
                DefaultLocale = "ar-AE",
                Name = "Arabic",
                IsLive = true,
                IsRightToLeft = true
            });

            this.context.Languages.Add(new Language
            {
                Code = "ru",
                DefaultLocale = "ru-RU",
                Name = "Russian",
                IsLive = true,
                IsRightToLeft = false
            });
        }

        private void LoadMembers()
        {
            var seed = StringUtility.GeneratePassword(8);
            var hash = (seed + "splendid").StringToByteArray().MD5().ToHexString();

            var admin = new Member
            {
                UserName = "admin",
                PasswordSeed = seed,
                PasswordHash = hash,
                Roles = new HashSet<Role>()
            };

            var editor = new Member
            {
                UserName = "editor",
                PasswordSeed = seed,
                PasswordHash = hash,
                Roles = new HashSet<Role>()
            };

            var approver = new Member
            {
                UserName = "approver",
                PasswordSeed = seed,
                PasswordHash = hash,
                Roles = new HashSet<Role>()
            };

            var publisher = new Member
            {
                UserName = "publisher",
                PasswordSeed = seed,
                PasswordHash = hash,
                Roles = new HashSet<Role>()
            };

            this.context.Members.Add(admin);
            this.context.Members.Add(editor);
            this.context.Members.Add(approver);
            this.context.Members.Add(publisher);

            EnsureRoles(admin, editor, approver, publisher);
        }

        private void LoadDestinationCategories()
        {
            this.context.DestinationCategories.Add(new DestinationCategory { Name = "Beach" });
            this.context.DestinationCategories.Add(new DestinationCategory { Name = "Culture" });
            this.context.DestinationCategories.Add(new DestinationCategory { Name = "Family" });
            this.context.DestinationCategories.Add(new DestinationCategory { Name = "Nightlife" });
            this.context.DestinationCategories.Add(new DestinationCategory { Name = "Romantic" });
            this.context.DestinationCategories.Add(new DestinationCategory { Name = "Sports" });
        }

        private void EnsureRoles(Member admin, Member editor, Member approver, Member publisher)
        {
            foreach (var p in typeof(MemberRole).GetFields().Where(x => x.IsLiteral && !x.IsInitOnly))
            {
                var roleName = p.GetRawConstantValue() as string;

                if (!string.IsNullOrEmpty(roleName))
                {
                    var role = new Role() { Name = roleName };
                    this.context.Roles.Add(role);
                    admin.Roles.Add(role);

                    if (roleName.Contains("Editor"))
                    {
                        editor.Roles.Add(role);
                        approver.Roles.Add(role);
                        publisher.Roles.Add(role);
                    }
                    else if (roleName.Contains("Approver"))
                    {
                        approver.Roles.Add(role);
                        publisher.Roles.Add(role);
                    }
                    else if (roleName.Contains("Publisher"))
                    {
                        publisher.Roles.Add(role);
                    }
                }
            }
        }


        private void LoadCodeTypes()
        {
            var fares = new CodeTypeCategory { CodeTypeCategoryId = (int)Enums.CodeTypeCategory.Fares, Name = "Fares" };
            var taxes = new CodeTypeCategory { CodeTypeCategoryId = (int)Enums.CodeTypeCategory.Taxes, Name = "Taxes" };
            var baggageAllowance = new CodeTypeCategory { CodeTypeCategoryId = (int)Enums.CodeTypeCategory.BaggageAllowance, Name = "Baggage Allowance" };
            var baggageUpgrade = new CodeTypeCategory { CodeTypeCategoryId = (int)Enums.CodeTypeCategory.BaggageUpgrade, Name = "Baggage Upgrade" };
            var seating = new CodeTypeCategory { CodeTypeCategoryId = (int)Enums.CodeTypeCategory.Seating, Name = "Seating" };
            var insurance = new CodeTypeCategory { CodeTypeCategoryId = (int)Enums.CodeTypeCategory.Insurance, Name = "Insurance" };
            var penalty = new CodeTypeCategory { CodeTypeCategoryId = (int)Enums.CodeTypeCategory.Penalty, Name = "Penalty" };
            var paymentFee = new CodeTypeCategory { CodeTypeCategoryId = (int)Enums.CodeTypeCategory.Penalty, Name = "Payment Fee" };
            var wheelchair = new CodeTypeCategory { CodeTypeCategoryId = (int)Enums.CodeTypeCategory.Wheelchair, Name = "Other" };

            this.context.CodeTypeCategories.Add(fares);
            this.context.CodeTypeCategories.Add(taxes);
            this.context.CodeTypeCategories.Add(baggageAllowance);
            this.context.CodeTypeCategories.Add(baggageUpgrade);
            this.context.CodeTypeCategories.Add(seating);
            this.context.CodeTypeCategories.Add(wheelchair);

            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = fares, CodeTypeId = "AIR", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Air" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = fares, CodeTypeId = "FUEL", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Fuel" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = taxes, CodeTypeId = "TAX", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Tax" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = baggageAllowance, CodeTypeId = "BAGB", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "20 kg Baggage Allowance" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = baggageAllowance, CodeTypeId = "BAGL", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "30 Kg Baggage Allowance" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = baggageAllowance, CodeTypeId = "BAGX", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "40 kg Baggage Allowance" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = baggageUpgrade, CodeTypeId = "BUPL", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "10 kg Baggage Upgrade" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = baggageUpgrade, CodeTypeId = "BUPX", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "20 kg Baggage Upgrade" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = baggageUpgrade, CodeTypeId = "BUPZ", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "10 kg Baggage Upgrade" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = seating, CodeTypeId = "FRST", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Front Row Seat Selection" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = seating, CodeTypeId = "NSST", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Advanced Seat Selection" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = seating, CodeTypeId = "SPST", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Special Seat Selection" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = seating, CodeTypeId = "XLGR", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Extra Leg Room Seat" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = insurance, CodeTypeId = "INSU", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Insurance" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = penalty, CodeTypeId = "PNLT", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Penalty" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = paymentFee, CodeTypeId = "PMNT", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Payment Fee" } } });
            this.context.CodeTypes.Add(new CodeType { CodeTypeCategory = wheelchair, CodeTypeId = "WCHR", Localised = new List<CodeTypeLocalised> { new CodeTypeLocalised { Language = "en", Name = "Wheelchair" } } });
        }
    }
}