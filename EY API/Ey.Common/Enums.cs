using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ey.Common
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

        public enum Result
        {
            restricted, restrictedinfant, failed, succeded
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
            RouteMessageVersion,
            Country,
            City,
            ApplicationSettings,
            PaymentType,
            PaymentSettings,
            CodeType,
            MpesaSetting,
            Regions,
            PassengerMessages,
            InterlineAgrement
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
            Confirmation
        }

        public enum PaymentMethod
        {
            DebitCreditCard,
            Voucher,
            AvailableCredit
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
            GdsWorkPhone = 7,
            GdsMobilePhone = 8
        }

        public class WebsiteRole
        {
            public const string User = "UserWebsiteRole";
            public const string Staff = "StaffWebsiteRole";
            public const string TravelAgent = "TravelAgentWebsiteRole";
            public const string Cms = "CmsWebsiteRole";
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
            PreSellMeals = 14
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
            Authorization
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

        public enum ItineraryPrepareAction
        {
            NotSet,
            Availability,
            Passenger,
            OptionalExtras,
            ModifyExtras,
            msFare
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

        public enum PnrState
        {
            PaidCashAndPoints,
            GDSPaidCashAndPoints,
            PartialPaymentDue,
            FullPaymentDue,
            SectorCancelled,
            BookingCancelled,
            PassengerDeleted,
            AsyncPartialPay,
            AsyncFullPay
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
		
		
		public enum VoucherTransferStatus
        {
            AnyPassenger = 0,
            ValidOnlyForIssuedTo = 1,
            IssuedMustFly = 2
        }
       
        public enum SeatMapTypes
        {
            None = 0,
            ECONOMY189 = 1,
            ECONOMY162 = 2,
            BUSINESS12 = 3,
            ECONOMY156 = 4,
            BUSINESS10 = 5
        }
        public enum ConnectedSegmentTypes
        {
            Connection,
            StopOver
        }

        public enum MasterAirportFilter
        {
            Ey = 0,
            Interline = 1,
            None = 2
        }
    }
}
