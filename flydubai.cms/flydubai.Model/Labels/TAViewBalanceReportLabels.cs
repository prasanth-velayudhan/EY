using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace flydubai.Model.Labels
{
    public class TAViewBalanceReportLabels : BaseLabels
    {
        [DefaultValue("View Balance Report")]
        public string ReportTitle { get; set; }
        [DefaultValue("Transactions between: {0} and {1}")]
        public string TransactionDates { get; set; }
        [DefaultValue("Invoice Number")]
        public string InvoiceNo { get; set; }
        [DefaultValue("Payment Date")]
        public string PaymentDate { get; set; }
        [DefaultValue("PNR")]
        public string PNR { get; set; }
        [DefaultValue("IATA Number")]
        public string IATAnumber { get; set; }
        [DefaultValue("Payer ID")]
        public string PayerID { get; set; }
        [DefaultValue("Currency")]
        public string Currency { get; set; }
        [DefaultValue("Amount")]
        public string Amount { get; set; }
        [DefaultValue("Deposit Date")]
        public string DepositDate { get; set; }
        [DefaultValue("Deposit Amount")]
        public string DepositAmount { get; set; }
        [DefaultValue("Balance Due")]
        public string BalanceDue { get; set; }
        [DefaultValue("Payment Ref")]
        public string PaymentRef { get; set; }
        [DefaultValue("Master agency totals")]
        public string CumulativeTitle { get; set; }
        [DefaultValue("Aging summary totals   (Period :{0} - {1})")]
        public string summaryTitle { get; set; }
        [DefaultValue("Total charges:")]
        public string TotalCharges { get; set; }
        [DefaultValue("Total payments:")]
        public string TotalPayments { get; set; }
        [DefaultValue("Overall balance:")]
        public string OverallBalance { get; set; }
        [DefaultValue("Culmulative Totals  (Period :{0} - {1})")]
        public string CumulativeTotalsTitle { get; set; }
        [DefaultValue("User ID")]
        public string UserID { get; set; }
        [DefaultValue("Total Passengers")]
        public string TotalPassengers { get; set; }
        [DefaultValue("Total Segments")]
        public string TotalSegments { get; set; }
        [DefaultValue("Passenger Name")]
        public string PaxName { get; set; }
        [DefaultValue("Departure Date")]
        public string DeapartureDate { get; set; }
        [DefaultValue("Comments")]
        public string Comments { get; set; }
        [DefaultValue("Booking Date")]
        public string BookingDate { get; set; }
        [DefaultValue("Booked Currency")]
        public string BookedCurrency { get; set; }
        [DefaultValue("Booked Amount")]
        public string BookedAmount { get; set; }
        [DefaultValue("Additional Information:")]
        public string InformationTitle { get; set; }
        [DefaultValue("Close")]
        public string CloseTitle { get; set; }
        [DefaultValue("NoReportsMessage")]
        public string NoReportsMessage { get; set; }
    }
}
