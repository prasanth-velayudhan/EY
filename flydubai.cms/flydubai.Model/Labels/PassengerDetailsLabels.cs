namespace flydubai.Model.Labels
{
    using System.ComponentModel;

    /// <summary>
    /// Passenger Details Labels
    /// </summary>
    public class PassengerDetailsLabels : BaseLabels
    {
        public string DateOfBirthIsInvalid { get; set; }

        public string InfantIsNotAssignedToAnAdult { get; set; }

        public string AdultHasMoreThanOnInfantAssigned { get; set; }

        public string AreaCode { get; set; }

        public string Number { get; set; }

        public string PleaseCheckTheseDetailsAreCorrect { get; set; }

        public string ImNewToFlydubai { get; set; }

        public string IHaveAFlydubaiAccount { get; set; }

        public string FieldsMarked { get; set; }

        public string AreMandatory { get; set; }

        public string AssignInfantTo { get; set; }

        public string Email { get; set; }

        public string HomeNumber { get; set; }

        public string MobileNumber { get; set; }

        public string WhyAreWeAskingForTheseNumbers { get; set; }
        
        public string WhyAreWeAskingForTheseNumbersTooltip { get; set; }

        public string PreferedContactNumber { get; set; }

        public string CountryCodeForOtherPhone { get; set; }

        public string IWouldLikeToCreateAnAccount { get; set; }

        public string Password { get; set; }

        public string PasswordTooltip { get; set; }

        public string PasswordTooltipHeading { get; set; }

        public string ConfirmPassword { get; set; }

        public string IWouldLikeToSubscribeToFlydubaiOffers { get; set; }

        public string SubscribeMeToFlydubaiOffers { get; set; }

        public string IWantToReceiveOffersIn { get; set; }

        public string OffersFrom { get; set; }

        public string ViaSMS { get; set; }

        public string ViaEmail { get; set; }

        public string English { get; set; }

        public string Arabic { get; set; }

        public string AllCountries { get; set; }

        public string ShowOptions { get; set; }

        public string SameAs { get; set; }

        public string Mobile { get; set; }

        public string Home { get; set; }

        public string Other { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AdultPassenger { get; set; }

        public string ChildPassenger { get; set; }

        public string InfantPassenger { get; set; }

        public string PrimaryPassenger { get; set; }

        public string DateOfBirth { get; set; }

        public string Yyyy { get; set; }

        public string Mm { get; set; }

        public string Dd { get; set; }

        public string Select { get; set; }

        public string EnterFirstName { get; set; }

        public string EnterLastName { get; set; }

        public string EnterMiddleName { get; set; }

        public string EnterEmail { get; set; }

        public string CountryCode { get; set; }

        public string EnterPassword { get; set; }

        public string HideOptions { get; set; }

        public string TelephoneNumbers { get; set; }

        [DisplayName("AdultTitles: comma separated list of adult titles.  e.g. Mr,Mrs,Ms,Miss (please always enter in English)")]
        public string AdultTitles { get; set; }

        [DisplayName("ChildTitles: comma separated list of child/infant titles.  e.g. Mstr,Miss (please always enter in English)")]
        public string ChildTitles { get; set; }

        public string MiddleName { get; set; }

        public string AdvancedPassengerInformation { get; set; }

        public string PleaseSelect { get; set; }

        public string PassportNumber { get; set; }

        public string InvalidPassportNumber { get; set; }

        public string IssuingCountry { get; set; }

        public string Nationality { get; set; }

        public string ExpiryDate { get; set; }

        public string Month { get; set; }

        public string Year { get; set; }

        public string TheExpiryDateCannotBeInThePast { get; set; }

        public string Male { get; set; }

        public string Female { get; set; }

        public string IConfirmThatTheTravelDocumentInformationProvidedAboveIsCorrect { get; set; }

        public string SaveChanges { get; set; }

        public string CancelChanges { get; set; }

        public string Gender { get; set; }

        public string AddBaggage { get; set; }

        public string AddSeat { get; set; }

        public string NoInsurance { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string MobileContactNumber { get; set; }

        [DefaultValue("Additional information is required for your flight, you can save time at the airport by entering it here")]
        public string AdditionalInformationIsRequiredForYourFlightYouCanSaveTimeByEnteringItHere { get; set; }

        public string Passenger { get; set; }

        public string Selection { get; set; }

        public string Remove { get; set; }

        public string Adult { get; set; }

        public string Child { get; set; }

        public string Continue { get; set; }

        [DefaultValue("Note: If you are already a subscriber, leave these details blank if you do not want to update you existing suscription details.")]
        public string WarningTextForExistingSpecialOffersSubscribers { get; set; }

        public string InFlightEntertainment { get; set; }

        public string AddInFlightEntertainment { get; set; }

        public string Russian { get; set; }

        public string AddMeal { get; set; }

        public string APISTooltipContent { get; set; }

        public string MakeChangesToTheCompleteAdvancedPassengerInformation { get; set; }

        // A-5469: WR3 : FR:011
        public string Country { get; set; }

        //WR8:FZWR-682:A-4740:Passenger contact details - Phone number field not mandatory
        public string PassengerContactDetails { get; set; }

        // FFP Modify Flow
        public string EnterFFPNum { get; set; }

        public string FFPNum { get; set; }

        public string InvalidFFNum { get; set; }

        public string AddFFPNum { get; set; }

        public string Add { get; set; }

        public string Cancel { get; set; }

        public string AlreadyUsedFFNum { get; set; }

        public string NotAdultFFPNum { get; set; }

        public string NotChildFFPNum { get; set; }

        public string FullNameLong { get; set; }
        


        //GST changes
        public string Gstnumber { get; set; }
        public string GstCompanyName { get; set; }
        public string GSTDateOfIssue { get; set; }
        public string GSTAddress1 { get; set; }
        public string GSTAddress2 { get; set; }
        public string GSTCity { get; set; }
        public string GSTState { get; set; }
        public string GSTPincode { get; set; }
        public string GSTComapnyMail { get; set; }
        public string GSTCompanycontactnumber { get; set; }
        public string ApplyGSTForAll { get; set; }
        public string GSTSubHeading { get; set; }
        public string GSTHeading { get; set; }
        public string GSTType { get; set; }
        public string GSTErrorPleaseFillOne { get; set; }
        public string GSTErrorInvalidEmail { get; set; }
        public string GSTErrorGSTNumberRange { get; set; }
        public string GSTErrorInvalidDateOfIssue { get; set; }
    }
}
