using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Payment
{
    [Serializable]
    public class MPesaPayment
    {

        public string BalanceAmount { get; set; }

        public string Currency { get; set; }

        public bool MPesaServiceStatus { get; set; }

        public bool MpesaOpted { get; set; }

        public decimal TotalAdminFee { get; set; }
    }
}