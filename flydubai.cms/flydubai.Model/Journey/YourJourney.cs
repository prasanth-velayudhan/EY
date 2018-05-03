using flydubai.Model.Payment;
using flydubai.Model.Search;

namespace flydubai.Model.Journey
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using flydubai.Common;
    using flydubai.Model.Common;

    /// <summary>
    /// Your Journey
    /// </summary>
    [Serializable]
    public class YourJourney
    {
        // Present for serialisation only - not for use.
        /// <summary>
        /// Initializes a new instance of the <see cref="YourJourney"/> class.
        /// </summary>
        public YourJourney()
        {
        }

        UserSession ui;

        /// <summary>
        /// Initializes a new instance of the <see cref="YourJourney"/> class.
        /// </summary>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <param name="yourJourneyCurrency">Your journey currency.</param>
        public YourJourney(SearchCriteria searchCriteria, string yourJourneyCurrency)
        {
            this.YourJourneyCurrency = yourJourneyCurrency;
            this.Adults = searchCriteria.Adults;
            this.Children = searchCriteria.Children;
            this.Infant = searchCriteria.Infants;
            this.PromoCode = searchCriteria.PromoCode;
            this.Flights = new List<JourneyFlight>();
            this.Surcharges = new List<Surcharge>();
            this.VoucherPaymentDetailsList = new List<VoucherPaymentDetails>();
        }

        public int Adults { get; set; }

        public int Children { get; set; }

        public int Infant { get; set; }

        public List<JourneyFlight> Flights { get; set; }

        /// <summary>
        /// Determines whether the specified lfid has flight.
        /// </summary>
        /// <param name="lfid">The lfid.</param>
        /// <param name="departureDate">The departure date.</param>
        /// <returns>
        ///   <c>true</c> if the specified lfid has flight; otherwise, <c>false</c>.
        /// </returns>
        public bool HasFlight(int lfid, DateTime departureDate)
        {
            return this.Flights.Any(f => f.LFID == lfid && f.DepartureDate.Date == departureDate.Date);
        }

        public string IATA
        {
            get
            {
                return ui.TAProfile.IATACode;
            }
            set
            {

                this.IATA = ui.TAProfile.IATACode;
            }
        }

        /// <summary>
        /// Gets the flight.
        /// </summary>
        /// <param name="lfid">The lfid.</param>
        /// <param name="departureDate">The departure date.</param>
        /// <returns></returns>
        public JourneyFlight GetFlight(int lfid, DateTime departureDate)
        {
            if (this.Flights.Any(a=>a.LFID == lfid && a.Legs.Any(b=>b.IsOtherAirline) && a.Legs.Any(c=>c.OperatingCarrier.ToUpper().Trim()==Constants.FlydubaiCarrierCode)))
            {
                DateTime fzDepartureDate = this.Flights.Where(f => f.LFID == lfid).SelectMany(x => x.Legs).FirstOrDefault(x => !x.IsOtherAirline).DepartureDate.Date;
                return this.Flights.Single(f => f.LFID == lfid && f.Legs.Any(y => y.DepartureDate.Date == fzDepartureDate.Date && !y.IsOtherAirline));
            }
            else
            {
                return this.Flights.Single(f => f.LFID == lfid && f.DepartureDate.Date == departureDate.Date);
            }
        }
       
        public string PromoCode { get; set; }

        public string ConfirmationNumber { get; set; }

        public List<Surcharge> Surcharges { get; set; }

        public IEnumerable<string> FareBasisCodes
        {
            get
            {
                return this.Flights.SelectMany(x => x.FareBasisCodes);
            }
        }

        public decimal Total
        {
            get
            {
                return this.Flights.Sum(f => f.Total) + this.Surcharges.Sum(s => s.Total) - this.TotalVoucherAmountApplied;
            }
        }

        private decimal _binDiscountTotalAmount = 0;
        public decimal BinDiscountTotalAmount
        {
            get { return _binDiscountTotalAmount; }
            set { _binDiscountTotalAmount = value; }
        }

        private decimal _resBalanceAfterDiscount = 0;
        public decimal ResBalanceAfterDiscount
        {
            get { return _resBalanceAfterDiscount; }
            set { _resBalanceAfterDiscount = value; }
        }

        public decimal TotalDiscount
        {
            get
            {
                return this.Flights.Sum(f => f.DiscountAmount);
            }
        }

        public decimal TotalVoucherAmountApplied
        {
            get;
            set;
        }

        public string YourJourneyCurrency { get; set; }

        public bool InsuranceHasBeenSelected { get; set; }
        //START A-4627:WR4:FR008
        public bool BaggageHasBeenSelected { get; set; }
        public bool MealsHasBeenSelected { get; set; }
        public bool IFEHasBeenSelected { get; set; }
        public bool InsuranceHasBeenSelectedForAllPAX { get; set; }
        //END A-4627:WR4:FR008
        public List<VoucherPaymentDetails> VoucherPaymentDetailsList { get; set; }

        public PointsPaymentDetails PointsPaymentDetails { get; set; }

        public bool UserAlreadyLoggedIn { get; set; }

        public JourneyInsuranceQuote InsuranceQuote { get; set; }

        public decimal PmntFee { get; set; }

        public bool isAddPaxFlow { get; set; }

        public string BookingChannel { get; set; }

        public string TACountryCode { get; set; }

        public string TAIATA { get; set; }

        public bool isGDS { get; set; }

        public bool isChangeDate { get; set; }

        //public bool IsMpesaOpted { get; set; }
        //public decimal MpesaAmount { get; set; }
        //public string MpesaCurrency { get; set; }
        public bool isDiscountApplied { get; set; }
        public string DiscountedBin { get; set; }

        //IROPS
        public bool isReaccomodate { get; set; }
        public List<flydubai.Model.ReAccommodation.ReaccomOptionalExtras> ChargesDroppedOnReaccomodate { get; set; }
    }
}