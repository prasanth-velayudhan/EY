using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Merchandising.FLX
{
    public class PricingInformation
    {
        public string FlightId { get; set; } //Flight Id. This should match with One of the ID in the Flight Tag. This says this Seat Map is for Which Leg.
        public string PaxId { get; set; }//This should match with one of the ID in the Pax info. This says fare is applicable to which Pax.PersonORGId can be passed here for easy mapping.
        public string FareClass { get; set; }
        public string FareBasis { get; set; }
        public string FareType { get; set; }
    }
}
