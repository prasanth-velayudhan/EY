using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Airports
{
    public class AirportsMWRS
    {
        public List<Airportdetail> airportdetails { get; set; }
        public int status { get; set; }
        public int code { get; set; }
        public object message { get; set; }
        public object devMessage { get; set; }
    }

    public class Airportdetail
    {
        public string code { get; set; }
        public string name { get; set; }
        public string terminal { get; set; }
        public string metro { get; set; }
        public string timeZone { get; set; }
        public string timeZoneName { get; set; }
        public string utcOffset { get; set; }
        public string currency { get; set; }
        public string country { get; set; }
        public string isoCountryNum { get; set; }
    }    
}
