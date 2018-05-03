using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Results Labels
    /// </summary>
    public class ResultsLabels : BaseLabels
    {
        public string ViewingOptions { get; set; }

        public string Currency { get; set; }

        public string ChangeCurrency { get; set; }

        public string FareType { get; set; }

        public string Go { get; set; }

        public string OneDayView { get; set; }

        public string ThreeDayView { get; set; }

        public string MonthView { get; set; }

        public string To { get; set; }

        public string On { get; set; }

        public string Passengers { get; set; }

        public string Adults { get; set; }

        public string Children { get; set; }

        public string Infants { get; set; }

        public string SearchAgain { get; set; }

        public string Journey { get; set; }

        public string LowestFaresAvailable { get; set; }

        public string NoChangeFaresOnly { get; set; }

        public string PayToChangeFaresOnly { get; set; }

        public string FreeToChangeFaresOnly { get; set; }

        public string PromoFaresOnly { get; set; }

        public string IAmFlyingFrom { get; set; }

        public string TwelvePlus { get; set; }

        public string TwoTo12 { get; set; }

        public string Under2 { get; set; }

        public string Under2Tooltip { get; set; }

        public string ShowFlights { get; set; }

        public string SorryThereWasAProblemWithYourSearch { get; set; }

        public string PleaseCheckAndTryAgain { get; set; }

        public string InfantPassengers { get; set; }

        public string Arriving { get; set; }

        public string Stop { get; set; }

        public string SeatsLeft { get; set; }

        public string PerPerson { get; set; }

        public string Departing { get; set; }

        public string MoreInfo { get; set; }

        public string LoadingResults { get; set; }

        public string PleaseWait { get; set; }

        public string Loading { get; set; }

        public string Sort { get; set; }

        public string Prev { get; set; }

        public string Next { get; set; }

        public string PleaseSelectAFlightFromTheList { get; set; }

        public string AddedToBooking { get; set; }

        public string Added { get; set; }

        public string LessInfo { get; set; }

        public string LoadingImageUrl { get; set; }

        public string MultipleAirportsMessage { get; set; }

        public string ClearAll { get; set; }

        [DisplayName("[TA] Companion Disclaimer Message")]
        public string CompanionDisclaimerMessage { get; set; }

        [DisplayName("[TA] Loading Revised Fares Pop")]
        public string LoadingRevisedFaresPop { get; set; }

        public string Flight { get; set; }

        public string Edit { get; set; }

        public string FlightNo { get; set; }

        public string Fares { get; set; }

        public string Select { get; set; }

        public string SortBy { get; set; }

        public string JourneyTime { get; set; }

        public string DepartureTime { get; set; }

        public string Stops { get; set; }

        public string ArrivalTime { get; set; }

        public string FlightDetails { get; set; }

        public string AllTimesAreLocal { get; set; }

        public string Duration { get; set; }

        public string Connection { get; set; }

        public string NonStop { get; set; }

        public string ContinueToSelectFare { get; set; }

        public string NoFlightsMessage { get; set; }
    }
}
