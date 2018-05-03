using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Profiles
{
    /// <summary>
    /// Profile Voucher
    /// </summary>
    public class ProfileVoucher
    {
        public int VoucherNumber { get; set; }

        public string VoucherRef { get; set; }

        public string ReasonCode { get; set; }

        public string VoucherReason { get; set; }

        public DateTime EffectiveDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string Currency { get; set; }

        public decimal OriginalAmount { get; set; }

        public decimal Balance { get; set; }
    }
}
