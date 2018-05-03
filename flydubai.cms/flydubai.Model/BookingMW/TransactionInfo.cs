using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class TransactionInfo
    {
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
    }
}
