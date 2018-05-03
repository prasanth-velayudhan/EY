using System;
using System.Collections;
using System.Collections.Generic;

namespace flydubai.Model.Search
{

    /// <summary>
    /// Flight Criteria
    /// </summary>
    [Serializable]
    public class FlightCriteria
    {

        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDate { get; set; }

        public string OriginCity { get; set; }

        public string DestinationCity { get; set; }

        public string OriginShortLabel { get; set; }

        public string DestinationShortLabel { get; set; }

        public int SegmentId { get; set; }

        public bool SearchedNextAvailableDate { get; set; }

        public bool? IsOriginMetroCode { get; set; }
        public bool? IsDestinationMetroCode { get; set; }

        //public List<string> OriginMetroAirportsLabels { get; set; }
        //public List<string> DestinationMetroAirportsLabels { get; set; }
        public List<string> OriginAirportsUnderMetro { get; set; }
        public List<string> DestinationAirportsUnderMetro { get; set; }
    }
}
