using flydubai.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
     [Serializable]
    public class ProcessPaymentResponse
    {
        public string PaymentGateway { get; set; }
        public Enums.PerformAction PerformAction { get; set; }
        public string AuthenticationString { get; set; }
        public object AuthorizationPNRResponse { get; set; }
        public int Timeout { get; set; }
        public int Retry { get; set; }
        public bool IsPrimaryGatewayActive { get; set; }
        public object SummaryStatus { get; set; }
        public object GatewayCode { get; set; }
        public List<Exception> Exceptions { get; set; }
        public string CardType { get; set; }
    }    
}
