using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMiddleware
{
    public class RemoveDiscountAndPaymentFeeRQ
    {
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
        public bool rejectPayment { get; set; }
    }
}
