using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model.Journey;

namespace flydubai.Model.Mobile.OptionalExtras
{
    /// <summary>
    /// Class used for mobile passenger seating.  Needs to be used in conjuction with JourneyPassenger from session.  Both use the same Id value so you can index between them
    /// </summary>
    public class JourneySeating
    {
        public int PassengerId { get; set; }
        public string Seat { get; set; }
        public int Row { get; set; }
        public string CodeType { get; set; }
        public string FareClass { get; set; }
    }
}
