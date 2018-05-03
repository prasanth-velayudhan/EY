using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Merchandising.FLX
{
    [Serializable]
    public class FLXResponse
    {
        public TransactionInfo TransactionInfo { get; set; }
        public List<SSRCodeDetails> SSRCodeDetails { get; set; }
        public bool MandatoryApplyRadixxRates { get; set; }
    }

    [Serializable]
    public class FLXTransactionData 
    {
        //public TransactionInfo FLXTransactionsData { get; set; }

        public string Status { get; set; }
        public string StatusCode { get; set; }//Status code or error code
        public bool MandatoryApplyRadixxRates { get; set; }
    }
}
