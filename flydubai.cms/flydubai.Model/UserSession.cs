using System;
using System.Collections.Generic;
using System.Linq;

using flydubai.Common;
using flydubai.Common.Exceptions;
using flydubai.Common.Model;
using flydubai.Model.Journey;
using flydubai.Model.Modify;
using flydubai.Model.OptionalExtras.Seating;
using flydubai.Model.Profiles;
using flydubai.Model.Results;
using flydubai.Model.Search;
using flydubai.Model.Session;
using flydubai.Model.Payment;


using System.Configuration;
namespace flydubai.Model
{
    using flydubai.Model.Booking;
    using flydubai.Model.Merchandising.FLX;

    /// <summary>
    /// User Session
    /// </summary>
    [Serializable]
    public class UserSession : IUserSession, IRadixxSession
    {
        private readonly ISessionStorage sessionStorage;

        // Present for serialisation only - not for use.
        public UserSession()
        {
            sessionStorage = new NonPersistedSessionStorage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSession"/> class.
        /// </summary>
        /// <param name="sessionStorage">The session storage.</param>
        public UserSession(ISessionStorage sessionStorage)
        {
            this.sessionStorage = sessionStorage;
        }

        public string Token
        {
            get
            {
                if (this.RadixxSessionHasExpired)
                {
                    throw new SessionExpiredException("Radixx Session Expired");
                }

                if (!this.sessionStorage.ContainsKey("RadixxSessionToken"))
                {
                    throw new SessionExpiredException();
                }

                return this.sessionStorage["RadixxSessionToken"] as string;
            }

            set
            {
                this.TokenExpiry = DateTime.UtcNow + new TimeSpan(0, Convert.ToInt32(ConfigurationManager.AppSettings["RadixxTokenTimeout"]), 0);
                this.sessionStorage["RadixxSessionToken"] = value;
            }
        }

        public string FirstTimeLoginFlag
        {
            get
            {
                return this.sessionStorage["FirstTimeLoginFlag"] as string;

            }
            set
            {
                this.sessionStorage["FirstTimeLoginFlag"] = value;
            }

        }

        public string CheckSum_AgencyMgt
        {
            get
            {
                return this.sessionStorage["CheckSum_AgencyMgt"] as string;

            }
            set
            {
                this.sessionStorage["CheckSum_AgencyMgt"] = value;
            }

        }


        public string CheckSum_BusLink
        {
            get
            {
                return this.sessionStorage["CheckSum_BusLink"] as string;

            }
            set
            {
                this.sessionStorage["CheckSum_BusLink"] = value;
            }

        }

        public string CheckSum_ReportsLink
        {
            get
            {
                return this.sessionStorage["CheckSum_ReportsLink"] as string;

            }
            set
            {
                this.sessionStorage["CheckSum_ReportsLink"] = value;
            }

        }


        public string ProfileToken
        {
            get
            {
                if (this.RadixxProfileSessionHasExpired)
                {
                    return null;
                }

                if (!this.sessionStorage.ContainsKey("RadixxProfileSessionToken"))
                {
                    return null;
                }

                return this.sessionStorage["RadixxProfileSessionToken"] as string;
            }

            set
            {
                this.ProfileTokenExpiry = DateTime.UtcNow + new TimeSpan(0, 30, 0);
                this.sessionStorage["RadixxProfileSessionToken"] = value;
            }
        }

        public string CorporateIATA
        {
            get
            {
                return this.sessionStorage["CorporateIATA"] as string;
            }
            set
            {
                this.sessionStorage["CorporateIATA"] = value;
            }
        }

        public bool RadixxSessionHasExpired
        {
            get
            {
                return this.TokenExpiry.HasValue && this.TokenExpiry < DateTime.UtcNow;
            }
        }

        public bool RadixxProfileSessionHasExpired
        {
            get
            {
                return this.ProfileTokenExpiry.HasValue && this.ProfileTokenExpiry < DateTime.UtcNow;
            }
        }

        private DateTime? TokenExpiry
        {
            get
            {
                return this.sessionStorage["TokenExpiry"] as DateTime?;
            }

            set
            {
                this.sessionStorage["TokenExpiry"] = value;
            }
        }

        private DateTime? ProfileTokenExpiry
        {
            get
            {
                return this.sessionStorage["ProfileTokenExpiry"] as DateTime?;
            }

            set
            {
                this.sessionStorage["ProfileTokenExpiry"] = value;
            }
        }

        public string UserIata
        {
            get
            {
                return this.Profile is TAProfile ? (this.Profile as TAProfile).IataNum : string.Empty;//this.Iata;
            }
        }


        public string Iata
        {
            get
            {
                return this.TAProfile is TravelAgentProfile ? (this.TAProfile as TravelAgentProfile).IataNum : string.Empty;//this.Iata;
            }
        }

        public string Username
        {
            get
            {
                return this.TAProfile is TravelAgentProfile ? (this.TAProfile as TravelAgentProfile).Username : this.Username;
            }
        }

        // End TA code
        public string RadixxChannelUser
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("RadixxChannelUser"))
                    return Constants.User;
                else
                    return this.sessionStorage["RadixxChannelUser"] as string;
            }

            set
            {
                this.sessionStorage["RadixxChannelUser"] = value;
            }
        }

        public string ClientIpAddress
        {
            get
            {
                if (this.sessionStorage["ClientIpAddress"] != null)
                {
                    return this.sessionStorage["ClientIpAddress"] as string;
                }
                return string.Empty;
            }

            set
            {
                this.sessionStorage["ClientIpAddress"] = value;
            }
        }

        public ProfileBase Profile
        {
            get
            {
                return this.sessionStorage["Profile"] as ProfileBase;
            }

            set
            {
                this.sessionStorage["Profile"] = value;
            }
        }

        public bool InvoiceStatus
        {
            get
            {
                var result = false;
                if (this.sessionStorage.ContainsKey("InvoiceStatus"))
                {
                    result = bool.Parse(this.sessionStorage["InvoiceStatus"].ToString());
                    return result;
                }
                else
                    throw new SessionExpiredException();
            }
            set
            {
                this.sessionStorage["InvoiceStatus"] = value;
            }
        }

        public AuthenticateTAUser TAProfile
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("TAProfile"))
                {
                    throw new SessionExpiredException();
                }
                return this.sessionStorage["TAProfile"] as AuthenticateTAUser;
            }

            set
            {
                this.sessionStorage["TAProfile"] = value;
            }
        }
        public SearchCriteria SearchCriteria
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("SearchCriteria"))
                {
                    throw new SessionExpiredException();
                }

                return this.sessionStorage["SearchCriteria"] as SearchCriteria;
            }

            set
            {
                this.sessionStorage["SearchCriteria"] = value;
            }
        }

        public JourneyResults JourneyResults
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("JourneyResults"))
                {
                    throw new SessionExpiredException();
                }

                return this.sessionStorage["JourneyResults"] as JourneyResults;
            }

            set
            {
                this.sessionStorage["JourneyResults"] = value;
            }
        }

        public bool IsOutboundReloaded
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("OutboundReloaded"))
                {
                    return false;
                }
                return bool.Parse(Convert.ToString(this.sessionStorage["OutboundReloaded"]));
            }
            set
            {
                this.sessionStorage["OutboundReloaded"] = value;
            }
        }

        public List<FlightUpsellFares> UpsellFares
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("UpsellFares") || this.sessionStorage["UpsellFares"] == null)
                {
                    this.sessionStorage["UpsellFares"] = new List<FlightUpsellFares>();
                }

                return this.sessionStorage["UpsellFares"] as List<FlightUpsellFares>;
            }

            set
            {
                this.sessionStorage["UpsellFares"] = value;
            }
        }

        /// <summary>
        /// Gets the flight upsell fares.
        /// </summary>
        /// <param name="lfid">The lfid.</param>
        /// <param name="departureDate">The departure date.</param>
        /// <returns></returns>
        public IEnumerable<FlightFare> GetFlightUpsellFares(int lfid, DateTime departureDate)
        {
            var upsellFares =
                this.UpsellFares.FirstOrDefault(uf => uf.LFID == lfid && uf.DepartureDate.Date == departureDate.Date);

            return (upsellFares == null) ? new List<FlightFare>() : upsellFares.UpsellFlightFares;
        }

        public YourJourney YourJourney
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("YourJourney"))
                {
                    throw new SessionExpiredException();
                }

                return this.sessionStorage["YourJourney"] as YourJourney;
            }

            set
            {
                this.sessionStorage["YourJourney"] = value;
            }
        }

        public YourJourney OriginalYourJourney
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("OriginalYourJourney"))
                {
                    throw new SessionExpiredException();
                }

                return this.sessionStorage["OriginalYourJourney"] as YourJourney;
            }

            set
            {
                this.sessionStorage["OriginalYourJourney"] = value;
            }
        }

        public Enums.WizardStep CreatePnrWizardStep
        {
            get
            {
                Enums.WizardStep returnStep = Enums.WizardStep.SelectYourFlight;
                Enum.TryParse<Enums.WizardStep>(this.sessionStorage["CreatePnrWizardStep"].ToString(), out returnStep);
                return returnStep;
            }

            set
            {
                this.sessionStorage["CreatePnrWizardStep"] = value;
            }
        }

        public PassengerNameRecord PassengerNameRecord
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("PassengerNameRecord"))
                {
                    return null;
                }

                return this.sessionStorage["PassengerNameRecord"] as PassengerNameRecord;
            }

            set
            {
                this.sessionStorage["PassengerNameRecord"] = value;
            }
        }

        public PassengerNameRecord AmendedPassengerNameRecord
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("AmendedPassengerNameRecord"))
                {
                    return null;
                }

                return this.sessionStorage["AmendedPassengerNameRecord"] as PassengerNameRecord;
            }

            set
            {
                this.sessionStorage["AmendedPassengerNameRecord"] = value;
            }
        }

        public PassengerNameRecord OriginalPNR
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("OriginalPNR"))
                {
                    return null;
                }

                return this.sessionStorage["OriginalPNR"] as PassengerNameRecord;
            }

            set
            {
                this.sessionStorage["OriginalPNR"] = value;
            }
        }

        public PassengerNameRecord TFEEAssessedPNR
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("TFEEAssessedPNR"))
                {
                    return null;
                }

                return this.sessionStorage["TFEEAssessedPNR"] as PassengerNameRecord;
            }

            set
            {
                this.sessionStorage["TFEEAssessedPNR"] = value;
            }
        }

        public List<ModifiedFlight> ModifiedFlights
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("ModifiedFlight"))
                {
                    this.sessionStorage["ModifiedFlight"] = new List<ModifiedFlight>();
                }

                return this.sessionStorage["ModifiedFlight"] as List<ModifiedFlight>;
            }
        }

        public string LogicalFlightKeyToReplace
        {
            get { return this.sessionStorage["LogicalFlightKeyToReplace"] as string; }
            set { this.sessionStorage["LogicalFlightKeyToReplace"] = value; }
        }

        public int VoucherSequenceNumber
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("VoucherSequenceNumber")
                    || this.sessionStorage["VoucherSequenceNumber"] == null)
                {
                    this.sessionStorage["VoucherSequenceNumber"] = 1;
                }

                return (int)this.sessionStorage["VoucherSequenceNumber"];
            }

            set
            {
                this.sessionStorage["VoucherSequenceNumber"] = value;
            }
        }

        public List<JourneyServiceQuote> ServiceQuotes
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("JourneyServiceQuote"))
                {
                    return null;
                }

                return this.sessionStorage["JourneyServiceQuote"] as List<JourneyServiceQuote>;
            }

            set
            {
                this.sessionStorage["JourneyServiceQuote"] = value;
            }
        }

        public List<JourneyServiceQuote> TempServiceQuotes
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("TempServiceQuotes"))
                {
                    return null;
                }

                return this.sessionStorage["TempServiceQuotes"] as List<JourneyServiceQuote>;
            }

            set
            {
                this.sessionStorage["TempServiceQuotes"] = value;
            }
        }

        public List<AirlinePerson> PassengersRemoved
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("PassengersRemoved"))
                {
                    this.sessionStorage["PassengersRemoved"] = new List<AirlinePerson>();
                }

                return this.sessionStorage["PassengersRemoved"] as List<AirlinePerson>;
            }

            set
            {
                this.sessionStorage["PassengersRemoved"] = value;
            }
        }

        public bool PnrHasBeenCommited
        {
            get
            {
                var result = false;

                if (this.PassengerNameRecord != null)
                {
                    result = !string.IsNullOrWhiteSpace(this.PassengerNameRecord.ConfirmationNumber);
                }

                return result;
            }
        }

        public bool IsInModifyMode
        {
            get
            {
                if (this.AmendedPassengerNameRecord != null)
                {
                    return true;
                }
                return false;
            }
        }

        //public bool IsSearchInMultiCity
        //{
        //    get
        //    {
        //        if (!this.sessionStorage.ContainsKey("IsSearchInMultiCity") || this.sessionStorage["IsSearchInMultiCity"] == null)
        //        {
        //            return false;
        //        }

        //        return bool.Parse(this.sessionStorage["IsSearchInMultiCity"].ToString());
        //    }

        //    set
        //    {
        //        this.sessionStorage["IsSearchInMultiCity"] = value;
        //    }
        //}

        public CancelPNRDetails CancelPnrDetails
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("CancelPnrDetails")
                    || this.sessionStorage["CancelPnrDetails"] == null)
                {
                    return null;
                }

                return (CancelPNRDetails)this.sessionStorage["CancelPnrDetails"];
            }

            set
            {
                this.sessionStorage["CancelPnrDetails"] = value;
            }
        }

        public bool IsShowAmendmentsBackButonned
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("IsShowAmendmentsBackButonned") || this.sessionStorage["IsShowAmendmentsBackButonned"] == null)
                {
                    return false;
                }

                return bool.Parse(this.sessionStorage["IsShowAmendmentsBackButonned"].ToString());
            }

            set
            {
                this.sessionStorage["IsShowAmendmentsBackButonned"] = value;
            }
        }

        public List<CircularFlight> CircularFlights
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("CircularFlights"))
                {
                    this.sessionStorage["CircularFlights"] = new List<CircularFlight>();
                }

                return this.sessionStorage["CircularFlights"] as List<CircularFlight>;
            }

            set
            {
                this.sessionStorage["CircularFlights"] = value;
            }

        }

        public bool IsNewInsuranceQuoteGreater
        {
            get
            {
                return bool.Parse(this.sessionStorage["IsNewInsuranceQuoteGreater"].ToString());
            }

            set
            {
                this.sessionStorage["IsNewInsuranceQuoteGreater"] = value;
            }
        }

        public decimal InsuranceQuoteGreaterByAmount
        {
            get
            {
                return decimal.Parse(this.sessionStorage["InsuranceQuoteGreaterByAmount"].ToString());
            }

            set
            {
                this.sessionStorage["InsuranceQuoteGreaterByAmount"] = value;
            }
        }

        public bool ConfirmedPNR
        {
            get
            {
                return bool.Parse(this.sessionStorage["ConfirmedPNR"].ToString());
            }

            set
            {
                this.sessionStorage["ConfirmedPNR"] = value;
            }
        }

        public bool AddedPassenger
        {
            get
            {
                return bool.Parse(this.sessionStorage["AddedPassenger"].ToString());
            }

            set
            {
                this.sessionStorage["AddedPassenger"] = value;
            }
        }

        /// <summary>
        /// Identify whether in the booking flow.
        /// </summary>
        /// 
        public bool isBookingFlow
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("isBookingFlow"))
                {
                    throw new SessionExpiredException();
                }
                return bool.Parse(this.sessionStorage["isBookingFlow"].ToString());
            }

            set
            {
                this.sessionStorage["isBookingFlow"] = value;
            }
        }


        public bool hasSSRChanged
        {
            get
            {
                return bool.Parse(this.sessionStorage["hasSSRChanged"].ToString());
            }

            set
            {
                this.sessionStorage["hasSSRChanged"] = value;
            }
        }

        //  Start A-5469: WR2 : FR:027
        public string CheckSum_EditPassengerLink
        {
            get
            {
                return this.sessionStorage["CheckSum_EditPassengerLink"] as string;

            }
            set
            {
                this.sessionStorage["CheckSum_EditPassengerLink"] = value;
            }

        }

        // End  A-5469: WR2 : FR:027

        // START A-5484:WR2:FR028 
        /// <summary>
        /// IsToUpdateAPISForPassportAndNationality - 
        /// </summary>
        public bool IsToUpdateAPISForPassportAndNationality
        {
            get
            {
                return (this.sessionStorage["IsToUpdateAPISForPassportAndNationality"] != null) ?
                    bool.Parse(this.sessionStorage["IsToUpdateAPISForPassportAndNationality"].ToString()) : false;
            }

            set
            {
                this.sessionStorage["IsToUpdateAPISForPassportAndNationality"] = value;
            }
        }
        // END A-5484:WR2:FR028

        // START A-5469:WR4:FR012 
        /// <summary>
        /// IsToUpdateAPIS - 
        /// </summary>
        public bool IsToUpdateAPIS
        {
            get
            {
                return (this.sessionStorage["IsToUpdateAPIS"] != null) ?
                    bool.Parse(this.sessionStorage["IsToUpdateAPIS"].ToString()) : false;
            }

            set
            {
                this.sessionStorage["IsToUpdateAPIS"] = value;
            }
        }
        // END A-5469:WR2:FR028

        // START A-5469 WR4:FR:012
        public List<JourneyPassenger> Api
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("Api"))
                {
                    this.sessionStorage["Api"] = new List<JourneyPassenger>();
                }

                return this.sessionStorage["Api"] as List<JourneyPassenger>;
            }

            set
            {
                this.sessionStorage["Api"] = value;
            }

        }

        // END A-5469 WR4:FR:012
        //A-4740: Ancillary sales in GDS booking - Start
        public bool IsValidGDS
        {
            get
            {
                return (this.sessionStorage["IsValidGDS"] != null) ?
                    bool.Parse(this.sessionStorage["IsValidGDS"].ToString()) : false;
            }

            set
            {
                this.sessionStorage["IsValidGDS"] = value;
            }
        }
        //A-4740: Ancillary sales in GDS booking - End



        public string PaymentMerchantID
        {
            get
            {
                return this.sessionStorage["PaymentMerchantID"] as string;
            }

            set
            {
                this.sessionStorage["PaymentMerchantID"] = value;
            }
        }

        public int RetryCountFromTimeout
        {
            get
            {
                if (this.sessionStorage.ContainsKey("RetryCountFromTimeout") && this.sessionStorage["RetryCountFromTimeout"] != null)
                {
                    return (int)this.sessionStorage["RetryCountFromTimeout"];
                }

                return 0;
            }

            set
            {
                this.sessionStorage["RetryCountFromTimeout"] = value;
            }
        }

        public string RetryMerchTxnRef
        {
            get
            {
                return this.sessionStorage["RetryMerchTxnRef"] as string;
            }

            set
            {
                this.sessionStorage["RetryMerchTxnRef"] = value;
            }
        }

        public bool TokenToGenerate(int Config)
        {
            TimeSpan? tsTokenExpiryRem = this.TokenExpiry - DateTime.UtcNow;
            TimeSpan tsConfig = new TimeSpan(0, Config, 0);

            if (tsTokenExpiryRem < tsConfig)
                return true;
            else
                return false;
        }

        public object GTMValues
        {
            get
            {
                return this.sessionStorage["GTMValues"] as object;
            }

            set
            {
                this.sessionStorage["GTMValues"] = value;
            }
        }


        public MigsDetails MigsDetails
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("MigsDetails")
                    || this.sessionStorage["MigsDetails"] == null)
                {
                    return null;
                }

                return (MigsDetails)this.sessionStorage["MigsDetails"];
            }

            set
            {
                this.sessionStorage["MigsDetails"] = value;
            }
        }

        public string GTMfareType
        {
            get
            {
                return this.sessionStorage["GTMfareType"] as string;
            }

            set
            {
                this.sessionStorage["GTMfareType"] = value;
            }
        }

        public Nullable<bool> IsPrimaryGatewayIsActive
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("IsPrimaryGatewayIsActive")
                    || this.sessionStorage["IsPrimaryGatewayIsActive"] == null)
                {
                    return null;
                }

                return (Nullable<bool>)this.sessionStorage["IsPrimaryGatewayIsActive"];
            }

            set
            {
                this.sessionStorage["IsPrimaryGatewayIsActive"] = value;
            }
        }

        public Nullable<bool> IsThirdPartyCookieEnabled
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("IsThirdPartyCookieEnabled")
                    || this.sessionStorage["IsThirdPartyCookieEnabled"] == null)
                {
                    return null;
                }

                return (Nullable<bool>)this.sessionStorage["IsThirdPartyCookieEnabled"];
            }

            set
            {
                this.sessionStorage["IsThirdPartyCookieEnabled"] = value;
            }
        }
        public string PaymentType
        {
            get
            {
                return this.sessionStorage["PaymentType"] as string;
            }

            set
            {
                this.sessionStorage["PaymentType"] = value;
            }
        }
        public Nullable<bool> IsPaymentIFrameLoaded
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("IsPaymentIFrameLoaded")
                    || this.sessionStorage["IsPaymentIFrameLoaded"] == null)
                {
                    return null;
                }

                return (Nullable<bool>)this.sessionStorage["IsPaymentIFrameLoaded"];
            }

            set
            {
                this.sessionStorage["IsPaymentIFrameLoaded"] = value;
            }
        }

        public bool IsFamilyRedemptionAllowed
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("isFamilyRedemptionAllowed"))
                {
                    throw new SessionExpiredException();
                }
                return bool.Parse(this.sessionStorage["isFamilyRedemptionAllowed"].ToString());
            }

            set
            {
                this.sessionStorage["isFamilyRedemptionAllowed"] = value;
            }
        }
        public bool IsFFPUserLoggedIn { get; set; }
        public bool IsFromPayByLink
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("IsFromPayByLink"))
                {
                    return false;
                }
                return bool.Parse(Convert.ToString(this.sessionStorage["IsFromPayByLink"]));
            }
            set
            {
                this.sessionStorage["IsFromPayByLink"] = value;
            }
        }
        public string TierName
        {
            get
            {
                return this.sessionStorage["TierName"] as string;
            }

            set
            {
                this.sessionStorage["TierName"] = value;
            }
        }
        public List<flydubai.Model.PassengerDetails.GSTInfo> GSTList
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("GSTList"))
                {
                    return null;
                }
                return this.sessionStorage["GSTList"] as List<flydubai.Model.PassengerDetails.GSTInfo>;
            }

            set
            {
                this.sessionStorage["GSTList"] = value;
            }
        }

        public object GetUserSessionValue(string key)
        {
            switch (key ?? "")
            {
                case "PNR":
                    return this.PassengerNameRecord != null ? this.PassengerNameRecord.ConfirmationNumber : null;
                case "RadixxSessionToken":
                    return this.Token;
                case "IsInModify":
                    return this.IsInModifyMode;
                case "NumDebitCreditCardFailedPayments":
                    return this.PassengerNameRecord != null ? this.PassengerNameRecord.NumDebitCreditCardFailedPayments : 0;
                case "Channel":
                    return this.RadixxChannelUser;
                default:
                    return null;
            }
        }

        public Model.BookingMW.PNRPaymentDetails PNRPaymentDetails
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("PNRPaymentDetails"))
                {
                    this.sessionStorage["PNRPaymentDetails"] = new Model.BookingMW.PNRPaymentDetails()
                    {
                        PnrPayments = new List<BookingMW.PNRPayment>()
                    };
                }

                return this.sessionStorage["PNRPaymentDetails"] as Model.BookingMW.PNRPaymentDetails;
            }
            set
            {
                this.sessionStorage["PNRPaymentDetails"] = value;
            }
        }

        public Nullable<bool> IsOfferSubscribed
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("IsOfferSubscribed")
                    || this.sessionStorage["IsOfferSubscribed"] == null)
                {
                    return null;
                }

                return (Nullable<bool>)this.sessionStorage["IsOfferSubscribed"];
            }

            set
            {
                this.sessionStorage["IsOfferSubscribed"] = value;
            }
        }

        public Nullable<bool> IsThisRetryOfFOPOnCardFail
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("IsThisRetryOfFOPOnCardFail")
                    || this.sessionStorage["IsThisRetryOfFOPOnCardFail"] == null)
                {
                    return false;
                }

                return (Nullable<bool>)this.sessionStorage["IsThisRetryOfFOPOnCardFail"];
            }

            set
            {
                this.sessionStorage["IsThisRetryOfFOPOnCardFail"] = value;
            }
        }

        public bool IsPayLaterAttempted
        {
            get
            {
                return bool.Parse(this.sessionStorage["IsPayLaterAttempted"].ToString());
            }

            set
            {
                this.sessionStorage["IsPayLaterAttempted"] = value;
            }
        }

        

        public bool isReaccomodate
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("YourJourney"))
                {
                    return false;
                }

                return this.YourJourney.isReaccomodate;
            }          
        }

        public flydubai.Model.ReAccommodation.ReaccommodationFlightRS.ReaccommodationAvailRS FlightsForReaccomodation
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("FlightsForReaccomodation"))
                {
                    return null;
                }

                return this.sessionStorage["FlightsForReaccomodation"] as flydubai.Model.ReAccommodation.ReaccommodationFlightRS.ReaccommodationAvailRS;
            }

            set
            {
                this.sessionStorage["FlightsForReaccomodation"] = value;
            }
        }

        public flydubai.Model.ReAccommodation.ReaccommodationFlightRS.Flight SelectedFlightForReaccomodation
        {
            get
            {
                if (!this.sessionStorage.ContainsKey("SelectedFlightForReaccomodation"))
                {
                    return null;
                }

                return this.sessionStorage["SelectedFlightForReaccomodation"] as flydubai.Model.ReAccommodation.ReaccommodationFlightRS.Flight;
            }

            set
            {
                this.sessionStorage["SelectedFlightForReaccomodation"] = value;
            }
        }

        //IROPS
        public bool IsReaccomAcceptance
        {
            get
            {
                return (this.sessionStorage["IsReaccomAcceptance"] != null) ?
                    bool.Parse(this.sessionStorage["IsReaccomAcceptance"].ToString()) : false;
            }

            set
            {
                this.sessionStorage["IsReaccomAcceptance"] = value;
            }
        }

        public int lfIdIROPSAccept
        {
            get
            {
                if (this.sessionStorage.ContainsKey("lfIdIROPSAccept") && this.sessionStorage["lfIdIROPSAccept"] != null)
                {
                    return (int)this.sessionStorage["lfIdIROPSAccept"];
                }

                return 0;
            }

            set
            {
                this.sessionStorage["lfIdIROPSAccept"] = value;
            }
        }

        public string FzOtp
        {
            get
            {
                if (this.sessionStorage.ContainsKey("FzOtp") && this.sessionStorage["FzOtp"] != null)
                {
                    return this.sessionStorage["FzOtp"] as string;
                }

                return string.Empty;
            }

            set
            {
                this.sessionStorage["FzOtp"] = value;
            }
        }
        
    }

}
