using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.SetCharges
{
    public class SetChargesRQ
    {
        public string currency { get; set; }
        public string IATA { get; set; }
        public int inventoryFilterMethod { get; set; }
        public string promoCode { get; set; }
        public string securityGUID { get; set; }
        public List<OriginDestination> originDestinations { get; set; }
    }
}
