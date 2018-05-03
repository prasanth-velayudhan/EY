using flydubai.Model.BookingMiddleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Payment
{
    public class TfeeRequest
    {
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
        public string PaymentMethod { get; set; }
        public string AgencyCurrency { get; set; }
        public string SecurityGUID { get; set; }
        public string CountryCode { get; set; }
        public string IATANumber { get; set; }
        
    }
}
