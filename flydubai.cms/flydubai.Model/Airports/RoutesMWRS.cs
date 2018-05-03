using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Airports
{
    public class RoutesMWRS
    {
        public List<Route> routes { get; set; }
    }

    public class Route
    {
        public string org { get; set; }
        public string dest { get; set; }
        //public string isInterline { get; set; }
        public string type { get; set; }
    }
}
