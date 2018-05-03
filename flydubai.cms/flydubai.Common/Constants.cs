using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common
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

        public const string BFEECharge = "BFEE";

        public const string InsuranceReversal = "INSC";

        public const string FlydubaiCarrierCode = "FZ";

        public const string EmiratesCarrierCode = "EK";

        public const string FZHUBAirportCode = "DXB";

        public const string ReceiptLanguageId = "1";

        public const string NotApplicable = "NA";

        public const string SeriesNumber = "299";

        public const string User = "WEB2_LIVE";

        public const string MobileUser = "WEB_MOBILE";

        public const string CorporateUser = "CORPORATE";

        public const string DefaultLanguage = "en";

        public const int LanguageKeyEnglish = 1;

        public const string EmailRegex = @"^([a-zA-Z0-9])+(\.?[a-zA-Z0-9_-])*@([a-zA-Z0-9-])+(\.[a-zA-Z0-9_-]+)+$";

        public const string TelephoneRegex = @"^(\+?[0-9]*)?\s*(\([0-9]*\))?[\s\-/0-9]*$";

        public static Dictionary<string, string> Carriers = new Dictionary<string, string>()
            {
                {"FZ", "flydubai"},
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

        //Added by a-5467 for Platinum changes - Start
        public const string HandBaggageCodeBusiness = "JBAGHAND";
        public const string IncludedBaggageCodeForBusiness = "JBAG";
        public const string IncludedIFECodeForBusiness = "IFPJ";
        public const string IncludedFreeMealCodeForBusiness = "JMEAL";
        public const string IncludedFreeSeatCodeForBusiness = "JSEAT";
        public static int HandBaggageCodeBusinessWeight = 14;
        public const int IncludedBaggageCodeForBusinessWeight = 40;
        public const string BusinessCabin = "BUSINESS";
        public const string EconomyCabin = "ECONOMY";
        //Added by a-5467 for Platinum changes - End
        //A-5616
        public const string BaggageTypeByHand = "HandBaggage";
        public const string BaggageTypeByCheckedIn = "CheckedInBaggage";

        //Infant baggage 
        public const string HandBaggageCodeInfantEconomy = "BAGHANDI";
        public const string HandBaggageCodeInfantBusiness = "JBAGHANDI";
        public const string IncludedBaggageCodeInfantEconomy = "BAGI";
        public const string IncludedBaggageCodeInfantBusiness = "BAGI";
        //public static int InfantHandBaggageCodeWeight = 5;
        public const string InfantHandBagWeightEconomyKey = "InfantHandBagWeightEconomy";
        public const string InfantHandBagWeightBusinessKey = "InfantHandBagWeightBusiness";

        public const int MaxNumCCFailures = 4;
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

        //EP:WR-14:A-4740: FareBasis Standardization impact on web - Start
        public const string EconomyPayToChange = "pay to change";
        public const string EconomyFreeToChange = "free to change";
        public const string EconomySpecialOffer = "no change";
        public const string BusinessBasic = "basic";
        public const int BinNumberDigitsCount = 6;
        //EP:WR-14:A-4740: FareBasis Standardization impact on web - End

        public struct ExclusionListKeys
        {
            public const string ListForFFPAccrual = "ResExclusionListForFFPAccrual";
            public const string ListForFFPRedemption = "ResExclusionListForFFPRedemption";
        }

        //Fare Branding changes
        public const string FareBrandingMealCode = "INML";
        public const string FareBrandingIFECode = "IFPP";
        public const string FareBrandingSeatCode = "INST";

        public const string FareQuoteChannelIDTA = "TA";
        public const string FareQuoteChannelIDMobile = "MOB";
        public const string FareQuoteChannelIDOldWeb = "MOB";

        public static Dictionary<int, string> EconomyFareTypeIds = new Dictionary<int, string>()
            {
                {1, "Product-1"},
                {2, "Product-2"},
                {3, "Product-3"},
                {6, "Product-4"},
                {7, "Product-5"},
                {8, "Product-6"},
                {9, "Product-7"}
            };

        public static Dictionary<int, string> BusinessFareTypeIds = new Dictionary<int, string>()
            {
                {4, "Product-1"},
                {5, "Product-2"}
            };

        //Interline changes
        public const string AgreementParameterKey = "FOID_REQUIRED_IN_IB";
        //Holidays changes
        public const string HolidayReservationType = "HOLIDAYS";        

        //MultiCity changes
        public struct PaxCode
        {
            public const string Adult = "ADT";
            public const string Child = "CHD";
            public const string Infant = "INF";
        }

        public const string Channel = "INVENT";
    }
}
