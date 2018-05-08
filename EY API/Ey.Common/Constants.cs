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

        public static Dictionary<string, string> FareBrandIds = new Dictionary<string, string>()
            {
                {"YB", "Economy Deal"},
                {"YS", "Economy Saver"},
                {"YV", "Economy Classic"},
                {"YF", "Economy Flex"},
                {"JB", "Business Deal"},
                {"JS", "Business Saver"},
                {"JF", "Business Flex"},
                {"FI", "First"}
            };

        public static Dictionary<string, string> AirportCountryCodes = new Dictionary<string, string>()
            {
            {"AUH","AE"},
                {"KBL","AF"},
{"KDH","AF"},
{"MZR","AF"},
{"OAI","AF"},
{"OAZ","AF"},
{"ALG","DZ"},
{"LAD","AO"},
{"EZE","AR"},
{"EVN","AM"},
{"ADL","AU"},
{"BNE","AU"},
{"MEL","AU"},
{"PER","AU"},
{"SYD","AU"},
{"VIE","AT"},
{"XWC","AT"},
{"GBB","AZ"},
{"GYD","AZ"},
{"BAH","BH"},
{"CGP","BD"},
{"DAC","BD"},
{"ZYL","BD"},
{"MSQ","BY"},
{"BRU","BE"},
{"SJJ","BA"},
{"GRU","BR"},
{"GIG","BR"},
{"BWN","BN"},
{"SOF","BG"},
{"BJM","BI"},
{"PNH","KH"},
{"YVR","CA"},
{"YYC","CA"},
{"YYZ","CA"},
{"SCL","CL"},
{"ANF","CL"},
{"CAN","CN"},
{"CGO","CN"},
{"CTU","CN"},
{"INC","CN"},
{"PVG","CN"},
{"PEK","CN"},
{"ABJ","CI"},
{"ZAG","HR"},
{"LCA","CY"},
{"PRG","CZ"},
{"CPH","DK"},
{"JIB","DJ"},
{"HBE","EG"},
{"CAI","EG"},
{"ALY","EG"},
{"ATZ","EG"},
{"LXR","EG"},
{"ASM","ER"},
{"ADD","ET"},
{"CDG","FR"},
{"LYS","FR"},
{"NCE","FR"},
{"TBS","GE"},
{"BUS","GE"},
{"HAM","DE"},
{"FRA","DE"},
{"DUS","DE"},
{"QYG","DE"},
{"MUC","DE"},
{"ACC","GH"},
{"BHX","GB"},
{"GLA","GB"},
{"MAN","GB"},
{"LHR","GB"},
{"LON","GB"},
{"LGW","GB"},
{"NCL","GB"},
{"ATH","GR"},
{"CKY","GN"},
{"HKG","HK"},
{"BUD","HU"},
{"BOM","IN"},
{"BLR","IN"},
{"CCJ","IN"},
{"CCU","IN"},
{"DEL","IN"},
{"COK","IN"},
{"BHO","IN"},
{"AMD","IN"},
{"GOI","IN"},
{"HYD","IN"},
{"LKO","IN"},
{"MAA","IN"},
{"TRV","IN"},
{"DPS","ID"},
{"CGK","ID"},
{"BND","IR"},
{"AWZ","IR"},
{"HDM","IR"},
{"IFN","IR"},
{"IKA","IR"},
{"TBZ","IR"},
{"SYZ","IR"},
{"MHD","IR"},
{"LRR","IR"},
{"NJF","IQ"},
{"ISU","IQ"},
{"EBL","IQ"},
{"BGW","IQ"},
{"BSR","IQ"},
{"DUB","IE"},
{"FCO","IT"},
{"BLQ","IT"},
{"MXP","IT"},
{"TRS","IT"},
{"VCE","IT"},
{"NRT","JP"},
{"KIX","JP"},
{"HND","JP"},
{"AMM","JO"},
{"TYO","JO"},
{"TSE","KZ"},
{"ALA","KZ"},
{"CIT","KZ"},
{"NBO","KE"},
{"ICN","KR"},
{"KWI","KW"},
{"OSS","KG"},
{"FRU","KG"},
{"BEY","LB"},
{"TIP","LI"},
{"SKP","MK"},
{"KUL","MY"},
{"MLE","MV"},
{"MLA","MT"},
{"MRU","MU"},
{"MEX","FM"},
{"KIV","MD"},
{"TIV","ME"},
{"TGD","ME"},
{"CMN","MA"},
{"RGN","MM"},
{"KTM","NP"},
{"AMS","NL"},
{"AKL","NZ"},
{"CHC","NZ"},
{"ABV","NG"},
{"LOS","NG"},
{"OSL","NO"},
{"MCT","OM"},
{"SLL","OM"},
{"SKT","PK"},
{"UET","PK"},
{"MUX","PK"},
{"LYP","PK"},
{"LHE","PK"},
{"PEW","PK"},
{"KHI","PK"},
{"ISB","PK"},
{"CRK","PH"},
{"CEB","PH"},
{"MNL","PH"},
{"WAW","PL"},
{"LIS","PT"},
{"KRK","PT"},
{"DOH","QA"},
{"OTP","RO"},
{"OVB","RU"},
{"ROV","RU"},
{"LED","RU"},
{"KZN","RU"},
{"MOW","RU"},
{"MRV","RU"},
{"MCX","RU"},
{"UFA","RU"},
{"VKO","RU"},
{"VOG","RU"},
{"VOZ","RU"},
{"SVO","RU"},
{"SVX","RU"},
{"DME","RU"},
{"GOJ","RU"},
{"KRR","RU"},
{"KUF","RU"},
{"KGL","RW"},
{"HAS","SA"},
{"JED","SA"},
{"HOF","SA"},
{"GIZ","SA"},
{"DMM","SA"},
{"ELQ","SA"},
{"EAM","SA"},
{"AHB","SA"},
{"AJF","SA"},
{"TIF","SA"},
{"TUU","SA"},
{"YNB","SA"},
{"MED","SA"},
{"RUH","SA"},
{"DKR","SN"},
{"BEG","RS"},
{"SEZ","SC"},
{"SIN","SG"},
{"BTS","SK"},
{"MBX","SI"},
{"LJU","SI"},
{"HGA","SO"},
{"DUR","ZA"},
{"JNB","ZA"},
{"CPT","ZA"},
{"BCN","ES"},
{"MAD","ES"},
{"CMB","LK"},
{"HRI","LK"},
{"KRT","SD"},
{"PZU","SD"},
{"ARN","SE"},
{"GVA","CH"},
{"ZRH","CH"},
{"DAM","SY"},
{"TPE","TW"},
{"DYU","TJ"},
{"JRO","TZ"},
{"DAR","TZ"},
{"ZNZ","TZ"},
{"BKK","TH"},
{"HKT","TH"},
{"TUN","TN"},
{"SAW","TR"},
{"IST","TR"},
{"ASB","TM"},
{"EBB","UG"},
{"DOK","UA"},
{"HRK","UA"},
{"IEV","UA"},
{"KBP","UA"},
{"ODS","UA"},
{"RKT","AE"},
{"DWC","AE"},
{"DXB","AE"},
{"EXP","AE"},
{"AAN","AE"},
{"AZI","AE"},
{"DFW","US"},
{"BOS","US"},
{"FLL","US"},
{"JFK","US"},
{"IAD","US"},
{"IAH","US"},
{"SEA","US"},
{"ORD","US"},
{"MCO","US"},
{"LAX","US"},
{"SFO","US"},
{"MSP","UY"},
{"SAT","UY"},
{"RDU","UY"},
{"PHX","UY"},
{"EWR","UY"},
{"BBB","UY"},
{"BHK","UZ"},
{"TAS","UZ"},
{"SGN","VN"},
{"HAN","VN"},
{"ADE","YE"},
{"SAH","YE"},
{"LUN","ZM"},
{"HRE","ZW"},
{"JUB","SS"}
            };


        public static Dictionary<string, string> AirportCurrencyCodes = new Dictionary<string, string>()
        {
            {"AAN","AED"},
{"ABJ","USD"},
{"ABV","USD"},
{"ACC","USD"},
{"ADD","USD"},
{"ADE","USD"},
{"ADL","USD"},
{"AHB","SAR"},
{"AJF","SAR"},
{"AKL","USD"},
{"ALA","KZT"},
{"ALG","USD"},
{"ALY","EGP"},
{"AMD","INR"},
{"AMM","JOD"},
{"AMS","USD"},
{"ANF","USD"},
{"ARN","USD"},
{"ASB","USD"},
{"ASM","USD"},
{"ATH","USD"},
{"ATZ","EGP"},
{"AUH","AED"},
{"AWZ","USD"},
{"AZI","AED"},
{"BAH","BHD"},
{"BBB","USD"},
{"BCN","USD"},
{"BEG","EUR"},
{"BEY","USD"},
{"BGW","USD"},
{"BHK","USD"},
{"BHO","INR"},
{"BHX","USD"},
{"BJM","USD"},
{"BKK","THB"},
{"BLQ","USD"},
{"BLR","USD"},
{"BND","USD"},
{"BNE","USD"},
{"BOM","INR"},
{"BOS","USD"},
{"BRU","USD"},
{"BSR","USD"},
{"BTS","EUR"},
{"BUD","USD"},
{"BUS","USD"},
{"BWN","USD"},
{"CAI","USD"},
{"CAN","USD"},
{"CCJ","USD"},
{"CCU","USD"},
{"CDG","USD"},
{"CEB","USD"},
{"CGK","USD"},
{"CGO","USD"},
{"CGP","USD"},
{"CHC","USD"},
{"CIT","KZT"},
{"CKY","USD"},
{"CMB","LKR"},
{"CMN","USD"},
{"COK","INR"},
{"CPH","USD"},
{"CPT","USD"},
{"CRK","USD"},
{"CTU","USD"},
{"DAC","USD"},
{"DAM","SYP"},
{"DAR","USD"},
{"DEL","INR"},
{"DFW","USD"},
{"DKR","USD"},
{"DME","USD"},
{"DMM","SAR"},
{"DOH","QAR"},
{"DOK","USD"},
{"DPS","USD"},
{"DUB","USD"},
{"DUR","USD"},
{"DUS","USD"},
{"DWC","AED"},
{"DXB","AED"},
{"DYU","USD"},
{"EAM","SAR"},
{"EBB","USD"},
{"EBL","USD"},
{"ELQ","SAR"},
{"EVN","USD"},
{"EWR","USD"},
{"EXP","AED"},
{"EZE","USD"},
{"FCO","USD"},
{"FLL","USD"},
{"FRA","USD"},
{"FRU","USD"},
{"GBB","USD"},
{"GIG","USD"},
{"GIZ","SAR"},
{"GLA","USD"},
{"GOI","INR"},
{"GOJ","RUB"},
{"GRU","USD"},
{"GVA","USD"},
{"GYD","USD"},
{"HAM","USD"},
{"HAN","USD"},
{"HAS","SAR"},
{"HBE","EGP"},
{"HDM","USD"},
{"HGA","USD"},
{"HKG","USD"},
{"HKT","USD"},
{"HND","USD"},
{"HOF","SAR"},
{"HRE","USD"},
{"HRI","LKR"},
{"HRK","USD"},
{"HYD","INR"},
{"IAD","USD"},
{"IAH","USD"},
{"ICN","USD"},
{"IEV","USD"},
{"IFN","USD"},
{"IKA","USD"},
{"INC","USD"},
{"ISB","USD"},
{"IST","USD"},
{"ISU","USD"},
{"JED","SAR"},
{"JFK","USD"},
{"JIB","USD"},
{"JNB","USD"},
{"JRO","USD"},
{"JUB","USD"},
{"KBL","USD"},
{"KBP","USD"},
{"KDH","USD"},
{"KGL","USD"},
{"KHI","PKR"},
{"KIV","EUR"},
{"KIX","USD"},
{"KRK","PLN"},
{"KRR","RUB"},
{"KRT","AED"},
{"KTM","NPR"},
{"KUF","RUB"},
{"KUL","USD"},
{"KWI","KWD"},
{"KZN","RUB"},
{"LAD","USD"},
{"LAX","USD"},
{"LCA","USD"},
{"LED","USD"},
{"LGW","USD"},
{"LHE","USD"},
{"LHR","USD"},
{"LIS","USD"},
{"LJU","EUR"},
{"LKO","INR"},
{"LON","USD"},
{"LOS","USD"},
{"LRR","USD"},
{"LUN","USD"},
{"LXR","EGP"},
{"LYP","PKR"},
{"LYS","USD"},
{"MAA","INR"},
{"MAD","USD"},
{"MAN","USD"},
{"MBX","EUR"},
{"MCO","USD"},
{"MCT","OMR"},
{"MCX","RUB"},
{"MED","SAR"},
{"MEL","USD"},
{"MEX","USD"},
{"MHD","USD"},
{"MLA","USD"},
{"MLE","USD"},
{"MNL","USD"},
{"MOW","RUB"},
{"MRU","USD"},
{"MRV","RUB"},
{"MSP","USD"},
{"MSQ","EUR"},
{"MUC","USD"},
{"MUX","PKR"},
{"MXP","USD"},
{"MZR","USD"},
{"NBO","USD"},
{"NCE","USD"},
{"NCL","USD"},
{"NJF","USD"},
{"NRT","USD"},
{"OAI","USD"},
{"OAZ","USD"},
{"ODS","USD"},
{"ORD","USD"},
{"OSL","USD"},
{"OSS","USD"},
{"OTP","EUR"},
{"OVB","RUB"},
{"PEK","USD"},
{"PER","USD"},
{"PEW","USD"},
{"PHX","USD"},
{"PNH","USD"},
{"PRG","CZK"},
{"PVG","USD"},
{"PZU","AED"},
{"QYG","EUR"},
{"RDU","USD"},
{"RGN","USD"},
{"RKT","AED"},
{"ROV","RUB"},
{"RUH","SAR"},
{"SAH","USD"},
{"SAT","USD"},
{"SAW","USD"},
{"SCL","USD"},
{"SEA","USD"},
{"SEZ","USD"},
{"SFO","USD"},
{"SGN","USD"},
{"SIN","USD"},
{"SJJ","EUR"},
{"SKP","EUR"},
{"SKT","PKR"},
{"SLL","OMR"},
{"SOF","EUR"},
{"SVO","RUB"},
{"SVX","RUB"},
{"SYD","USD"},
{"SYZ","USD"},
{"TAS","USD"},
{"TBS","USD"},
{"TBZ","USD"},
{"TGD","EUR"},
{"TIF","SAR"},
{"TIP","USD"},
{"TIV","EUR"},
{"TPE","USD"},
{"TRS","EUR"},
{"TRV","INR"},
{"TSE","KZT"},
{"TUN","USD"},
{"TUU","SAR"},
{"TYO","USD"},
{"UET","PKR"},
{"UFA","RUB"},
{"VCE","USD"},
{"VIE","USD"},
{"VKO","RUB"},
{"VOG","RUB"},
{"VOZ","RUB"},
{"WAW","USD"},
{"XWC","EUR"},
{"YNB","SAR"},
{"YVR","USD"},
{"YYC","USD"},
{"YYZ","USD"},
{"ZAG","USD"},
{"ZNZ","USD"},
{"ZRH","USD"},
{"ZYL","USD"}
        };
    }
}
