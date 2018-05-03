using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flydubai.Model.Mpesa
{

    public class MpesaDetailsResponse
    {
        public PricePNRForPaymentRS PricePNRForPaymentRS { get; set; }
    }

    public class TotalPNRAmount
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class FeeInfosResp
    {
        public string feeCode { get; set; }
        public string ssrCode { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class PricePNRForPaymentRS
    {
        public TotalPNRAmount totalPNRAmount { get; set; }
        public List<FeeInfosResp> feeInfos { get; set; }
    }
}
