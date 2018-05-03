using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Payment
{
    using System.Diagnostics;
    using flydubai.Model.BookingMW;

    /// <summary>
    /// Voucher Payment Details
    /// </summary>
    [Serializable]
    public class VoucherPaymentDetails
    {
        public int VoucherSequenceNumber { get; set; }

        public string VoucherNumber { get; set; }

        public string VoucherPin { get; set; }

        /// <summary>
        /// Gets or sets the original voucher value when this voucher was first created.
        /// </summary>
        public Price VoucherValue { get; set; }

        /// <summary>
        /// Gets or sets the voucher value before payment in the voucher's currency.
        /// </summary>
        public Price VoucherBalanceBeforePayment { get; set; }

        /// <summary>
        /// Gets or sets the total voucher payment converted to the journey's currency.
        /// </summary>
        public Price VoucherPaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the total amount due before this voucher was applied in the journey's currency.
        /// </summary>
        public Price PaymentDueBeforeVoucher { get; set; }

        /// <summary>
        /// Gets or sets the total payment due in the journey's currency.
        /// </summary>
        public Price PaymentDueAfterVoucher { get; set; }

        /// <summary>
        /// Gets or sets the remaining balance of the voucher in voucher's currency.
        /// </summary>
        public Price RemainingVoucherValue { get; set; }

        /// <summary>
        /// Gets or sets the date paid.
        /// </summary>
        public DateTime DatePaid { get; set; }
    }
}
