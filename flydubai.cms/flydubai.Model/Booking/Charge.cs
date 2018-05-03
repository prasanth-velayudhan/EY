namespace flydubai.Model.Booking
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Charge
    /// </summary>
    [Serializable]
    public class Charge
    {
        public string CodeType { get; set; }

        public decimal Amount { get; set; }

        public decimal OriginalAmount { get; set; }

        public bool IsSSR { get; set; }

        public string Description { get; set; }

        public string TaxID { get; set; }

        public string Key { get; set; }

        // 0 = Inactive, 1 = Active
        public int ChargeStatus { get; set; }

        public string RefundType { get; set; }

        public bool HasBeenPaid { get; set; }

        public string ChargeComment { get; set; }

        public decimal Discount
        {
            get
            {
                return this.OriginalAmount - this.Amount;
            }
        }

        //Added for Ancillary sales in GDS booking
        public List<ReservationPaymentMap> ReservationPaymentMaps { get; set; }

        //FFP Changes
        public int BasePoints { get; set; }
        public int TierPoints { get; set; }
        public int BonusPoints { get; set; }
        public int BonusTierPoints { get; set; }

        //Leg level SSR
        public int PhysicalFlightID { get; set; }

        public int StatusReasonID { get; set; }

        public string TaxCode { get; set; }
        
    }
}
