namespace flydubai.Model.Labels
{
    using System.ComponentModel;

    /// <summary>
    /// Optional Extras Labels
    /// </summary>
    public class OptionalExtrasLabels : BaseLabels
    {
        public string Baggage { get; set; }

        public string NeedExtraBaggageAllowance { get; set; }

        public string NeedExtraBaggageAllowanceDescription { get; set; }

        public string PrimaryPassenger { get; set; }

        public string Adult { get; set; }

        public string Child { get; set; }

        public string Infant { get; set; }

        public string To { get; set; }

        public string Plus { get; set; }

        public string Stop { get; set; }

        public string With { get; set; }
        
        public string FlightNumber { get; set; }

        public string On { get; set; }

		public string Kg { get; set; }

        public string Included { get; set; }
        
        public string AllFlights { get; set; }

        public string DifferentAllowanceForEachFlight { get; set; }

        public string InfantsNotHaveBaggageAssigned { get; set; }

        public string Seating { get; set; }

        public string WhereToSit { get; set; }

        public string WhereToSitDescription { get; set; }

        public string IfYouRequireSpecialAssistance { get; set; }

        public string HowManyPeopleRequireWheelchairAccess { get; set; }

        public string WhichPassengersRequireWheelchairAccess { get; set; }

        public string Outbound { get; set; }

        public string SelectYourSeats { get; set; }
        
        public string WhichPassengerAreYouSelectingASeatFor { get; set; }

        public string IfYouDecideNotToSelectASeat { get; set; }

        public string Surcharge { get; set; }

        public string Seat { get; set; }

        public string WheelchairAccessRequired { get; set; }

        public string SeatNumber { get; set; }

        public string Cost { get; set; }

        public string AssignedTo { get; set; }

        public string IfYouNeedAnExtraSeat { get; set; }

        public string StartAgain { get; set; }

        public string SeatSelectionNotAvailable { get; set; }

        public string Return { get; set; }
        
        public string Insurance { get; set; }

        public string SelectYourInsurance { get; set; }

        public string TheConditionsOfInsuranceAre { get; set; }

        public string FirstInsuranceCondition { get; set; }

        public string SecondInsuranceCondition { get; set; }

        public string ThirdInsuranceCondition { get; set; }

        public string AddInsuranceForAllPassengers { get; set; }

        public string AddInsuranceForAllPassengersBenefits { get; set; }

        public string NoInsurance { get; set; }

        public string Total { get; set; }

        public string ViewFullPolicyDetails { get; set; }

        public string ViewFullPolicyDetailsLinkUrl { get; set; }

        public string InsurancePolicyDetailsUrl { get; set; }

        public string NotAssigned { get; set; }

        public string Close { get; set; }

        public string SaveHassleAtTheAirport { get; set; }

        public string YouHaventSelectedBaggageAllowance { get; set; }

        public string ToAddCheckedBaggageSelectBelow { get; set; }

        public string Continue { get; set; }

        public string CloseSeatSelection { get; set; }

        public string Unavailable { get; set; }

        public string SorryItsNotPossibleToBookThisSeat { get; set; }

        public string ThisIsARestrictedSeat { get; set; }

        public string MoreThanOneAdultWithInfantPerRow { get; set; }

        public string ChangeSeatSelection { get; set; }

        public string SeatsSelected { get; set; }

        public string Of { get; set; }

        public string None { get; set; }

        public string Only { get; set; }

        public string BagsLeftAt { get; set; }

        public string UnfortunatelyOneOrMoreSeatsIsNoLongerAvailable { get; set; }

        public string EitherContinueWithoutSeatsOrSelectAlterntative { get; set; }

        public string OtherMembersOfYourPartyAreInTheFollowingSeats { get; set; }

        public string SorryThisSeatIsAlreadyTaken { get; set; }

        public string AdditionalInformation { get; set; }

        public string ExtraLegRoomSeat { get; set; }

        public string FrontRowSeat { get; set; }

        public string SpecialSeat { get; set; }

        public string AdvancedSeat { get; set; }

        public string YourSelection { get; set; }

        public string Occupied { get; set; }

        public string Available { get; set; }

        public string WheelchairAccess { get; set; }

        public string RestrictedSeating { get; set; }

        public string EmergencyExitSeat { get; set; }

        public string YesKeepThisSeat { get; set; }

        public string NoSelectOtherSeat { get; set; }

        public string ThereHasBeenAnError { get; set; }

        public string YouNeedToFillInEachPassengersSeatingInformation { get; set; }

        public string CompleteSeatingInformation { get; set; }

        [DefaultValue("Optional Extras")]
        public string ModalUpsellTitle { get; set; }

        [DefaultValue("Taking extra baggage?")]
        public string ModalBaggageUpsellTitle { get; set; }

        [DefaultValue("Previously selected baggage not available")]
        public string UnavailableOnReaccomodation { get; set; }

        [DefaultValue("You only have {0}kg hand luggage. It's cheaper to purchase extra baggage allowance online.")]
        [DisplayName("Text to encourage the user to upgrade their baggage.  {0}kg is replaced by the current weight (example: '{0}kg' becomes '7kg')")]
        public string ModalBaggageUpsellEncouragementText { get; set; }

        [DefaultValue("Add Baggage")]
        public string ModalAddBaggageButtonText { get; set; }

        [DefaultValue("Insure your trip for peace of mind?")]
        public string ModalInsuranceUpsellTitle { get; set; }

        [DefaultValue("It's important to have insurance for your trip to help with unforeseen, such as missed departure, cancellation, medical expenses and personal belongings.")]
        [DisplayName("Text to encourage the user to upgrade their insurance.")]
        public string ModalInsuranceUpsellEncouragementText { get; set; }

        [DefaultValue("Add Insurance")]
        public string ModalAddInsuranceButtonText { get; set; }

        [DefaultValue("No Thanks")]
        public string ModalNoThanksButtonText { get; set; }

        [DefaultValue("No thanks {0}kg hand baggage is fine")]
        [DisplayName("No extra baggage drop down option (use {0} for the hand baggage weight) (e.g. No thanks {0}kg hand baggage is fine)")]
        public string NoExtraBaggageDropDownOption { get; set; }

        [DefaultValue("{0}kg hand baggage plus {1}kg included checked baggage allowance")]
        [DisplayName("Included extra baggage drop down option (use {0} for the hand baggage weight, {1} for checked baggage weight) (e.g. {0}kg hand baggage plus {1}kg included checked baggage allowance)")]
        public string IncludedExtraBaggageDropDownOption { get; set; }

        [DefaultValue("{0} kg hand baggage plus {1} kg {2} pcs included checked baggage allowance")]
        [DisplayName("Included extra baggage drop down option (use {0} for the hand baggage weight, {1} for checked baggage weight, {2} for no of units/pieces) (e.g. {0}kg hand baggage plus {1}kg {2} pcs included checked baggage allowance)")]
        public string IncludedExtraBaggageDropDownOptionWithPieces { get; set; }

        [DefaultValue("Add {0}kg checked baggage ({1}kg) total {2}")]
        [DisplayName("Add extra baggage drop down option (use {0} for the additional weight, {1} for the total weight, {2} for the total cost) (e.g. Add {0}kg checked baggage ({1}kg) total {2})")]
        public string AddExtraBaggageDropDownOption { get; set; }

        //IBS  A-5466 Platinum change start
        [DefaultValue("Vegetarian oriental meal")]
        [DisplayName("Vegetarian Meal")]
        public string VegetarianMeal { get; set; }
        
        [DefaultValue("No Dietary Requirements")]
        [DisplayName("Included Meal")]
        public string NoDietary { get; set; }

        [DefaultValue("Meal")]
        [DisplayName("Meal Heading")]
        public string Meal { get; set; }

        [DefaultValue("Dietary requirements")]
        [DisplayName("Dietary requirement")]
        public string DietaryRequirement { get; set; }

        public string InfantsNotHaveMeal { get; set; }

        public string MealDescription { get; set; }

        public string MealDefault { get; set; }

        public string Economy { get; set; }

        public string Business { get; set; }

        public string IFEBusinessMessage { get; set; }

        public string BuyMealOnBoard { get; set; }

        public string MealHeading { get; set; }

        //IBS  A-5466 Platinum change End here
        public string SorryNotPossibleToAssignWheelchairAccess { get; set; }

        public string TheSelectedPassengerHasInfantAssignedAndIsNotPossibleToAssignAWheelchairAccessPleaseChooseAnotherPassenger { get; set; }

        public string InFlightEntertainment { get; set; }

        public string WantInflightEntertainment { get; set; }

        public string WantInflightEntertainmentDescription { get; set; }

        public string NoInFlightEntertainment { get; set; }

        public string InFlightEntertainmentPackageDescription { get; set; }

        public string DifferentIFEForEachFlight { get; set; }

        public string InfantsNotHaveIFEAssigned { get; set; }

        public string IFEUnavailableOnThisFlight { get; set; }

        public string IFENotForSaleOnThisFlight { get; set; }

        public string ViewThisMonthMovies { get; set; }

        public string BusinessBaggageHeadding { get; set; }

        public string BusinessBaggageDescription { get; set; }

        public string BusinessIfeHeadding { get; set; }

        public string BusinessIfeDescription { get; set; }

        public string MixedBaggageHeadding { get; set; }

        public string MixedBaggageDescription { get; set; }

        public string MixedIfeHeadding { get; set; }

        public string MixedIfeDescription { get; set; }

        public string WhereToSitDescriptionBusiness { get; set; }

        public string WhereToSitDescriptionMixed { get; set; }

        public string InfantsNotHaveTASSRAssigned { get; set; }     //For infant message for TA specific SSR
        //Pre-Sell meals A-5466
        public string OutboundFlight { get; set; }
        public string Menu { get; set; }
        public string Price { get; set; }
        public string ReturnFlight { get; set; }
        public string BuyMealForThisJourney { get; set; }
        public string Remove { get; set; }
        public string SelectYourMeal { get; set; }
        public string SnacksAndRefreshmentsOnBoard { get; set; }
        public string NeedSomethingToEat { get; set; }
        public string MealsLimited { get; set; }
        public string AddMeals { get; set; }
        public string ChangeMeal { get; set; }
        public string SelectMeal { get; set; }
        public string ClearAllMeal { get; set; }
        public string CannotModifyMeal { get; set; }

        //WR-2 A-5453
        public string IFEUpsellHeading { get; set; }
        public string IFEUpsellDescription { get; set; }
        public string IFEUpsellButtonText { get; set; }
        public string IFEHintHeader { get; set; }
        public string IFEHintContent { get; set; }

        public string AddBaggageHint { get; set; }
        public string AddInsuranceHint { get; set; }
        public string ChangeMealHint { get; set; }
        public string AddBaggageHintHeader { get; set; }
        public string AddInsuranceHintHeader { get; set; }
        public string ChangeMealHintHeader { get; set; }
        //WR9:A-4740: Pre-select insurance: Start
        public string ProtectYourselfOnYourTrip { get; set; }
        public string PreselectInsuranceMessage { get; set; }
        public string PreselectInsuranceMessageTA { get; set; }
        //WR9:A-4740: Pre-select insurance: End
        //FLX Changes M-1053
        public string ClickHereToViewSeatOptions { get; set; }
        public string MealsIncluded { get; set; }
        public string StandardMeals { get; set; }

        public string ModifyMealExtraContactCallCenter { get; set; }
        public string ModifyIFEExtraContactCallCenter { get; set; }

        public string OperatedBy { get; set; }
        public string GdsMealSelectionMessageForOtherCarriers { get; set; }
        public string GdsIFESelectionMessageForOtherCarriers { get; set; }
        public string GdsSeatSelectionMessageForOtherCarriers { get; set; }
        public string OnFlight { get; set; }
        public string EKTerminalName { get; set; }

        //Interline changes
        public string SnacksAndRefreshmentsInterline { get; set; }
        public string IFEUnavailableInterline { get; set; }
        public string SeatsInterline { get; set; }

        //IROPS
        public string BaggageDroppedOnReaccomodation { get; set; }
        public string MealDroppedOnReaccomodation { get; set; }
        public string IfeDroppedOnReaccomodation { get; set; }
        public string SeatDroppedOnReaccomodation { get; set; }
        public string InsuranceDroppedOnReaccomodation { get; set; }
        public string SSRDropPopupTitle { get; set; }
        public string SSRMealsDropHeader { get; set; }
        public string SSRIFEDropHeader { get; set; }
        public string SSRSeatsDropHeader { get; set; }
        public string ReaccomodationAcceptmessage { get; set; }
        public string SSRInsuranceDropHeader { get; set; }
        public string SSRSeatNumberDropHeader { get; set; }
        public string SeatNumberDroppedOnReaccomodation { get; set; }
        
    }
}
