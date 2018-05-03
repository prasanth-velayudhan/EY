using flydubai.Model.BookingMiddleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model.BookingMW.SummaryPnr;
using flydubai.Common;

namespace flydubai.Model.Payment.PnrResponses
{
    public class CheckPnrStatusRS
    {
        public object SecurityGUID { get; set; }
        public object CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
        public List<PNRException> exceptions { get; set; }
        public List<PnrDetail> pnrDetails { get; set; }
        public flydubai.Model.BookingMW.ReservationInfo reservationInfo { get; set; }
    }
    public class PnrDetail
    {
        public object SecurityGUID { get; set; }
        public object CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
        public int LogicalFlightID { get; set; }
        public int PhysicalFlightID { get; set; }
        public string lASTGDSStatus { get; set; }
        public string personName { get; set; }
        public int personORGID { get; set; }
        public string recordLocator { get; set; }
    }
    public class UpdatelocatorRS
    {
        public List<System.Exception> Exceptions { get; set; }
        public bool Status { get; set; }
    }
    public class ProcessPaymentResponse
    {
        public string PaymentGateway { get; set; }
        public PerformAction PerformAction { get; set; }
        public string AuthenticationString { get; set; }
        public object AuthorizationPNRResponse { get; set; }
        public int Timeout { get; set; }
        public int Retry { get; set; }
        public bool IsPrimaryGatewayActive { get; set; }
        public object SummaryStatus { get; set; }
        public object GatewayCode { get; set; }
        public List<PNRException> Exceptions { get; set; }
        public string CardType { get; set; }
    }

    public class ViewPNRFOP
    {
        public SummaryPnrRS ViewPNR { get; set; }
        public ProcessPaymentResponse ProcessPaymentResponse { get; set; }
    }

    public enum PerformAction : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        MIGS_AUTHENTICATE = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        PROCESS_ACS = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        VERIFY_CONFIRMATION = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        INVALID_CHECK_ENROLLED_RESPONSE = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        PAYMENT_GATEWAY_NOT_AVAILABLE = 4,
    }
    public class Payment
    {
        public string Key { get; set; }
        public int TransactionStatus { get; set; }
        public int ReservationPaymentID { get; set; }

        public string CompanyName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CardType { get; set; }

        public string CardHolder { get; set; }

        public string PaymentCurrency { get; set; }

        public int ISOCurrency { get; set; }

        public decimal PaymentAmount { get; set; }

        public Enums.EnumerationsPaymentMethodTypes PaymentMethod { get; set; }

        public string CardNum { get; set; }

        public string CVCode { get; set; }

        public System.DateTime ExpirationDate { get; set; }

        public bool IsTACreditCard { get; set; }

        public long VoucherNum { get; set; }
        public string VoucherNumber { get; set; }

        public string FFNumber { get; set; }
        public string GcxID { get; set; }

        public string GcxOpt { get; set; }

        public string OriginalCurrency { get; set; }

        public decimal OriginalAmount { get; set; }
        public string CurrencyPaid { get; set; }

        public decimal ExchangeRate { get; set; }

        public System.DateTime ExchangeRateDate { get; set; }

        public string PaymentComment { get; set; }

        public string BillingCountry { get; set; }

    }
    public class PNRException
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public int ExceptionLevel { get; set; }
    }
    public class Comment
    {

        private int CommentIDField;


        private string KeyField;


        private System.DateTime CommentDateField;


        private string CommentField;


        private int CommentLengthField;


        private string UserIDField;



        public int CommentID
        {
            get
            {
                return this.CommentIDField;
            }
            set
            {
                if ((this.CommentIDField.Equals(value) != true))
                {
                    this.CommentIDField = value;
                    this.RaisePropertyChanged("CommentID");
                }
            }
        }


        public string Key
        {
            get
            {
                return this.KeyField;
            }
            set
            {
                if ((object.ReferenceEquals(this.KeyField, value) != true))
                {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }

        public System.DateTime CommentDate
        {
            get
            {
                return this.CommentDateField;
            }
            set
            {
                if ((this.CommentDateField.Equals(value) != true))
                {
                    this.CommentDateField = value;
                    this.RaisePropertyChanged("CommentDate");
                }
            }
        }

        public string Comments
        {
            get
            {
                return this.CommentField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CommentField, value) != true))
                {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }

        public int CommentLength
        {
            get
            {
                return this.CommentLengthField;
            }
            set
            {
                if ((this.CommentLengthField.Equals(value) != true))
                {
                    this.CommentLengthField = value;
                    this.RaisePropertyChanged("CommentLength");
                }
            }
        }

        public string UserID
        {
            get
            {
                return this.UserIDField;
            }
            set
            {
                if ((object.ReferenceEquals(this.UserIDField, value) != true))
                {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
