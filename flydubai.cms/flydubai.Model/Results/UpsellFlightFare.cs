using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Results
{
    /// <summary>
    /// Flight Upsell Fares
    /// </summary>
    [Serializable]
    public class FlightUpsellFares
    {
        public int LFID  { get; set; }

        public DateTime DepartureDate { get; set; }

        public List<FlightFare> UpsellFlightFares { get; set; }        
    }
}
 