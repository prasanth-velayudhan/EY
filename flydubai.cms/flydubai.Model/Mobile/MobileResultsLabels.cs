using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Results Labels
    /// </summary>
    public class MobileResultsLabels : BaseLabels
    {
        public string SelectOutboundFlight { get; set; }
        public string SelectReturnFlight { get; set; }

        public string NoFlightsAvailableShowingClosest { get; set; }
        public string NoFlightsAvailableOnThisDate { get; set; }
        public string BasedOn24HourClock { get; set; }
        public string AllTimesShownAreLocal { get; set; }

        public string SortBy { get; set; }
        public string Time { get; set; }
        public string Price { get; set; }

        public string PerPerson { get; set; }

        public string BackToTop { get; set; }

        public string NoFlightsFoundForSelectedDate { get; set; }

        public string ShowingResultsForTheClosestAvailableDay { get; set; }

        public string Prev { get; set; }

        public string Next { get; set; }

        //----FR 11 A-5583----// 
        public string Day { get; set; }

        public string ArrivalNextDayTooltip { get; set; }

        public string ArrivalNextDay { get; set; }
        //----FR 11 A-5583----// 
        //FZWR-87
        public string NotAvailable { get; set; }


        //FZWR-42
        public string FlightStatusDiverted { get; set; }

        public string FlightStatusReRouted { get; set; }

        public string FlightStatusForcedReturnRAMP { get; set; }

        public string FlightStatusForcedReturnAIR { get; set; }

        public string FlightStatusNotYetDeparted { get; set; }

        public string FlightStatusArrived { get; set; }

        public string FlightStatusDeparted { get; set; }

        public string FlightStatusCancelled { get; set; }

        public string FlightStatusUnknown { get; set; }

        public string CombinabilityPopupContinue { get; set; }

        public string CombinabilityPopupCancel { get; set; }

        public string CombinabilityPopupMessage { get; set; }
    }
}
