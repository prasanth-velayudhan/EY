using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using flydubai.Model.Attributes;

namespace flydubai.Model.Reports
{
    public class TransactionReport
    {
        public TransactionReport(TransactionReport viewModel)
        {
            this.InvoiceNo = viewModel.InvoiceNo;
            this.ConfirmationNo = viewModel.ConfirmationNo;
            this.PayerID = viewModel.PayerID;
            this.IATANo = viewModel.IATANo;
            this.Userid = viewModel.Userid;
            this.TransDate = viewModel.TransDate;
            this.TransType = viewModel.TransType;
            this.Currency = viewModel.Currency;
            this.TransAmount = viewModel.TransAmount;
            this.Deposits = viewModel.Deposits;
            this.CancelledAmount = viewModel.CancelledAmount;
            this.Balance = viewModel.Balance;
            this.BegBalance = viewModel.BegBalance;
            this.TotalDeposits = viewModel.TotalDeposits;
            this.TotalCredits = viewModel.TotalCredits;
            this.TotalDebits = viewModel.TotalDebits;
            this.EndingBalance = viewModel.EndingBalance;
        }

        public TransactionReport()
        {
        }

        public bool IsReport { get; set; }

        public Int32 InvoiceNo { get; set; }

        /// <summary>
        /// Gets or sets the ConfirmationNo, an instance of <see cref="System.string"/> 
        /// </summary>

        public string ConfirmationNo { get; set; }

        /// <summary>
        /// Gets or sets the BookingAgent, an instance of <see cref="System.string"/> 
        /// </summary>

        public string PayerID { get; set; }

        /// <summary>
        /// Gets or sets the IATANo, an instance of <see cref="System.Int32"/> 
        /// </summary>

        public Int32 IATANo { get; set; }

        /// <summary>
        /// Gets or sets the Userid, an instance of <see cref="System.string"/>
        /// </summary>

        public string Userid { get; set; }

        /// <summary>
        /// Gets or sets the TransDate, an instance of <see cref="System.DateTime"/>
        /// </summary>

        public DateTime TransDate { get; set; }

        /// <summary>
        /// Gets or sets the TransType, an instance of <see cref="System.string"/>
        /// </summary>

        public string TransType { get; set; }

        /// <summary>
        /// Gets or sets the Currency, an instance of <see cref="System.string"/>
        /// </summary>

        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the TransAmount, an instance of <see cref="System.double"/>
        /// </summary>

        public double TransAmount { get; set; }

        /// <summary>
        /// Gets or sets the Deposits, an instance of <see cref="System.double"/>
        /// </summary>

        public double Deposits { get; set; }

        /// <summary>
        /// Gets or sets the CancelledAmount, an instance of <see cref="System.double"/>
        /// </summary>

        public double CancelledAmount { get; set; }

        /// <summary>
        /// Gets or sets the Balance, an instance of <see cref="System.double"/>
        /// </summary>

        public double Balance { get; set; }

        /// <summary>
        /// Gets or sets the BegBalance, an instance of <see cref="System.double"/>
        /// </summary>

        public double BegBalance { get; set; }

        /// <summary>
        /// Gets or sets the TotalDeposits, an instance of <see cref="System.double"/>
        /// </summary>

        public double TotalDeposits { get; set; }

        /// <summary>
        /// Gets or sets the TotalCredits, an instance of <see cref="System.double"/>
        /// </summary>

        public double TotalCredits { get; set; }

        /// <summary>
        /// Gets or sets the TotalDebits, an instance of <see cref="System.double"/>
        /// </summary>

        public double TotalDebits { get; set; }

        /// <summary>
        /// Gets or sets the EndingBalance, an instance of <see cref="System.double"/>
        /// </summary>

        public double EndingBalance { get; set; }

    }
}
