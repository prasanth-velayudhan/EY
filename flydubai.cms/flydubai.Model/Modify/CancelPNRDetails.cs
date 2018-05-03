using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Modify
{
    /// <summary>
    /// Cancel PNR Details
    /// </summary>
    [Serializable]
    public class CancelPNRDetails
    {
        public decimal Penalty { get; set; }

        public decimal TotalRefund { get; set; }
    }
}
