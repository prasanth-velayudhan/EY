using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using flydubai.Model.Attributes;

namespace flydubai.Model.Reports
{
    public class CommissionReport
    {
        public CommissionReport(CommissionReport viewModel)
        {
            this.PNR = viewModel.PNR;
            this.USER_ID = viewModel.USER_ID;
            this.PAYMENT_DATE = viewModel.PAYMENT_DATE;
            this.FROM_AIRPORT = viewModel.FROM_AIRPORT;
            this.TO_AIRPORT = viewModel.TO_AIRPORT;
            this.IATA_NUMBER = viewModel.IATA_NUMBER;
            this.PAYER_ID = viewModel.PAYER_ID;
            this.BOOKED_CURRENCY = viewModel.BOOKED_CURRENCY;
            this.BOOKED_AMOUNT = viewModel.BOOKED_AMOUNT;
            this.PAID_CURRENCY = viewModel.PAID_CURRENCY;
            this.PAID_AMOUNT = viewModel.PAID_AMOUNT;
            this.AGENCY_COMMISSION = viewModel.AGENCY_COMMISSION;
            this.PASSENGER_COUNT = viewModel.PASSENGER_COUNT;
            this.TRANSACTION_NUMBER = viewModel.TRANSACTION_NUMBER;
            this.Total_Fares = viewModel.Total_Fares;
            this.Total_Commission = viewModel.Total_Commission;
        }

        public CommissionReport()
        {
        }



        /// <summary>
        /// pnr
        /// </summary>
        public string PNR { get; set; }

        /// <summary>
        /// userid
        /// </summary>
        public string USER_ID { get; set; }

        /// <summary>
        /// from airport
        /// </summary>
        public string FROM_AIRPORT { get; set; }

        /// <summary>
        /// to airport
        /// </summary>
        public string TO_AIRPORT { get; set; }

        /// <summary>
        /// iata number
        /// </summary>
        public string IATA_NUMBER { get; set; }

        /// <summary>
        /// payment date
        /// </summary>
        public DateTime PAYMENT_DATE { get; set; }

        /// <summary>
        /// payer id
        /// </summary>
        public string PAYER_ID { get; set; }

        /// <summary>
        /// booked currency
        /// </summary>
        public string BOOKED_CURRENCY { get; set; }

        /// <summary>
        /// booked amount
        /// </summary>
        public decimal BOOKED_AMOUNT { get; set; }

        /// <summary>
        /// paid currency
        /// </summary>
        public string PAID_CURRENCY { get; set; }

        /// <summary>
        /// paid amount
        /// </summary>
        public decimal PAID_AMOUNT { get; set; }

        /// <summary>
        /// agency commision
        /// </summary>
        public decimal AGENCY_COMMISSION { get; set; }

        /// <summary>
        /// passenger count
        /// </summary>
        public int PASSENGER_COUNT { get; set; }

        /// <summary>
        /// transaction number
        /// </summary>
        public string TRANSACTION_NUMBER { get; set; }

        /// <summary>
        /// fares
        /// </summary>
        public decimal Total_Fares { get; set; }

        /// <summary>
        /// commission
        /// </summary>
        public decimal Total_Commission { get; set; }





    }
}
