using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Payment
{
    [Serializable]
    public class MigsDetails
    {
        /// <summary>
        /// Gets or sets the migs URL, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The migs URL.</value>
        public string MigsUrl { get; set; }

        /// <summary>
        /// Gets or sets the VPC access code, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC access code.</value>
        public string vpc_AccessCode { get; set; }

        /// <summary>
        /// Gets or sets the VPC amount, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC amount.</value>
        public string vpc_Amount { get; set; }

        /// <summary>
        /// Gets or sets the VPC command, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC command.</value>
        public string vpc_Command { get; set; }

        /// <summary>
        /// Gets or sets the VPC locale, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC locale.</value>
        public string vpc_Locale { get; set; }

        /// <summary>
        /// Gets or sets the VPC merch TXN ref, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC merch TXN ref.</value>
        public string vpc_MerchTxnRef { get; set; }

        /// <summary>
        /// Gets or sets the VPC merchant, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC merchant.</value>
        public string vpc_Merchant { get; set; }

        /// <summary>
        /// Gets or sets the VPC order info, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC order info.</value>
        public string vpc_OrderInfo { get; set; }

        /// <summary>
        /// Gets or sets the VPC return URL, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC return URL.</value>
        public string vpc_ReturnURL { get; set; }

        /// <summary>
        /// Gets or sets the VPC ticket no, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC ticket no.</value>
        public string vpc_TicketNo { get; set; }

        /// <summary>
        /// Gets or sets the VPC version, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC version.</value>
        public string vpc_Version { get; set; }

        /// <summary>
        /// Gets or sets the vpc_gateway, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The vpc_gateway.</value>
        public string vpc_gateway { get; set; }

        /// <summary>
        /// Gets or sets the vpc_card, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The vpc_card.</value>
        public string vpc_card { get; set; }

        /// <summary>
        /// Gets or sets the VPC card num, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC card num.</value>
        public string vpc_CardNum { get; set; }

        /// <summary>
        /// Gets or sets the VPC card exp, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC card exp.</value>
        public string vpc_CardExp { get; set; }

        /// <summary>
        /// Gets or sets the VPC addendum data, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC addendum data.</value>
        public string vpc_AddendumData { get; set; }

        /// <summary>
        /// Gets or sets the VPC secure hash, an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The VPC secure hash.</value>
        public string vpc_SecureHash { get; set; }

        /// <summary>
        /// Gets or sets the type of the VPC secure hash., an instance of <see cref="System.String" />
        /// </summary>
        /// <value>The type of the VPC secure hash.</value>
        public string vpc_SecureHashType { get; set; }

        public int RetryCount { get; set; }

        public int MigsTimeoutDuration { get; set; }

        public string TNS_HTML { get; set; }

        public string TypeofPayment { get; set; }

        public int RequestTimeout { get; set; }

        public int RequestRetryCount { get; set; }

        public int PayLaterMessagePromtTimeframe { get; set; }

        public int RedirectionToPayLaterTimeframe { get; set; }
    }
}
