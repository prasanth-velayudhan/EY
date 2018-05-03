using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.ReAccommodation
{
    [Serializable]
    public class ReaccomReservationRQ
    {
        [Serializable]
        public class reaccomModifyRequest
        {
            public ModifyRequest modifyRequest { get; set; }   
        }

        [Serializable]
        public class ModifyRequest
        {
            public string channel { get; set; }
            public string subChannel { get; set; }
            public string pointOfSale { get; set; }
            public string currency { get; set; }
            public string requestorIATA { get; set; }
            public string SecurityGUID { get; set; }
            public string carrier { get; set; }
            public string PNR { get; set; }
            public ModifyDetails modifyDetails { get; set; }
        }

        [Serializable]
        public class ModifyDetails
        {
            public string action { get; set; }
            public OriginDestinations originDestinations { get; set; }
        }

        [Serializable]
        public class OriginDestinations
        {
            public List<OriginDestination> originDestination { get; set; }
        }

        [Serializable]
        public class OriginDestination
        {
            public string oldODRef { get; set; }
            public List<OldPaxRef> oldPaxRefs { get; set; }
        }

        [Serializable]
        public class OldPaxRef
        {
            public List<int> oldPaxRef { get; set; }
            public int fareID { get; set; }
        } 
        
    }
}
