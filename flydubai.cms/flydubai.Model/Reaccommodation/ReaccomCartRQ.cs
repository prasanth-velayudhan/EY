using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.ReAccommodation
{
    [Serializable]
    public class reaccomCartRQ
    {
        [Serializable]
        public class reaccomCartRequest
        {
            public string currency { get; set; }
            public string IATA { get; set; }
            public string PNR { get; set; }
            public string action { get; set; }
            public int inventoryFilterMethod { get; set; }
            public string promoCode { get; set; }
            public string securityGUID { get; set; }
            public List<ModifyDetails> modifyDetails { get; set; }
            public List<OriginDestinations> originDestinations { get; set; }
        }

        [Serializable]
        public class ModifyDetails
        {
            public string oldODRef { get; set; }
            public IList<int> oldPaxRef { get; set; }
        }

        [Serializable]
        public class OriginDestinations
        {
            public string odID { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public string flightNum { get; set; }
            public DateTime depDate { get; set; }
            public bool isPromoApplied { get; set; }
            public List<SegmentDetails> segmentDetails { get; set; }
        }

        [Serializable]
        public class SegmentDetails
        {
            public string segmentID { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public string operCarrier { get; set; }
            public string operFlightNum { get; set; }
            public DateTime depDate { get; set; }
            public DateTime arrDate { get; set; }
            public string mrktCarrier { get; set; }
            public string mrktFlightNum { get; set; }
            public bool OAFlight { get; set; }
        }

        public enum ActionTypes : int
        {
            reaccom = 0,
            ReaccomReservation = 1,
            reaccomCancel=2
        }
    }
}
