using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.ReAccommodation
{
    [Serializable]
    public class reaccomCancelRQ
    {
        [Serializable]
        public class reaccomCancelRequest
        {
            public string securityGUID { get; set; }
            public string channel { get; set; }
            public string subChannel { get; set; }
            public string pointOfSale { get; set; }
            public ModifyDetails modifyDetails { get; set; }
            public string carrier { get; set; }
            public string PNR { get; set; }
           
        }

        [Serializable]
        public class ModifyDetails
        {
            public string action { get; set; }
        }   
    }
}
