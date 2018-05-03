using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Merchandising.FLX
{
    public class SeatMap
    {
        public string LogicalFligtId { get; set; }
        public string PhysicalFlightId { get; set; }//Flight Id. This should match with One of the ID in the Flight Tag. This says this Seat Map is for Which Leg.
        public DateTime DepartureDate { get; set; }//of the PhysicalFlightId
        public string CabinClass { get; set; }//Cabin Class for which the seat map is valid
        public string SeatConfiguration { get; set; }
        public List<SeatCode> SeatCodes { get; set; }
        public List<SeatDetails> SeatDetails { get; set; }
    }
}
