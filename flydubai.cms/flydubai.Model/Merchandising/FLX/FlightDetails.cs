using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Merchandising.FLX
{
    public class FlightDetails
    {
        public int LogicalFlightID { get; set; }
        public string FlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string OriginAirportCode { get; set; }
        public string DepartureAirportCode { get; set; }
        public string ConnectionIndicator { get; set; }
        public string CountryCodeOriginAirport { get; set; }
        public string CountryCodeDestinationAirport { get; set; }
        public string CabinClass { get; set; }
        public string LegNumber { get; set; }
    }
}
