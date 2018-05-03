using System;
using System.Collections.Generic;
using System.Linq;

using flydubai.Model.Common;
using flydubai.Model.Search;

namespace flydubai.Model.Results
{
    /// <summary>
    /// One Day Journey Segment
    /// </summary>
    [Serializable]
    public class OneDayJourneySegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDayJourneySegment"/> class.
        /// </summary>
        public OneDayJourneySegment()
        {
            this.Flights = new List<Flight>();
            this.CombinabilityMapping = new List<CombinabilityMapping>();
        }

        public int JourneySegmentId{ get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime Date { get; set; }

        public List<Flight> Flights { get; set; }

        public string CurrentDisplayCurrency { get; set; }

        public List<CombinabilityMapping> CombinabilityMapping { get; set; }

    }
}
