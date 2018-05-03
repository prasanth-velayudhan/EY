using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using flydubai.Model.Attributes;

namespace flydubai.Model.Reports
{
    public class ViewBalanceReport
    {
        public ViewBalanceReport(ViewBalanceReport viewModel)
        {
            this.UserID = viewModel.UserID;
            this.primaryPassengerNameField = viewModel.primaryPassengerNameField;
            this.departureDateField = viewModel.departureDateField;
            this.bookingDateField = viewModel.bookingDateField;
            this.TotalBookedPassengers = viewModel.TotalBookedPassengers;
            this.commentsField = viewModel.commentsField;
            this.bookingCurrencyField = viewModel.bookingCurrencyField;
            this.bookingAmountField = viewModel.bookingAmountField;
            this.Totalsegments = viewModel.Totalsegments;
        }

        public ViewBalanceReport()
        {
        }
        /// <summary>
        /// User who made booking
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// Primary Passenger Name
        /// </summary>
        public string primaryPassengerNameField { get; set; }
        /// <summary>
        /// Departure date on the booking for first segment
        /// </summary>
        public DateTime departureDateField { get; set; }
        /// <summary>
        /// Date of Booking
        /// </summary>
        public DateTime bookingDateField { get; set; }
        /// <summary>
        /// Total Passengers on the booking
        /// </summary>
        public int TotalBookedPassengers { get; set; }
        /// <summary>
        /// Comments captured against transaction in Radixx
        /// </summary>
        public string commentsField { get; set; }
        /// <summary>
        /// Currency Of Booking
        /// </summary>
        public string bookingCurrencyField { get; set; }
        /// <summary>
        /// Amount on booking
        /// </summary>
        public decimal bookingAmountField { get; set; }
        /// <summary>
        /// Total Sectors on the booking
        /// </summary>
        public int Totalsegments { get; set; }

        public ViewBalanceReport AdditionalReportInfo { get; set; }

        /// <summary>
        /// Transaction number ( unique number generated for each transaction)
        /// </summary>
        public string invoiceNumberField { get; set; }

        /// <summary>
        /// Date of transaction for this payment
        /// </summary>
        public DateTime paymentDateField { get; set; }

        /// <summary>
        /// PNR number
        /// </summary>
        public string confirmationNumberField { get; set; }

        /// <summary>
        /// IATA number (Paid IATA) 
        /// </summary>
        public string iATANumberField { get; set; }

        /// <summary>
        /// User ID who paid for the booking
        /// </summary>
        public string PayerID { get; set; }

        /// <summary>
        /// Currency(Paid and Refund currency)
        /// </summary>
        public string paymentCurrencyField { get; set; }

        /// <summary>
        /// Amount on these transaction payments against bookings and refunds against bookings. (NOTE 1: Amount on deposit transactions is not included; 
        /// NOTE 2: Refund amount against bookings must be displayed with minus sign).
        /// </summary>
        public string paymentAmountField { get; set; }

        /// <summary>
        /// Deposited amount ( must be displayed with minus sign)
        /// </summary>
        public decimal depositAmountField { get; set; }

        /// <summary>
        /// Running balance (Balance on TA’s Account, including this transaction from date of inception)
        /// </summary>
        public decimal balanceDueField { get; set; }

        /// <summary>
        /// Payment transaction ID
        /// </summary>
        public int paymentReferenceField { get; set; }

        /// <summary>
        /// Deposit transaction date
        /// </summary>
        public DateTime depositDateField { get; set; }

        /// <summary>
        ///  dataset of viewblanceReport
        /// </summary>
        public System.Data.DataSet dsviewBalanceDetails { get; set; }

        /// <summary>
        /// totalChargesForRangeField
        /// </summary>
        public decimal totalChargesForRangeField { get; set; }

        /// <summary>
        /// Distributor /Agency name
        /// </summary>
        public decimal totalChargesFromInceptionField { get; set; }

        /// <summary>
        /// Distributor /Agency name
        /// </summary>
        public decimal totalPaymentsForRangeField { get; set; }

        /// <summary>
        /// Distributor /Agency name
        /// </summary>
        public decimal totalPaymentsFromInceptionField { get; set; }

        /// <summary>
        /// Distributor /Agency name
        /// </summary>
        public decimal overallBalanceForRangeField { get; set; }

        /// <summary>
        /// Distributor /Agency name
        /// </summary>
        public decimal overallBalanceFromInceptionField { get; set; }


        /// <summary>
        /// Distributor /Agency name
        /// </summary>
        public decimal TotalPaymentsForRange { get; set; }
        /// <summary>
        /// Distributor /Agency name
        /// </summary>
        [Required]
        public string AgencyName { get; set; }

        /// <summary>
        /// The Payment From date, for the report period.
        /// </summary>
        [Required]
        public DateTime? ReportStartDate { get; set; }

        /// <summary>
        /// The Payment To date, for the report period.  
        /// </summary>
        /// <value>Report End Date.</value>
        [Required]
        public DateTime? ReportEndDate { get; set; }

        [Required]
        [Email(ErrorMessageResourceName = "Human.InvalidEmail")]
        public string EmailID { get; set; }

        /// <summary>
        /// ReportSearchLabels
        /// </summary>
        // public ReportSearchLabels reportSearchLabels { get; set; }
        public IEnumerable<ViewBalanceReport> balanceinfo { get; set; }

    }
}