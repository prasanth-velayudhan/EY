using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class ReservationPaymentMap
    {
        public string Key { get; set; }
        public int ReservationPaymentID { get; set; }
        public decimal AmountApplied { get; set; }
        public int ReservationChargeID { get; set; }
        public DateTime? DatePaid { get; set; }
        public int OriginalReferencePaymentID { get; set; }
        public decimal RefundAmount { get; set; }
        public string ApprovalCode { get; set; }       
        public int PaymentCurrencyAmount { get; set; }        
    }    
}
