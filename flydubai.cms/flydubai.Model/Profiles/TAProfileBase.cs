using System;
using System.Collections;
using System.Collections.Generic;
using flydubai.Common;
using flydubai.Model.Profiles;
using System.Linq;
using flydubai.Model.Content;

namespace flydubai.Model.Profiles
{
    /// <summary>
    /// Abstract class AuthenticateTAUser
    /// </summary>
    [Serializable]
    public abstract class AuthenticateTAUser : Human
    {

        public AgencyInfo AgencyUser { get; set; }
        public String DaysUntilPasswordChange { get; set; }
        public Exception Exceptions { get; set; }
        public int PasswordStrength { get; set; }
        public String ResultMessage { get; set; }
        public String ServiceDatabasePackageVersion { get; set; }
        public String ServiceVersion { get; set; }
        public String UserID { get; set; }
        public String AccountName { get; set; }

        //Temporary 
        public AuthenticationResponseCodes ResultCode { get; set; }
        public String IATACode { get; set; }
        public Decimal CreditLimit { get; set; }
        public String resultcod { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String CompanyName { get; set; }
        public String ContactName { get; set; }
        public String CurrencyCode { get; set; }
        public String ParentIATACode { get; set; }
        public String AccountNumber { get; set; }
        public DateTime AccountExpiration { get; set; }
        public bool FetExempt { get; set; }
        public String BankNumber { get; set; }
        public String TravelAgentStatus { get; set; }
        public int ConsortTravalAgentId { get; set; }
        public String FareBasisCode { get; set; }
        public String AccountID { get; set; }
        public String FederalID { get; set; }
        public bool EmailReceipt { get; set; }
        public bool FaxReceipt { get; set; }
        public bool MailReceipt { get; set; }
        public string Comments { get; set; }
        public bool Prepaid { get; set; }
        public bool CanViewAllPnrs { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String ZipCode { get; set; }
        public String Country { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Fax { get; set; }
        public String TravelAgentUserName { get; set; }
        public decimal AvailableCredit { get; set; }
        public bool UnlimitedCredit { get; set; }
        public bool AccessCallCenterFee { get; set; }
        public bool IsTrustedClientUser { get; set; }
        public int ReservationChannelIDToAlias { get; set; }
        public string ReservationChannelNameToAlias { get; set; }
        public string DefaultUserName { get; set; }
        public bool BspEnabled { get; set; }
        public List<GroupPrivilege> TAPrivilegs { get; set; }


        // Need to remove
        public long? ProfileId { get; set; }

        //Added for OFEE changes - Start
        public bool IsStaff
        {
            get
            {
                return TAPrivilegs.Any(i => i.GroupPriviledgeName == "TA_ACCESSTOCREDITCARD" && (i.GroupPriviledgeLevel == "Unlimited" || i.GroupPriviledgeLevel == "Modify"));
            }
        }

        public IEnumerable<OFEEConfig> OFEEConfigs { get; set; }
        public decimal agenctTFEE { get; set; }
        //Added for OFEE changes - End
    }
    [Serializable]
    public class GroupPrivilege
    {
        public string GroupPriviledgeLevel { get; set; }
        public string GroupPriviledgeName { get; set; }
    }

    [Serializable]
    public class AgencyInfo
    {
        // New CR related properties

        public DateTime AccountExpiration { get; set; }
        public String AccountID { get; set; }
        public String AccountName { get; set; }
        public String AccountNumber { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String BankNumber { get; set; }
        public bool CanViewAllPnrs { get; set; }
        public String City { get; set; }
        public String Comments { get; set; }
        List<Commission> Commissions { get; set; }
        //public Commission Commissions { get; set; }
        public String CompanyName { get; set; }
        public int ConsortTravelAgentID { get; set; }
        //public ContactInfo ContactInfos { get; set; }
        List<ContactInfo> ContactInfos { get; set; }
        public String ContactName { get; set; }
        public String Country { get; set; }
        public Decimal CreditLimit { get; set; }
        public String CurrencyCode { get; set; }
        public String Email { get; set; }
        public bool EmailReciept { get; set; }
        public String FareBasisCode { get; set; }
        public String Fax { get; set; }
        public bool FaxReciept { get; set; }
        public String FederalID { get; set; }
        public bool FetExcempt { get; set; }
        public String IATACode { get; set; }
        public bool MailReciept { get; set; }
        public String ParentIATACode { get; set; }
        public String Phone { get; set; }
        public bool Prepaid { get; set; }
        public String State { get; set; }
        public String TravelAgentStatus { get; set; }
        //public  TravelAgentTypeID { get; set; }
        public String TravelAgentUserName { get; set; }
        //public UserGroup UserGroups { get; set; }
        List<UserGroup> UserGroups { get; set; }
        //public UserPriviledge UserPriviledges { get; set; }
        List<UserGroup> UserPriviledges { get; set; }
        public String ZipCode { get; set; }


        public class Commission
        {
            public CurrencyCodeTypes Currency { get; set; }
            public Decimal FlatRate { get; set; }
            public Decimal MaximumCommission { get; set; }
            public Decimal MinimumCommission { get; set; }
            public PaymentMethodTypes PaymentMethod { get; set; }
            public Decimal Percentage { get; set; }

        }

        public class ContactInfo
        {
            public String AreaCode { get; set; }
            public String ContactField { get; set; }
            public int ContactID { get; set; }
            public int ContactType { get; set; }
            public String CountryCode { get; set; }
            public String Display { get; set; }
            public String Extension { get; set; }
            public String PhoneNumber { get; set; }
            public bool PreferredContactMethod { get; set; }
        }

        public class UserGroup
        {
            public String GroupName { get; set; }
            List<GroupRight> GroupRights { get; set; }
            //public GroupRight GroupRights { get; set; }

            public class GroupRight
            {
                public String FunctionName { get; set; }
                public PrivlegeLevel PrivlegeLevel { get; set; }
            }
        }



        public class UserPriviledge
        {
            public String FunctionName { get; set; }
            public PrivlegeLevel PrivlegeLevel { get; set; }

        }


    }
    [Serializable]
    public enum AuthenticationResponseCodes
    {
        InternalError = 0,
        UserNotFound = 8,
        SuccessfulLogin = 9,
        UserLocked = 10,
        PasswordExpired = 11,
        PasswordMatchesPrevious = 12,
        PasswordStrengthNotStrong = 13,
        DBUserNotFound = 14,
        PasswordChanged = 15,
        TooManyFailedLoginsWithinDuration = 17,
        UserUnlocked = 18,
        FirstTimeLogin = 19,
        PasswordDoesNotMatch = 20,
        UserCreated = 21,
        UserNotCreated = 22,
        NotAnAdministrator = 23,
        UserAlreadyExists = 24,
        UserDisabledDueToInactivity = 25,
        IncompleteData =26
    }
    [Serializable]
    public enum PrivlegeLevel
    {
        NoAccess = 0,
        ReadOnly = 1,
        Modify = 2,
        Unlimited = 4
    }
    [Serializable]
    public enum TravelAgencyTypes
    {
        Corporation = 0,
        ParentTravelAgent = 1,
        ChildTravelAgent = 2,
        AtoCto = 3,
        ChildCtoAtoAgent = 4,
        Undefined = 99,
    }
    [Serializable]
    public enum PaymentMethodTypes
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
        VCHR = 13
    }

    [Serializable]
    //This is not a ISO Standard currency code. It is used as a we for the Consuming ConnectPoint interface to specify that it does not know the currency to pass for a particular request when getting fare information. 
    //The presence of this code allows Radixx internal business logic to determine appropriate currency to use
    public enum CurrencyCodeTypes
    {

        AED = 0,
        AFN = 1,
        ALL = 2,
        AMD = 3,
        ANG = 4,
        AOA = 5,
        ARS = 6,
        AWG = 7,
        AZN = 8,
        BAM = 9,
        BBD = 10,
        BDT = 11,
        BGN = 12,
        BHD = 13,
        BIF = 14,
        BMD = 15,
        BND = 16,
        BOB = 17,
        BRL = 18,
        BSD = 19,
        BTN = 20,
        BWP = 21,
        BYR = 22,
        BZD = 23,
        CAD = 24,
        CDF = 25,
        CHF = 26,
        CLP = 27,
        CNY = 28,
        COP = 29,
        CRC = 30,
        CUP = 31,
        CVE = 32,
        CYP = 33,
        CZK = 34,
        DJF = 35,
        DKK = 36,
        DOP = 37,
        DZD = 38,
        EGP = 39,
        ERN = 40,
        ETB = 41,
        EUR = 42,
        FJD = 43,
        FKP = 44,
        GBP = 45,
        GEL = 46,
        GGP = 47,
        GHS = 48,
        GIP = 49,
        GMD = 50,
        GNF = 51,
        GTQ = 52,
        GYD = 53,
        HKD = 54,
        HNL = 55,
        HRK = 56,
        HTG = 57,
        HUF = 58,
        IDR = 59,
        ILS = 60,
        IMP = 61,
        INR = 62,
        IQD = 63,
        IRR = 64,
        ISK = 65,
        JEP = 66,
        JMD = 67,
        JOD = 68,
        JPY = 69,
        KES = 70,
        KGS = 71,
        KHR = 72,
        KMF = 73,
        KPW = 74,
        KWD = 75,
        KYD = 76,
        KZT = 77,
        LAK = 78,
        LBP = 79,
        LKR = 80,
        LRD = 81,
        LSL = 82,
        LTL = 83,
        LVL = 84,
        LYD = 85,
        MAD = 86,
        MDL = 87,
        MGA = 88,
        MKD = 89,
        MMK = 90,
        MNT = 91,
        MOP = 92,
        MRO = 93,
        MTL = 94,
        MUR = 95,
        MVR = 96,
        MWK = 97,
        MXN = 98,
        MYR = 99,
        MZN = 100,
        NAD = 101,
        NGN = 102,
        NIO = 103,
        NOK = 104,
        NPR = 105,
        NZD = 106,
        OMR = 107,
        PAB = 108,
        PEN = 109,
        PGK = 110,
        PHP = 111,
        PKR = 112,
        PLN = 113,
        PYG = 114,
        QAR = 115,
        RON = 116,
        RSD = 117,
        RUB = 118,
        RWF = 119,
        SAR = 120,
        SBD = 121,
        SCR = 122,
        SDG = 123,
        SEK = 124,
        SGD = 125,
        SHP = 126,
        SLL = 127,
        SOS = 128,
        SPL = 129,
        SRD = 130,
        STD = 131,
        SVC = 132,
        SYP = 133,
        SZL = 134,
        THB = 135,
        TJS = 136,
        TMM = 137,
        TND = 138,
        TOP = 139,
        TRI = 140,
        TTD = 141,
        TVD = 142,
        TWD = 143,
        TZS = 144,
        UAH = 145,
        UGX = 146,
        USD = 147,
        UYU = 148,
        UZS = 149,
        VEB = 150,
        VEF = 151,
        VND = 152,
        VUV = 153,
        WST = 154,
        XAF = 155,
        XAG = 156,
        XAU = 157,
        XCD = 158,
        XDR = 159,
        XOF = 160,
        XPD = 161,
        XPF = 162,
        XPT = 163,
        YER = 164,
        ZAR = 165,
        ZMK = 166,
        ZWD = 167,
        SYS = 168
    }
}




