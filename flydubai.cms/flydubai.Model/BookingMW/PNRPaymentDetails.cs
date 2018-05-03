using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    [Serializable]
    public class PNRPaymentDetails
    {
        public decimal ReservationBalance { get; set; }
        public List<PNRPayment> PnrPayments { get; set; }
    }
}
