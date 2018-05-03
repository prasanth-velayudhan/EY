using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common
{
    /// <summary>
    /// Class of Enums
    /// </summary>
    [Serializable]
    public class Enums
    {
        public const int PayToChange = 1;
        public const int FreeToChange = 2;
        public const int NoChange = 3;
        public const int Business = 4;  //Added by a-5467 - Platinum changes

        public enum PassengerTypes
        {
            Adult = 1,
            Child = 6,
            Infant = 5
        }

        public enum PhoneType
        {
            Home,
            Mobile,
            Other
        }

        public enum RadixxServices
        {
            Fares,
            Flight,
            Fulfillment,
            Pricing,
            Reservation,
            Security,
            TravelAgents,
            Airports,
            Profiles,
            Modify,
            Unknown,
            Fees,
            Notification,
            TA,
            Utilities,
            Report
        }

        public enum SearchType
        {
            RoundTrip,
            OneWay,
            MultipleDestinations
        }

        public enum PNRValidStatus
        {
            SS,
            HK,
            KK,
            TK,
            CH,
            Confirm,
            NotYetProcessed,
            Rejected
        }

        public enum ResultsTab
        {
            DayView,
            /// <summary>
            /// WeekView aka ThreeDayView
            /// </summary>
            WeekView,
            MonthView
        }

        public enum CheckedBaggage
        {
            CheckedBaggage20Kg,
            CheckedBaggage30Kg,
            CheckedBaggage40Kg,
        }

        public enum OptionalExtrasType
        {
            Free,
            Added
        }

        public enum BaggageAllowance
        {
            HandBaggage,
            HandBaggageCheckedBaggage20KgIncluded,
            HandBaggageCheckedBaggage20KgIncludedPlusCheckedBaggage20Kg,
            HandBaggageCheckedBaggage30KgIncluded,
            HandBaggageCheckedBaggage40KgIncluded,
            CheckedBaggage20Kg,
            CheckedBaggage30Kg,
            CheckedBaggage40Kg
        }

        public enum ProfileType
        {
            User,
            Staff,
            TravelAgent
        }

        public enum Direction
        {
            Next,
            Previous
        }

        public enum WizardStep
        {
            SelectYourFlight = 1,
            PassengerDetails,
            OptionalExtras,
            Payment,
            Confirmation,
            SelectFare
        }

        public enum PaymentMethod
        {
            DebitCreditCard,
            Voucher,
            AvailableCredit,
            Points,
            Bsp
        }

        public enum PaymentVoucherState
        {
            Valid,
            Invalid,
            InUse
        }

        public enum PreferredContactNumber
        {
            Mobile,
            Home,
            Other
        }

        public enum Language
        {
            English,
            Arabic
        }

        public enum PaymentTransactionStatus
        {
            NotYetProcessed = 0,
            Successful = 1,
            Failure = 2,
            Cancelled = 3,
            Review = 4 
        }

        public enum RadixxDayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public enum BookingState
        {
            Confirmed,
            PaymentOutstanding,
            Expired,
            Cancelled,
            Flown
        }

        public enum MobileWizardStep
        {
            FlightSearch = 1,
            Results,
            PassengerDetails,
            OptionalExtras,
            Payment,
            Confirmation
        }

        public enum ContactTypes
        {
            HomePhone = 0,
            WorkPhone = 1,
            MobilePhone = 2,
            Pager = 3,
            Email = 4,
            Fax = 5,
        }

        public class WebsiteRole
        {
            public const string User = "UserWebsiteRole";
            public const string Staff = "StaffWebsiteRole";
            public const string TravelAgent = "TravelAgentWebsiteRole";
            public const string Cms = "CmsWebsiteRole";
        }

        public class Paxtype
        {
            public const string Adult = "ADT";
            public const string Child = "CHD";
            public const string Infant = "INF";
        }

        public enum CodeTypeCategory
        {
            Fares = 1,
            Taxes = 2,
            BaggageAllowance = 3,
            BaggageUpgrade = 4,
            Seating = 5,
            Insurance = 6,
            Penalty = 7,
            PaymentFee = 8,
            Wheelchair = 9,
            InFlightEntertainment = 10,
            //a-5466 Platinum
            Meals = 11,
            BusinessBaggage = 12,
            BusinessInFlightEntertainment = 13,
            PreSellMeals = 14,
            Noseating = 15
        }

        public class BusinessSeatingCode
        {
            public const string BusinessSeat = "SEAT";
        }

        public enum DepartureWindow
        {
            AmendBooking = 1,
            AmendSsr = 2
        }

        public enum ContactService
        {
            TravelAgent = 1,
            PaymentPartner,
            CallCentre
        }

        public enum ActionTypes
        {
            AuthenticateUser = 0,
            AuthenticateUserWithUserDetailRetrevial = 1,
            AuthenticateAgencyUserWithUserDetailRetrevial = 2
        }

        //Added by a-5467 - Platinum changes
        public enum MonthTabType
        {
            Economy = 0,
            Business = 1
        }

        //Added by a-5616 - Platinum Mobile changes
        public enum CabinType
        {
            AllCabin = 0,
            Economy = 1,
            Business = 2
        }

        public enum PaymentTransactionProcess
        {
            Authentication,
            Authorization,
            None
        }
        public enum SeatSSRCode
        {
            test,
            test1
        }
        public enum JourneyType
        {
            test1,
            test2
        }

        public enum TnsExceptionGroup
        {
            Generic,
            BankDeclined,
            Timeout,
            WrongInput,
            WrongInputCSC,
            PartiallyProcessed
        }


        public enum EnumerationsContactTypes : int
        {
            HomePhone = 0,
            WorkPhone = 1,
            MobilePhone = 2,
            Pager = 3,
            Email = 4,
            Fax = 5,
        }

        public enum EnumerationsGenderTypes : int
        {
            Male = 0,
            Female = 1,
            Unknown = 2,
        }

        public enum EnumerationsRelationshipTypes : int
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

        public enum EnumerationsCurrencyCodeTypes : int
        { AED = 0, AFN = 1, ALL = 2, AMD = 3, ANG = 4, AOA = 5, ARS = 6, AWG = 7, AZN = 8, BAM = 9, BBD = 10, BDT = 11, BGN = 12, BHD = 13, BIF = 14, BMD = 15, BND = 16, BOB = 17, BRL = 18, BSD = 19, BTN = 20, BWP = 21, BYR = 22, BZD = 23, CAD = 24, CDF = 25, CHF = 26, CLP = 27, CNY = 28, COP = 29, CRC = 30, CUP = 31, CVE = 32, CYP = 33, CZK = 34, DJF = 35, DKK = 36, DOP = 37, DZD = 38, EGP = 39, ERN = 40, ETB = 41, EUR = 42, FJD = 43, FKP = 44, GBP = 45, GEL = 46, GGP = 47, GHS = 48, GIP = 49, GMD = 50, GNF = 51, GTQ = 52, GYD = 53, HKD = 54, HNL = 55, HRK = 56, HTG = 57, HUF = 58, IDR = 59, ILS = 60, IMP = 61, INR = 62, IQD = 63, IRR = 64, ISK = 65, JEP = 66, JMD = 67, JOD = 68, JPY = 69, KES = 70, KGS = 71, KHR = 72, KMF = 73, KPW = 74, KWD = 75, KYD = 76, KZT = 77, LAK = 78, LBP = 79, LKR = 80, LRD = 81, LSL = 82, LTL = 83, LVL = 84, LYD = 85, MAD = 86, MDL = 87, MGA = 88, MKD = 89, MMK = 90, MNT = 91, MOP = 92, MRO = 93, MTL = 94, MUR = 95, MVR = 96, MWK = 97, MXN = 98, MYR = 99, MZN = 100, NAD = 101, NGN = 102, NIO = 103, NOK = 104, NPR = 105, NZD = 106, OMR = 107, PAB = 108, PEN = 109, PGK = 110, PHP = 111, PKR = 112, PLN = 113, PYG = 114, QAR = 115, RON = 116, RSD = 117, RUB = 118, RWF = 119, SAR = 120, SBD = 121, SCR = 122, SDG = 123, SEK = 124, SGD = 125, SHP = 126, SLL = 127, SOS = 128, SPL = 129, SRD = 130, STD = 131, SVC = 132, SYP = 133, SZL = 134, THB = 135, TJS = 136, TMM = 137, TND = 138, TOP = 139, TRI = 140, TTD = 141, TVD = 142, TWD = 143, TZS = 144, UAH = 145, UGX = 146, USD = 147, UYU = 148, UZS = 149, VEB = 150, VEF = 151, VND = 152, VUV = 153, WST = 154, XAF = 155, XAG = 156, XAU = 157, XCD = 158, XDR = 159, XOF = 160, XPD = 161, XPF = 162, XPT = 163, YER = 164, ZAR = 165, ZMK = 166, ZWD = 167, PNT = 168, SYS = 169, }

        public enum FFPProcessStatus
        {
            AlreadyUsed,
            NotAdult,
            NotChild,
            OK,
            InvalidMember
        }

        public enum BinDiscountFOP
        {
            None,
            CARD
        }

        public enum BinDiscountCardTypes
        {
            None,
            VISA,
            MSCD
        }
        public enum OrderMiddlewareActionTypes
        {
            SetNotYetProcessedPaymentsToRejected
        }

        public enum VoucherTransferStatus
        {
            AnyPassenger = 0,
            ValidOnlyForIssuedTo = 1,
            IssuedMustFly = 2
        }

        public enum ReaccomodationPopupTypes
        {
            None,
            ContactCC,
            Consent
        }

        public enum ConsentStatus
        {
            Unknown = 0,
            Pending = 1,
            Accepted = 2,
            Rejected = 3
        }

        public enum EnumerationsPaymentMethodTypes : int
        { AMEX = 0, DCLB = 1, DSCV = 2, MSCD = 3, UATP = 4, VISA = 5, INVC = 6, SAPI = 7, TKNE = 8, CASH = 9, CHCK = 10, TCHK = 11, TCKT = 12, VCHR = 13, PL8R = 14, EFT = 15, PNTS = 16, }

        public enum PaymentTransactionStatusTypes : int
        {

            NOTYETPROCESSED = 0,
            APPROVED = 1,
            DECLINED = 2,
        }

        public enum PerformAction : int
        {
            MIGS_AUTHENTICATE = 0,
            PROCESS_ACS = 1,
            VERIFY_CONFIRMATION = 2,
            INVALID_CHECK_ENROLLED_RESPONSE = 3,
            PAYMENT_GATEWAY_NOT_AVAILABLE = 4,
        }

        public enum DocumentTypes
        {
            NoDocument = 0,
            PASSPORT,
            USPRC,
            USARC,
            USMIDC,
            USREP,
            USRTD,
            PIL,
            BCC,
            USNC,
            PAL,
            NOA,
            TL,
            ADITS,
            USBC,
            VISA,
            CCC,
            CAC,
            USF1,
            LOA,
            NATO,
            ITO,
            PhotoID
        }

        public enum ActionType : int
        {

            //[System.Runtime.Serialization.EnumMemberAttribute()]
            UpdateAndProcessMIGS3DSecurePayment = 0,

            //[System.Runtime.Serialization.EnumMemberAttribute()]
            UpdateAndProcessTNS3DSecurePayment = 1,

            //[System.Runtime.Serialization.EnumMemberAttribute()]
            ByPassAuthentication = 2,

            //[System.Runtime.Serialization.EnumMemberAttribute()]
            SetNotYetProcessedPaymentsToRejected = 3
        }

        public enum SeatMapTypes
        {
            None,
            BUSINESS10,
            BUSINESS12,
            ECONOMY156,
            ECONOMY162,
            ECONOMY189
        }


        public enum IropsConsentStatus : int
        {
            NOTYETPROCESSED = 0,
            APPROVED = 1,
            ACCEPTED = 2,
            REJECTEDAPPROVE = 3,
            REFUND = 4,
            BACK = 5
        }
    }
}
