using System.ComponentModel;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Flight Search Labels
    /// </summary>
    [DisplayName("Flight Search Labels (deprecated labels replaced by FlightSearchTabLabels & FlightSearchNarrowTabLabels)")]
    public class FlightSearchLabels : BaseLabels
    {
        [DisplayName("(Deprecated - For Reference Only) For Special Needs Minors Pets Policy")]
        public string ForSpecialNeedsMinorsPetsPolicy { get; set; }

        public string PleaseCheckTheseDetailsAreCorrect { get; set; }

        public string FlightSearch { get; set; }

        public string ManageBooking { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Roundtrip")]
        public string Roundtrip { get; set; }

        [DisplayName("(Deprecated - For Reference Only) One Way")]
        public string OneWay { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Flying From")]
        public string FlyingFrom { get; set; }

        [DisplayName("(Deprecated - For Reference Only) From")]
        public string From { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Flying To")]
        public string FlyingTo { get; set; }

        [DisplayName("(Deprecated - For Reference Only) To")]
        public string To { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Add Multiple Destinations")]
        public string AddMultipleDestinations { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Flying Out On")]
        public string FlyingOutOn { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Flying Back On")]
        public string FlyingBackOn { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Flexible On Dates")]
        public string FlexibleOnDates { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Passengers")]
        public string Passengers { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Adults")]
        public string Adults { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Children")]
        public string Children { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Infants")]
        public string Infants { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Make Booking Of 9 Or More")]
        public string MakeBookingOf9OrMore { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Promotional Code")]
        public string PromotionalCode { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Promotional Code Tooltip")]
        public string PromotionalCodeTooltip { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Show Flights")]
        public string ShowFlights { get; set; }

        [DisplayName("(Deprecated - For Reference Only) See FAQ")]
        public string SeeFAQ { get; set; }

        public string MultipleDestinations { get; set; }

        public string BackToStandardFlightBooking { get; set; }

        [DisplayName("(Deprecated - For Reference Only) I Am Flying From")]
        public string IAmFlyingFrom { get; set; }

        [DisplayName("(Deprecated - For Reference Only) I Am Flying To")]
        public string IAmFlyingTo { get; set; }

        [DisplayName("(Deprecated - For Reference Only) I Am Flying Out On")]
        public string IAmFlyingOutOn { get; set; }

        public string RemoveFlight { get; set; }

        public string AddFlight { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Twelve Plus")]
        public string TwelvePlus { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Two to 12")]
        public string Twoto12 { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Under 2")]
        public string Under2 { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Under 2 Tooltip")]
        public string Under2Tooltip { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Want To Make Booking Of 9 Or More")]
        public string WantToMakeBookingOf9OrMore { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Want To Make Booking Of 9 O rMore Tooltip")]
        public string WantToMakeBookingOf9OrMoreTooltip { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Find Out Here")]
        public string FindOutHere { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Do You Have Promotional Code")]
        public string DoYouHavePromotionalCode { get; set; }

        public string OnlyOneCodeCanBeUsed { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Enter Your Promotional Code")]
        public string EnterYourPromotionalCode { get; set; }

        public string PleaseSelectOriginAirport { get; set; }

        public string DohopConnectionSearch { get; set; }

        public string TheDohopConnectionSearch { get; set; }

        public string DohopContentCopy { get; set; }

        public string ReadMore { get; set; }

        public string ConnectionSearch { get; set; }

        public string dohop { get; set; }

        public string PleaseWaitWhileWeCheckForLowest { get; set; }

        public string LoadingResults { get; set; }

        public string AMaximumOf { get; set; }

        public string TenFlights { get; set; }

        public string CanBeBookedInOneTransaction { get; set; }

        public string NoAirportsFound { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Promo Placeholder")]
        public string PromoPlaceholder { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Promotion Code")]
        public string PromotionCode { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Group Bookings Email")]
        public string GroupBookingsEmail { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Email")]
        public string Email { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Group Bookings Telephone Number")]
        public string GroupBookingsTelephoneNumber { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Call")]
        public string Call { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Group Bookings")]
        public string GroupBookings { get; set; }

        [DisplayName("(Deprecated - For Reference Only) Infant Passengers")]
        public string InfantPassengers { get; set; }

        public string MakeABooking { get; set; }

        public string PleaseTrySearchAgain { get; set; }

        //FZWR-399 A-5851 WR6
        public string TroubleWithChangeDateRadixxUnknowError { get; set; }
        //FZWR-399 A-5851 WR6

        public string NumberOfFlights { get; set; }
    }
}
