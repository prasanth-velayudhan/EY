using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    public interface IResultLabels
    {
        string ViewingOptions { get; set; }

        string Currency { get; set; }

        string ChangeCurrency { get; set; }

        string FareType { get; set; }

        string Go { get; set; }

        string OneDayView { get; set; }

        string ThreeDayView { get; set; }

        string MonthView { get; set; }

        string To { get; set; }

        string On { get; set; }

        string Passengers { get; set; }

        string Adults { get; set; }

        string Children { get; set; }

        string Infants { get; set; }

        string SearchAgain { get; set; }

        string Journey { get; set; }

        string LowestFaresAvailable { get; set; }

        string NoChangeFaresOnly { get; set; }

        string PayToChangeFaresOnly { get; set; }

        string FreeToChangeFaresOnly { get; set; }

        string PromoFaresOnly { get; set; }

        string IAmFlyingFrom { get; set; }

        string TwelvePlus { get; set; }

        string TwoTo12 { get; set; }

        string Under2 { get; set; }

        string Under2Tooltip { get; set; }

        string ShowFlights { get; set; }

        string SorryThereWasAProblemWithYourSearch { get; set; }

        string PleaseCheckAndTryAgain { get; set; }

        string InfantPassengers { get; set; }

        string Arriving { get; set; }

        string Stop { get; set; }

        string SeatsLeft { get; set; }

        string PerPerson { get; set; }

        string Departing { get; set; }

        string MoreInfo { get; set; }

        string LoadingResults { get; set; }

        string PleaseWait { get; set; }

        string Loading { get; set; }

        string Sort { get; set; }

        string Prev { get; set; }

        string Next { get; set; }

        string PleaseSelectAFlightFromTheList { get; set; }

        string AddedToBooking { get; set; }

        string Added { get; set; }

        string LessInfo { get; set; }
    }
}
