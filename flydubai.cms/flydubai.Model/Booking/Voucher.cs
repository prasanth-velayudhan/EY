namespace flydubai.Model.Booking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Voucher
    /// </summary>
    [Serializable]
    public class Voucher
    {
        public string VoucherNumber { get; set; }
        public string  CurrencyCode { get; set; }
        public decimal  OriginalAmount { get; set; }
        public decimal  BalanceAmount { get; set; }
        public string  VoucherNumberFull { get; set; }
        public string  VoucherPW { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public int NonTransferable { get; set; }
    }
}
