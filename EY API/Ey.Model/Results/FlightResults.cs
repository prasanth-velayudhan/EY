using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model.Results
{
    public class FlightResults
    {
        public List<OneDayJourneySegment> OneDayItineraries { get; set; }

        public List<MultipleDayJourneySegment> MultiDayItineraries { get; set; }
    }
}
