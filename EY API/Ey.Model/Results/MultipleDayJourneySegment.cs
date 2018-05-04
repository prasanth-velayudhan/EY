using Ey.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model.Results
{
    /// <summary>
    /// Multiple Day Journey Segment
    /// </summary>
    [Serializable]
    public class MultipleDayJourneySegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleDayJourneySegment"/> class.
        /// </summary>
        public MultipleDayJourneySegment()
        {
            this.DayLowestFares = new List<DayLowestFare>();
        }

        public int JourneySegmentId { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public List<DayLowestFare> DayLowestFares { get; set; }

        public List<Flight> SelectedDayFlights { get; set; }

        public DateTime SearchedFromDate { get; set; }

        public DateTime SearchedToDate { get; set; }

        public string CurrentDisplayCurrency { get; set; }

        public List<CombinabilityMapping> CombinabilityMapping { get; set; }
    }
}
