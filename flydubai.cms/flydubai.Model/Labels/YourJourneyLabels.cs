namespace flydubai.Model.Labels
{
    using System.ComponentModel;

    /// <summary>
    /// Your Journey Labels
    /// </summary>
    public class YourJourneyLabels : BaseLabels
    {
        public string YourJourney { get; set; }

        public string To { get; set; }

        public string Departs { get; set; }

        public string Arrives { get; set; }

        public string Day { get; set; }

        public string Days { get; set; }

        public string Duration { get; set; }

        public string PayToChangeFare { get; set; }

        public string FreeToChangeFare { get; set; }

        // a-5466 fare upsell business start
        public string BusinessFare { get; set; }

        public string Cabin { get; set; }

        public string BasicFare { get; set; }

        public string Economy { get; set; }

        public string Business { get; set; }

        public string HotMealAndDrinks { get; set; }

        // a-5466 fare upsell business End here

        public string NoChangeFare { get; set; }

        public string Adult { get; set; }

        public string Child { get; set; }

        public string Infant { get; set; }

        public string Adults { get; set; }

        public string Children { get; set; }

        public string Infants { get; set; }

        public string Continue { get; set; }

        public string Hr { get; set; }
        
        public string Hrs { get; set; }

        public string Min { get; set; }

        public string Mins { get; set; }

        public string Kg { get; set; }

        public string HandBaggage { get; set; }

        public string CheckedBaggage { get; set; }

        public string Free { get; set; }

        public string Added { get; set; }

        public string TaxesAndCharges { get; set; }

        public string Sector { get; set; }
        
        public string ViewFullBreakdown { get; set; }

        public string Discounts { get; set; }

        public string PromoCode { get; set; }

        public string Total { get; set; }

        public string Under2Years { get; set; }

        public string InclusiveOfAllTaxes { get; set; }

        public string Included { get; set; }
        
        public string Wheelchair { get; set; }
        
        public string SeatAssignment { get; set; }

        public string Stops { get; set; }
        
        public string Insurance { get; set; }

        public string SelectFLightToContimue { get; set; }

        public string Passengers { get; set; }

        public string EditPassengerNames { get; set; }

        public string Seats { get; set; }

        public string AllPassengersOnAllYourJourneysAreCovered { get; set; }

        public string Wheelchairs { get; set; }

        public string Fees { get; set; }

        public string CreditDebitCard { get; set; }

        public string ViewSummary { get; set; }

        public string ArrivalNextDayTooltip { get; set; }

        public string PayToChangeFareTooltip { get; set; }

        public string FreeToChangeFareTooltip { get; set; }

        public string NoChangeFareTooltip { get; set; }

        public string ArrivalNextDay { get; set; }

        public string WaitingTime { get; set; }

        public string WhatsIncluded { get; set; }

        public string WhyNotUpgradeForUltimateFlexibility { get; set; }

        public string FlightNo { get; set; }

        public string Departing { get; set; }

        public string Arrival { get; set; }

        public string CurrentFare { get; set; }

        public string UpgradeYourFareType { get; set; }

        public string NoUpgradesAvailable { get; set; }

        public string AdditionalBenefitsForFlexibleTickets { get; set; }

        /// <summary>
        /// this should be prepended to the 'TermsAndConditions' link 
        /// </summary>
        [DisplayName("IHaveReadAndAcceptFlydubais  (Note: this will be combined with the 'TermsAndConditions' link text value)")]
        [DefaultValue("I have read and accept Flydubai's")]
        public string IHaveReadAndAcceptFlydubais { get; set; }

        /// <summary>
        /// this should be prefixed by the 'IHaveReadAndAcceptFlydubais' label value
        /// </summary>
        [DisplayName("TermsAndConditions link text (Note: this will be prefixed by the 'IHaveReadAndAcceptFlydubais' label value)")]
        [DefaultValue("Terms and conditions")]
        public string TermsAndConditions { get; set; }

        [DisplayName("Terms And Conditions link Url")]
        public string TermsAndConditionsLinkUrl { get; set; }
        
        public string Extra { get; set; }

        public string UpgradeOptions { get; set; }

        public string LocalTime { get; set; }

        public string NoUpgradeRequired { get; set; }

        public string ScrollToReviewYourSummaryAndContinueWithYourBooking { get; set; }

        public string InFlightEntertainment { get; set; }

        public string PurchasedInFlightEntertainment { get; set; }

        public string BusinessMealTooltip { get; set; }

        //Y class meal
        public string MealsIncluded { get; set; }

        //COmpanion fares
        public string CompanionOfferHeading { get; set; }

        public string Special { get; set; }

        public string FareRulesLinkText { get; set; }

        public string ApplyToThisBooking { get; set; }

        //Interline changes
        public string TwoPieceBaggage { get; set; }

        public string ThreePieceBaggage { get; set; }

        public string BSPfee { get; set; }

        public string InfantHandBaggage { get; set; }

        public string InfantCheckedBaggage { get; set; }
    }
}
