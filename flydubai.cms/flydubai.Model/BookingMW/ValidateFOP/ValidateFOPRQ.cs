using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.ValidateFOP
{
    public class ValidateFOPRQ
    {
        public bool CheckPNRStatus { get; set; }
        public TransactionInfo TransactionInfo { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public List<PNRPayment> PNRPayments { get; set; }
        public string ReturnURL { get; set; }
    }
}
