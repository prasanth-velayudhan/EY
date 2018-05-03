using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model.Booking;
namespace flydubai.Model.ReAccommodation
{
    [Serializable]
    public class ReaccFlightSearch
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime SearchStartDate { get; set; }
        public DateTime SearchEndDate { get; set; }
        public List<LogicalFlight> logicalFlight { get; set; }
    }
}
