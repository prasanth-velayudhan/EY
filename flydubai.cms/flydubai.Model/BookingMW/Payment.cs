using flydubai.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class Payment
    {
        public int ReservationPaymentID { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardType { get; set; }
        public string CardHolder { get; set; }
        public Enums.EnumerationsCurrencyCodeTypes PaymentCurrency { get; set; }
        public int ISOCurrency { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string CardNumber { get; set; }
        public string CVCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsTACreditCard { get; set; }
        public long VoucherNumber { get; set; }
        public string GcxID { get; set; }
        public string GcxOpt { get; set; }
        public string OriginalCurrency { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public string PaymentComment { get; set; }
        public string BillingCountry { get; set; }
        public int TransactionStatus { get; set; }
        public string Key { get; set; }
        public DateTime DatePaid { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public decimal BaseAmount { get; set; }
        public string BaseCurrency { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CurrencyPaid { get; set; }
        public string FFNumber { get; set; }  
        public string Postal { get; set; }
        public string Reference { get; set; }
        public string AncillaryData01 { get; set; }
        public string AncillaryData02 { get; set; }
        public string AncillaryData03 { get; set; }
        public string AncillaryData04 { get; set; }
        public string AncillaryData05 { get; set; }
        public DateTime ATCANDateProcessed { get; set; }
        public bool AuthenticationByPassed { get; set; }
        public string Authorizationcode { get; set; }
        public decimal AuthorizedAmount { get; set; }
        public int BatchProcessExtracted { get; set; }
        public DateTime BatchProcessStart { get; set; }
        public string CardVerification { get; set; }
        public int CheckNumber { get; set; }
        public decimal CommissionDeductedPayCurrency { get; set; }
        public decimal CommissionDeductedResCurrency { get; set; }
        public string DocumentReceivedBy { get; set; }
        public int GcxExported { get; set; }
        public DateTime GcxExportedDate { get; set; }
        public string GcxOptOption { get; set; }
        public decimal GrossAmtPayCurrency { get; set; }
        public decimal GrossAmtResCurrency { get; set; }
        public string IATANum { get; set; }
        public string MerchantID { get; set; }
        public int Miles { get; set; }
        public decimal NetAmtResCurrency { get; set; }
        public int OriginalPaymentID { get; set; }
        public string OriginalPaymentMethod { get; set; }
        public int PaymentReservationChannelID { get; set; }
        public int PersonOrgID { get; set; }
        public string ProcessorID { get; set; }
        public string ProcessorName { get; set; }
        public decimal RedeemedVoucherAmount { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string Result { get; set; }
        public decimal RptCommissionFromPayCurrency { get; set; }
        public decimal RptCommissionFromResCurrency { get; set; }
        public decimal RptNetFrmResCurrency { get; set; }
        public string SettlementBatch { get; set; }
        public string State { get; set; }
        public int TerminalID { get; set; }
        public string TicketCouponNumber { get; set; }
        public string TicketType { get; set; }
        public decimal TotalRefundPayCurrency { get; set; }
        public decimal TotalRefundResCurrency { get; set; }
        public decimal TotalRefundRptCurrency { get; set; }
        public string TransactionID { get; set; }
        public int TransactionIndicator { get; set; }
        public string UserData { get; set; }
        public string UserID { get; set; }
        public string ValueCode { get; set; }
    }
}
