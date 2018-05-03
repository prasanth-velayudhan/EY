using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.PricingMW
{
    public class MultiCityMctFlightRQ
    {
        
        public class Request
        {
            public List<Flightgroup> flightGroups { get; set; }
        }

        public class Flightgroup
        {
            public int ID { get; set; }
            public List<Flight> flights { get; set; }
        }

        public class Flight
        {
            public int ID { get; set; }
            public string org { get; set; }
            public string dest { get; set; }
            public string mrktCarrier { get; set; }
            public string flightNum { get; set; }
            public string operCarrier { get; set; }
            public DateTime depDate { get; set; }
            public DateTime arrDate { get; set; }
        }

    }
}
