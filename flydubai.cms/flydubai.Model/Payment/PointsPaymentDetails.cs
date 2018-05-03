using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Payment
{
    using System.Diagnostics;

    /// <summary>
    /// Points Payment Details
    /// </summary>
    [Serializable]
    public class PointsPaymentDetails
    {        
        /// <summary>
        /// Gets or sets the total points before payment.
        /// </summary>
        public long TotalPointsBeforePayment { get; set; }

        /// <summary>
        /// Gets or sets the points redeemed.
        /// </summary>
        public long PointsRedeemed { get; set; }

        /// <summary>
        /// Gets or sets the total points after payment.
        /// </summary>
        public Price TotalPointsAfterPayment { get; set; }

        /// <summary>
        /// Gets or sets the points payment amount in journey currency.
        /// </summary>
        public Price PointsPaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the total amount due before the points was applied in journey currency.
        /// </summary>
        public Price PaymentDueBeforePoints { get; set; }

        /// <summary>
        /// Gets or sets the total amount due after the points was applied in journey currency.
        /// </summary>
        public Price PaymentDueAfterPoints { get; set; }

        /// <summary>
        /// Gets or sets the date paid.
        /// </summary>
        public DateTime DatePaid { get; set; }
    }
}
