using Ey.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model.Results
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
            this.MasterBrandList = new List<FareBrandInfo>();
        }

        public int JourneySegmentId { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime Date { get; set; }

        public List<Flight> Flights { get; set; }

        public string CurrentDisplayCurrency { get; set; }

        public List<CombinabilityMapping> CombinabilityMapping { get; set; }
        public IEnumerable<FareBrandInfo> MasterBrandList { get; set; }
    }
    [Serializable]
    public class FareBrandInfo
    {
        public string FareTypeID { get; set; }
        public string FareTypeName { get; set; }
        public string CabinType { get; set; }
    }
}
