using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flydubai.Model.Payment
{    
    public class BinDiscountResponse
    {
        public string ConfirmationNumber { get; set; }
        public List<DiscountAndPaymentFeeDetail> BinBasedDiscountAndPaymentFeeResponse { get; set; }
        public List<Exception1> Exceptions { get; set; }
    }

    public class DiscountAndPaymentFeeDetail
    {
        public string PaymentMethod { get; set; }
        public string AccountNumber { get; set; }
        public decimal ReservationBalance { get; set; }
        public decimal PaymentFee { get; set; }
        public decimal TotalDiscount { get; set; }
        public DiscountResponse DiscountResponse { get; set; }
        public List<Exception1> Exceptions { get; set; }
    }

    public class DiagnosticInfo
    {
        public string Id { get; set; }
        public string Details { get; set; }
    }

    public class AdjustedAmount
    {
        public string ChargeId { get; set; }
        public int SegmentId { get; set; }
        public int PaxId { get; set; }
        public string OdId { get; set; }
        public string ChargeType { get; set; }
        public double OriginalAmount { get; set; }
        public string Currency { get; set; }
        public decimal adjustedAmount { get; set; }
        public DiagnosticInfo DiagnosticInfo { get; set; }
    }

    public class AdjustedAmounts
    {
        public List<AdjustedAmount> AdjustedAmount { get; set; }
    }

    public class DiscountResponse
    {
        public AdjustedAmounts AdjustedAmounts { get; set; }
        public string Status { get; set; }
    }

    public class Exception1
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public string ExceptionLevel { get; set; }
    }

}
