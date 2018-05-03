using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    [Serializable]
    public class PNRPayment
    {
        public string AccountNumber { get; set; }
        public string AccountPin { get; set; }
        public string CardHolder { get; set; }
        public string CurrencyPaid { get; set; }
        public string CVCode { get; set; }
        public DateTime DatePaid { get; set; }
        public DateTime DatePaid_DT
        {
            get { return Convert.ToDateTime(DatePaid); }
        }
        public DateTime ExpirationDate { get; set; }
        public System.DateTime ExpirationDate_DT
        {
            get { return Convert.ToDateTime(ExpirationDate); }
        }
        public decimal ExchangeRate { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public System.DateTime ExchangeRateDate_DT
        {
            get { return Convert.ToDateTime(ExchangeRateDate); }
        }
        
        public decimal OriginalAmount { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string UserID { get; set; }
        public string IataNumber { get; set; }
        public string ReservationCurrency { get; set; }
        public string OriginalCurrency { get; set; }
        public decimal ReservationAmount { get; set; }
        public string TransactionStatus { get; set; }
        public decimal BaseAmount { get; set; }
        public string PaymentComment { get; set; }
        public string AuthorizationCode { get; set; }
        public string PaymentReference { get; set; }
        public string CardCurrency { get; set; }
        public string MerchantID { get; set; }
        public string ProcessorID { get; set; }
        public string ProcessorName { get; set; }
        public string FingerPrintingSessionID { get; set; }
        public string GcxID { get; set; }
        public string GcxOptOption { get; set; }
        public int TerminalID { get; set; }
        public string ResponseMessage { get; set; }
        public Person Payor { get; set; }
    }
}
