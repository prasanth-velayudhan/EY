using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Booking
{
    [Serializable]
    public class ReservationPaymentMap
    {
        public string Key { get; set; }

        public string ReservationPaymentID { get; set; }

        public decimal AmountApplied { get; set; }

        public string ReservationChargeID { get; set; }

        public DateTime DatePaid { get; set; }

        public string OriginalReferencePaymentID { get; set; }
    }
}
