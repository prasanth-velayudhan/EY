using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.PricingMW
{
    public class MultiCityMctFlightRS
    {
        public class Response
        {
            public Flightgroup[] flightGroups { get; set; }
        }

        public class Flightgroup
        {
            public int ID { get; set; }
            public Flight[] flights { get; set; }
        }

        public class Flight
        {
            public Group[] validGroup { get; set; }
            public Group[] invalidGroup { get; set; }
        }

        public class Group
        {
            public CNX[] CNX { get; set; }
        }

        public class CNX
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