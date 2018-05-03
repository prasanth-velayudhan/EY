using System;
using System.Collections.Generic;

using flydubai.Model.Common;

namespace flydubai.Model.Results
{
    /// <summary>
    /// Flights On Date
    /// </summary>
    [Serializable]
    public class FlightsOnDate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightsOnDate"/> class.
        /// </summary>
        public FlightsOnDate()
        {
            this.Flights = new List<Flight>();
        }

        public DateTime Date { get; set; }

        public List<Flight> Flights { get; set; }
    }
}
