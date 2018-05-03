using flydubai.Model.BookingMiddleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Payment.PNRPayment
{
    public class PNRPaymentRQ
    {
        public TransactionInfo TransactionInfo { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public List<PNRPayment> PNRPayments { get; set; }
    }

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
        public string ExpirationDate { get; set; }
        public System.DateTime ExpirationDate_DT
        {
            get { return Convert.ToDateTime(ExpirationDate); }
        }
        public decimal ExchangeRate { get; set; }
        public string ExchangeRateDate { get; set; }
        public System.DateTime ExchangeRateDate_DT
        {
            get { return Convert.ToDateTime(ExchangeRateDate); }
        }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string UserID { get; set; }
        public string IataNumber { get; set; }
        public string ReservationCurrency { get; set; }
        public decimal ReservationAmount { get; set; }
        public string TransactionStatus { get; set; }
        public Person Payor { get; set; }
        public decimal BalanceAmount { get; set; }

        //interline changes
        public string AuthorizationCode { get; set; }
        public decimal BaseAmount { get; set; }
        public string CardCurrency { get; set; }
        public string GcxID { get; set; }
        public string GcxOptOption { get; set; }
        public string MerchantID { get; set; }
        public string PaymentComment { get; set; }
        public string PaymentReference { get; set; }
        public string ResponseMessage { get; set; }
        public int TerminalID { get; set; }
        public string FingerPrintingSessionID { get; set; }
    }

    public class TransactionInfo
    {
        public List<CarrierCode> CarrierCodes { get; set; }
        public string SecurityGUID { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
    }

    public class Person
    {
        public int PersonOrgID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public GenderTypes Gender { get; set; }
        public string Title { get; set; }
        public int NationalityLaguageID { get; set; }
        public RelationshipTypes RelationType { get; set; }
        public int WBCID { get; set; }
        public int PTCID { get; set; }
        public string PTC { get; set; }
        public int TravelsWithPersonOrgID { get; set; }
        public string RedressNumber { get; set; }
        public string KnownTravelerNumber { get; set; }
        public bool MarketingOptIn { get; set; }
        public bool UseInventory { get; set; }
        public Address Address { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }
        public string Passport { get; set; }
        public string Nationality { get; set; }
        public int ProfileId { get; set; }
        public bool IsPrimaryPassenger { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }
        public string FrequentFlyerNumber { get; set; }
        public string Suffix { get; set; }
        public string TierName { get; set; }
    }

    public class ContactInfo
    {
        #region " Properties "
        /// <summary>The automatically system generated unique identifier for the passenger's contact person.</summary>
        /// <requirements><li>Value Required=M</li></requirements>
        public int ContactID { get; set; }
        /// <summary>The automatically system generated unique identifier for the passenger.</summary>
        /// <requirements><li>Value Required=M</li></requirements>
        public int PersonOrgID { get; set; }
        /// <summary>The field for the contact.</summary>
        /// <requirements><li>Value Required=M</li></requirements>
        /// <requirements><li>Minimum Value Length=1</li></requirements>
        /// <requirements><li>Maximum Value Length=64</li></requirements>
        /// <requirements><li>Special Format=None</li></requirements>
        public string ContactField { get; set; }
        /// <summary>The code that represents the specified mode for the contact. Use:0 = Home Phone 1 = Work Phone 2 = Mobile Phone 3 = Pager 4 = E-mail 5 = Fax 6 = SSN</summary>
        /// <requirements><li>Value Required=M</li></requirements>
        public flydubai.Common.Enums.ContactTypes ContactType { get; set; }
        /// <summary>
        /// Cretaed to support JSON - JSON changes
        /// </summary>
        /// <returns></returns>
        //public ContactTypes ContactType_Enum
        //{
        //    get { return Helper.GetEnumValueFromDescription<ContactTypes>(ContactType); }
        //}

        /// <summary>The extension number for the contact.</summary>
        /// <requirements><li>Value Required=O</li></requirements>
        /// <requirements><li>Minimum Value Length=1</li></requirements>
        /// <requirements><li>Maximum Value Length=8</li></requirements>
        /// <requirements><li>Special Format=None</li></requirements>
        public string Extension { get; set; }
        /// <summary>The code that represents the country where the contact resides.</summary>
        /// <requirements><li>Value Required=O</li></requirements>
        /// <requirements><li>Minimum Value Length=1</li></requirements>
        /// <requirements><li>Maximum Value Length=8</li></requirements>
        /// <requirements><li>Special Format=None</li></requirements>
        public string CountryCode { get; set; }
        /// <summary>The three-digit code that identifies the telephone area for the contact.</summary>
        /// <requirements><li>Value Required=O</li></requirements>
        /// <requirements><li>Minimum Value Length=1</li></requirements>
        /// <requirements><li>Maximum Value Length=8</li></requirements>
        /// <requirements><li>Special Format=None</li></requirements>
        public string AreaCode { get; set; }
        /// <summary>The contact's phone number.</summary>
        /// <requirements><li>Value Required=O</li></requirements>
        /// <requirements><li>Minimum Value Length=1</li></requirements>
        /// <requirements><li>Maximum Value Length=12</li></requirements>
        /// <requirements><li>Special Format=None</li></requirements>
        public string PhoneNumber { get; set; }
        /// <summary>Logical value indicating that this contact information is to be displayed to the user</summary>
        /// <requirements><li>Value Required=O</li></requirements>
        /// <requirements><li>Minimum Value Length=1</li></requirements>
        /// <requirements><li>Maximum Value Length=64</li></requirements>
        /// <requirements><li>Special Format=None</li></requirements>
        public string Display { get; set; }
        /// <summary>Logical value indicating that this is to be used as the preferred means of contact</summary>
        /// <requirements><li>Value Required=M</li></requirements>
        public bool PreferredContactMethod { get; set; }
        #endregion
    }

    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Display { get; set; }
    }

    public enum GenderTypes : int
    {
        Male = 0,
        Female = 1,
        Unknown = 2,
    }

    public enum RelationshipTypes : int
    {
        Self = 0,
        Spouse = 1,
        Father = 2,
        Mother = 3,
        Son = 4,
        Daughter = 5,
        GrandFather = 6,
        GrandMother = 7,
        Uncle = 8,
        Aunt = 9,
        Nephew = 10,
        Niece = 11,
    }

    public enum PaymentMethodTypes : int
    {
        AMEX = 0,
        DCLB = 1,
        DSCV = 2,
        MSCD = 3,
        UATP = 4,
        VISA = 5,
        INVC = 6,
        SAPI = 7,
        TKNE = 8,
        CASH = 9,
        CHCK = 10,
        TCHK = 11,
        TCKT = 12,
        VCHR = 13,
        PL8R = 14,
        PNTS = 15,
    }

    public enum PaymentTransactionStatusTypes : int
    {
        NOTYETPROCESSED = 0,
        APPROVED = 1,
        DECLINED = 2,
    }

    public class PNRPaymentPoints
    {
        public string AccountNumber { get; set; }
        public string CurrencyPaid { get; set; }
        public string DatePaid { get; set; }
        public DateTime DatePaid_DT
        {
            get { return Convert.ToDateTime(DatePaid); }
        }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string ReservationCurrency { get; set; }
        public decimal ReservationAmount { get; set; }
        public Person Payor { get; set; }
    }
}
