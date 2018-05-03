using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Booking
{
    public class FzReceipt
    {
        public class Request
        {
            public TransactionDetails transactionDetails { get; set; }
            public CarrierCode[] carrierCodes { get; set; }
            public ReceiptDetails receiptDetails { get; set; }
        }
        public class TransactionDetails
        {
            public string clientIPAddress { get; set; }
            public string userName { get; set; }
        }

        public class ReceiptDetails
        {
            public string seriesNum { get; set; }
            public string PNR { get; set; }
            public string language { get; set; }
            public string outputType { get; set; }
            public string customerType { get; set; }
        }

        public class CarrierCode
        {
            public string AccessibleCarrierCode { get; set; }
        }

        public class Response
        {
            public string receiptResponse { get; set; }
            public string message { get; set; }
        }
    }
}
