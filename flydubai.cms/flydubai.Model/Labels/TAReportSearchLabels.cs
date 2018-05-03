using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace flydubai.Model.Labels
{
    public class TAReportSearchLabels : BaseLabels
    {
        [DefaultValue("Login to your account")]
        public string TA_SelectDates { get; set; }

        [DefaultValue("useremail@domain.com")]
        public string TA_Email { get; set; }

        [DefaultValue("")]
        public string TA_AgencyName { get; set; }

        [DefaultValue("dd/mm/yyyy")]
        public string TA_ReportStartDate { get; set; }

        [DefaultValue("dd/mm/yyyy")]
        public string TA_ReportEndDate { get; set; }

        [DefaultValue("")]
        public string TA_UpdateResults { get; set; }

        [DefaultValue("{Distributor Name}")]
        public string TA_DefaultAgencyname { get; set; }

        [DefaultValue("useremail@domain.com")]
        public string TA_DefaultEmail { get; set; }

        [DefaultValue("dd/mm/yyyy")]
        public string TA_DefaultStartDate { get; set; }

        [DefaultValue("dd/mm/yyyy")]
        public string TA_DefaultEndDate { get; set; }



        [DefaultValue("Run Report")]
        public string TA_ViewReportButton { get; set; }

        [DefaultValue("User Id")]
        public string TA_UserId { get; set; }

        [DefaultValue("PNR")]
        public string TA_PNR { get; set; }

        [DefaultValue("Origin")]
        public string TA_FromAitport { get; set; }

        [DefaultValue("Destination")]
        public string TA_ToAirport { get; set; }

        [DefaultValue("Iata Number")]
        public string TA_IataNumber { get; set; }

        [DefaultValue("Payment Date")]
        public string TA_PaymentDate { get; set; }

        [DefaultValue("Payer Id")]
        public string TA_PayerId { get; set; }

        [DefaultValue("Booked Currency")]
        public string TA_BookedCurrency { get; set; }

        [DefaultValue("Booked Amount")]
        public string TA_BookedAmount { get; set; }

        [DefaultValue("Paid Currency")]
        public string TA_PaidCurrency { get; set; }

        [DefaultValue("Paid Amount")]
        public string TA_PaidAmount { get; set; }

        [DefaultValue("Agency Commision")]
        public string TA_AgencyCommission { get; set; }

        [DefaultValue("Pax Count")]
        public string TA_PassengerCount { get; set; }

        [DefaultValue("Transaction Number")]
        public string TA_TransactionNumber { get; set; }

        [DefaultValue("Transactions On")]
        public string TA_TransactionsOn { get; set; }

        [DefaultValue("Master Agency Totals")]
        public string TA_MasterAgencyTotals { get; set; }

        [DefaultValue("Cumulative Totals")]
        public string TA_CumulativeTotals { get; set; }

        [DefaultValue("Total Fares")]
        public string TA_TotalFares { get; set; }

        [DefaultValue("Total Commission")]
        public string TA_TotalCommission { get; set; }



        [DefaultValue("Agent Reference:")]
        public string TA_AgentReferenceText { get; set; }

        [DefaultValue("Transaction Start Date:")]
        public string TA_TransactionStartDateText { get; set; }

        [DefaultValue("Transaction End Date:")]
        public string TA_TransactionEndDateText { get; set; }

        [DefaultValue("Email ID:")]
        public string TA_EmailIDText { get; set; }

        [DefaultValue("Select Dates:")]
        public string TA_SelectDatesText { get; set; }

        [DefaultValue("Master Agency Totals")]
        public string TA_MasterAgencyTotalsText { get; set; }

        [DefaultValue("Begining Balance:")]
        public string TA_BeginingBalanceText { get; set; }

        [DefaultValue("Plus:Total Deposits:")]
        public string TA_TotalDepositsText { get; set; }

        [DefaultValue("Plus:Total Credits:")]
        public string TA_TotalCreditText { get; set; }

        [DefaultValue("Less:Total Debits:")]
        public string TA_TotalDebitText { get; set; }

        [DefaultValue("Ending Balance:")]
        public string TA_EndingBalanceText { get; set; }

        [DefaultValue("Transaction Totals:")]
        public string TA_TransactionTotalsText { get; set; }

        [DefaultValue("Invoice Number")]
        public string TA_InvoiceNumText { get; set; }

        [DefaultValue("PNR")]
        public string TA_PNRText { get; set; }

        [DefaultValue("User ID")]
        public string TA_UserIDText { get; set; }

        [DefaultValue("IATA")]
        public string TA_IATAText { get; set; }

        [DefaultValue("Payer ID")]
        public string TA_PayerIDText { get; set; }

        [DefaultValue("Transaction Date")]
        public string TA_TransactionDateText { get; set; }

        [DefaultValue("Transaction Type")]
        public string TA_TransactionTypeText { get; set; }

        [DefaultValue("Currency")]
        public string TA_CurrencyText { get; set; }

        [DefaultValue("Transaction Amount")]
        public string TA_TransactionAmountText { get; set; }

        [DefaultValue("Balance")]
        public string TA_BalanceText { get; set; }

        [DefaultValue("No Reports Available")]
        public string TA_ReportsUnavailableText { get; set; }

    }
}
