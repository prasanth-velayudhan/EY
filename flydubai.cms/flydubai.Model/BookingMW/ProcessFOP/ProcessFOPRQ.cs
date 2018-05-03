using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.ProcessFOP
{
    public class ProcessFOPRQ
    {
        public bool CheckPNRStatus { get; set; }
        public bool ApplyDiscounts { get; set; }
        public TransactionInfo TransactionInfo { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public List<PNRPayment> PNRPayments { get; set; }
        public string ReturnURL { get; set; }
    }
}
