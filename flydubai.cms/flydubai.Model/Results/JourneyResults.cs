using System;
using System.Collections.Generic;
using flydubai.Common;
using System.Linq;
using flydubai.Model.Search;
using flydubai.Model.Common;

namespace flydubai.Model.Results
{
    /// <summary>
    /// Journey Results
    /// </summary>
    [Serializable]
    public class JourneyResults
    {
        // Present for serialisation only - not for use.
        public JourneyResults()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyResults"/> class.
        /// </summary>
        /// <param name="currency">The currency.</param>
        /// <param name="fareFilter">The fare filter.</param>
        public JourneyResults(string currency, int fareFilter)
        {
            this.SelectedCurrency = currency;
            this.OriginalCurrency = currency;
            this.SelectedFareTypeFilter = fareFilter;
            this.currentUserDateSelection = new Dictionary<int, DateTime>();
            this.Combinability = new List<CombinabilityMapping>();
        }

        public int SelectedFareTypeFilter { get; set; }

        public string OriginalCurrency { get; set; }

        public string SelectedCurrency { get; set; }

        public Enums.ResultsTab SelectedTab { get; set; }

        public Enums.MonthTabType SelectedMonthTab { get; set; }//Added by a-5467 - Platinum changes

        public List<OneDayJourneySegment> OneDayJourneySegments { get; set; }

        public List<MultipleDayJourneySegment> ThreeDayJourneySegments { get; set; }

        public List<MultipleDayJourneySegment> OneMonthJourneySegments { get; set; }

        public List<MultipleDayJourneySegment> OneMonthBusinessJourneySegments { get; set; }//Added by a-5467 - Platinum changes

        public List<CombinabilityMapping> Combinability { get; set; }

        public List<CombinabilityMapping> WeekViewCombinability { get; set; }

        public List<MultiDayLowestFareFlight> WeekViewLowestFareFlights { get; set; }

        public Dictionary<int, Flight> SelectedMultiCityFlights { get; set; }

        /// <summary>
        /// this represents where a user has actually selected a date in the UI .. indexed by segmentKey which is ORG_DES
        /// </summary>
        private Dictionary<int, DateTime> currentUserDateSelection { get; set; }


        /// <summary>
        /// retrieves what the user has currently selected for this segment id .. if they haven't done this, it will return the original search date for this segment
        /// </summary>
        /// <param name="segmentId"></param>
        /// <param name="originalSearchCriteria"></param>
        /// <returns></returns>
        public DateTime GetCurrentDateSelectionForSegment(int segmentId, flydubai.Model.Search.SearchCriteria originalSearchCriteria)
        {
            DateTime dateToUse;

            DateTime? userSelectedDate = this.GetCurrentUserDateSelectionForSegment(segmentId);
            if (userSelectedDate.HasValue)
                dateToUse = userSelectedDate.Value;
            else
                dateToUse = originalSearchCriteria.Flights.Where(f => f.SegmentId == segmentId).FirstOrDefault().DepartureDate.Date;

            return dateToUse;
        }


        /// <summary>
        /// Retrieves what the user last selected as the departure date for the current segment.  Will return null if user hasn't selected a date
        /// </summary>
        /// <param name="originCode"></param>
        /// <param name="destCode"></param>
        /// <returns></returns>
        public DateTime? GetCurrentUserDateSelectionForSegment(int segmentId)
        {
            DateTime? forReturn = null;

            if (this.currentUserDateSelection != null && this.currentUserDateSelection.ContainsKey(segmentId))
                forReturn = currentUserDateSelection[segmentId].Date;

            return forReturn;
        }


        /// <summary>
        /// Sets the current date selection for segment.
        /// </summary>
        /// <param name="segmentId">The segment id.</param>
        /// <param name="newDate">The new date.</param>
        public void SetCurrentDateSelectionForSegment(int segmentId, DateTime newDate)
        {
            if (currentUserDateSelection.ContainsKey(segmentId))
                currentUserDateSelection[segmentId] = newDate;
            else
                currentUserDateSelection.Add(segmentId, newDate);
        }

        /// <summary>
        /// Determines whether a user-selected date still falls within the range of the 3-day or 1-month views
        /// </summary>
        /// <param name="duration">Expected to be either one month or 3-day views only</param>
        /// <returns></returns>
        public bool CurrentSelectionIsOutsideDateRange(Enums.ResultsTab duration)
        {
            //(there is no need to handle one-day views here, since we always have a one-day view that matches the current date selection stashed away).

            bool outsideRange = false;

            //first of all, check the user selections
            List<MultipleDayJourneySegment> segmentsToCheck;
            if (duration == Enums.ResultsTab.WeekView)
                segmentsToCheck = this.ThreeDayJourneySegments;
            else
                segmentsToCheck = this.OneMonthJourneySegments;

            if (segmentsToCheck != null)
            {
                foreach (MultipleDayJourneySegment segment in segmentsToCheck)
                {
                    DateTime? currentSelectedDate = this.GetCurrentUserDateSelectionForSegment(segment.JourneySegmentId);
                    if (currentSelectedDate.HasValue)
                    {
                        if (currentSelectedDate.Value < segment.SearchedFromDate || currentSelectedDate.Value > segment.SearchedToDate)
                        {
                            outsideRange = true;
                            break;
                        }
                    }
                }
            }
            else
                outsideRange = true;


            return outsideRange;
        }

        /// <summary>
        /// Dateses the have been changed.
        /// </summary>
        /// <returns></returns>
        public bool DatesHaveBeenChanged()
        {
            return currentUserDateSelection != null && currentUserDateSelection.Count > 0;
        }

        /// <summary>
        /// Clears the journey results for new search.
        /// </summary>
        public void ClearJourneyResultsForNewSearch()
        {
            this.OneDayJourneySegments = null;
            this.OneMonthJourneySegments = null;
            this.ThreeDayJourneySegments = null;
            this.currentUserDateSelection = new Dictionary<int, DateTime>();
            this.OneMonthBusinessJourneySegments = null;//Modified by a-5467 - Platinum changes
        }
    }

}
