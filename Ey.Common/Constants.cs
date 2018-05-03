using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ey.Common
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Class of Constants
    /// </summary>
    public class Constants
    {
        public const int LowestFareFilter = 0;

        public const int PayToChange = 1;

        public const int FreeToChange = 2;

        public const int NoChange = 3;

        public const int BusinessPayToChange = 4;   //Added by a-5467

        public const string InsuranceCharge = "INSU";

        public const string TFEECharge = "TFEE";    //OFEE changes

        public const string InsuranceReversal = "INSC";

        public const string EyCarrierCode = "Ey";

        public const string ReceiptLanguageId = "1";

        public const string NotApplicable = "NA";

        public const string SeriesNumber = "299";

        public const string User = "WEB2_LIVE";

        public const string MobileUser = "WEB_MOBILE";

        public const string DefaultLanguage = "en";

        public const string EmailRegex = @"^([a-zA-Z0-9])+(\.?[a-zA-Z0-9_-])*@([a-zA-Z0-9-])+(\.[a-zA-Z0-9_-]+)+$";

        public const string TelephoneRegex = @"^(\+?[0-9]*)?\s*(\([0-9]*\))?[\s\-/0-9]*$";

        public static Dictionary<string, string> Carriers = new Dictionary<string, string>()
            {
                {"Ey", "Ey"},
                {"EK", "Emirates"}
            };

        public static List<KeyValuePair<int, string>> BookingHeaderEnglishSteps = new List<KeyValuePair<int, string>>(5)
            {
                new KeyValuePair<int, string>(1, "Select your flight"),
                new KeyValuePair<int, string>(2, "Passenger details"),
                new KeyValuePair<int, string>(3, "Optional extras"),
                new KeyValuePair<int, string>(4, "Payment"),
                new KeyValuePair<int, string>(5, "Confirmation")
            };

        public const string HandBaggageCode = "BAGHAND";
        public const string HandBaggageCode_Infant = "BAGHANDI";
        public const string IncludedFreeMealCodeForEconomy = "EMEAL";

        public static readonly string[] IncludedHandBaggageCodes = { HandBaggageCode, HandBaggageCodeBusiness };
        //Added by a-5467 for Platinum changes - Start
        public const string HandBaggageCodeBusiness = "JBAGHAND";
        public const string HandBaggageCodeBusiness_Infant = "JBAGHANDI";
        public const string IncludedBaggageCodeForBusiness = "JBAG";
        public const string IncludedIFECodeForBusiness = "IFPJ";
        public const string IncludedFreeMealCodeForBusiness = "JMEAL";
        public const string IncludedFreeSeatCodeForBusiness = "JSEAT";
        public static int HandBaggageCodeBusinessWeight = 15;
        public const int IncludedBaggageCodeForBusinessWeight = 40;
        public const string BusinessCabin = "BUSINESS";
        public const string EconomyCabin = "ECONOMY";
        //Added by a-5467 for Platinum changes - End

        public static int InfantHandBaggageWeightBusiness = 5;
        public static int InfantHandBaggageWeightEconomy = 5;

        public const string SeatCodeBusiness = "SEAT";

        //A-5616
        public const string BaggageTypeByHand = "HandBaggage";
        public const string BaggageTypeByCheckedIn = "CheckedInBaggage";

        public const string BusinessDefaultMealText = "No Dietary Preference";
        public const string BusinessDefaultMealCode = "AAAA";
        public const int MaxNumCCFailures = 4;
        //Fare codes for which the SSRS are free
        public const string FreeMealCode = "INML";
        public const string FreeIFECode = "IFPP";
        public const string FreeSeatingCode = "INST";
        public const string FreeExcludedSeating = "XLGR";
        //Y class Meals CR
        public const string HotMealsInvCode = "MBRD";
        public const string WrapMealsInvCode = "SBRD";
        public const string NoMealsInvCode = "NOMEAL";
        public const string MealsIncluded = "MEALINCLUDED";
        public static List<string> Currencies = new List<string>
                                             {
                                                "AED",
                                                "AZN",
                                                "BDT",
                                                "BHD",
                                                "DJF",
                                                "EGP",
                                                "EUR",
                                                "INR",
                                                "JOD",
                                                "KWD",
                                                "LBP",
                                                "LKR",
                                                "NPR",
                                                "OMR",
                                                "PKR",
                                                "QAR",
                                                "RUB",
                                                "SAR",
                                                "SDG",
                                                "SYP",
                                                "USD"
                                             };

        public const int AdultPassengerInRestrictedSeatWheelchairOrHaveInfantAssigned = -1;

        public const string cardType_VISA = "VISA";
        public const string cardType_Mastercard = "MSCD";

        public const string paymentMethod_Voucher = "VCHR";
        public const string paymentMethod_Points = "PNTS";

        public const int noSpecificPassengerId = -100;

        // Code change by A-5476

        //public static List<string> RestrictedSeats = new List<string> 
        //    { 
        //        "1C", "2D", "15A", "15B", "15C", "15D", "15E", "15F", 
        //        "16A", "16B", "16C", "16D", "16E", "16F", "32C", "32D" 
        //    };

        public static List<string> RestrictedSeats = new List<string> 
            { 
                "15A", "15B", "15C", "15D", "15E", "15F", 
                "16A", "16B", "16C", "16D", "16E", "16F"
            };

        public static string BusCarrierCode = "BUS";
        public static string BusAirportCode = "ZZZ";

        public static string Pmnt = "PMNT";


        public struct MovieThumbnail
        {
            public const int Width = 100;
            public const int Height = 120;
        }

        // START A-5484:WR2:
        public static string DateTimePickerFormat = "dd/MM/yyyy";

        public static int EmailAddressMaximumLength = 64;

        // START A-5484:WR2:
        //WR6
        public const string PaymentErrorCode = "599";

        //Added for Ancillary sales in GDS booking
        public const string GDSPaymentCode = "TKNE";

        public const string nonseatsuccess = "SEAT SUCCESS";
        public const string nonseatfailure = "SEAT FAILURE";
        public const string seatsuccess = "NONSEAT SUCCESS";
        public const string seatfailure = "NONSEAT FAILURE";

        public const string SSRBaggage = "Baggage";
        public const string SSRSeat = "Seat";
        public const string SSRIFE = "IFE";
        public const string SSRMeals = "Meals";

        public const string TransDeatilsFailure = "FAILURE";
        public const string TransDeatilsSuccess = "SUCCESS";

        public const string FlxEmptySSR = "FLX EMPTY SSR";

        public const string FlxTimedOut = "timed out";

        public struct CustomerMiddlewareStatusCode
        {
            public const string Success = "00";
        }

        public struct CustomerMiddlewareStatus
        {
            public const string OK = "OK";
            public const string NOK = "NOK";
        }

        public const string MemberProfileStatusNonLoyal = "NL";

        public const string PhoneTypeMobile = "CEL";

        public const string SetProfileQuickEnrollAction = "QUICK_ENROLMENT";
        public const string SetProfileUpdateAction = "";
        public const string SetProfileUpdateExtendedAction = "EXTENDED_FIELD_UPDATE";

        public const string StatusNotValid = "NV";
        public const string StatusActive = "AC";
        public const string CorsOriginsSettingKey = "CorsOrigins";
        public const int BinNumberDigitsCount = 6;
        public const string AgreementParameterKey = "FOID_REQUIRED_IN_IB";

        public const string FareBrandingMealCode = "INML";
        public const string FareBrandingIFECode = "IFPP";
        public const string FareBrandingSeatCode = "INST";

        public const string MobileAppID = "MobileApp";

        public struct ExclusionListKeys
        {
            public const string ListForFFPAccrual = "ResExclusionListForFFPAccrual";
            public const string ListForFFPRedemption = "ResExclusionListForFFPRedemption";
        }

        public const int SessionTimeoutDuration = 30;
    }
}
