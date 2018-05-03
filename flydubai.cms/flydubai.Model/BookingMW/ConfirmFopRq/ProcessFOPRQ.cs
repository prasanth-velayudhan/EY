using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.ConfirmFopRq
{
    public class ConfirmFopRq
    {
        public TransactionInfo TransactionInfo { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public string ResponseFromProcessPayment { get; set; }
        public string PaymentId { get; set; }
        public flydubai.Common.Enums.ActionType Confirm_Action_Type { get; set; }
        public string HostOtp { get; set; }
    }
}
