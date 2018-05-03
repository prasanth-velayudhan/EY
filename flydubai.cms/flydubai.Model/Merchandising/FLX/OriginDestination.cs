using flydubai.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Merchandising.FLX
{
    public class OriginDestination
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string LogicalFlightId { get; set; }
        public FlightDetails FlightDetails { get; set; }
        public Enums.JourneyType JourneyType { get; set; }
    }
}
