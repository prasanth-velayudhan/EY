using flydubai.Model.Booking;

namespace flydubai.Model.Results
{
    using System;
    using System.Collections.Generic;

    using flydubai.Common;
    using flydubai.Model.Common;
    using flydubai.Model.ExternalPricing;

    /// <summary>
    /// Flight Fare
    /// </summary>
    [Serializable]
    public class FlightFare
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightFare"/> class.
        /// </summary>
        public FlightFare()
        {
            this.CheckedBaggageIncludedInFare = new List<IncludedBaggage>();
            this.ApplicableTaxDetails = new List<ApplicableTaxDetail>();
        }

        public string PaxId { get; set; }

        public int FareTypeId { get; set; }

        public string FareTypeName { get; set; }
         
        public string FareClass { get; set; }

        public string FareBasisCode { get; set; }

        public int FareId { get; set; }

        public int PaxCount { get; set; }

        public int SolutionID { get; set; }

        public bool CMPFare { get; set; }

        /// <summary>
        /// This is actually the fare total
        /// </summary>
        public decimal FareAmount { get; set; }

        public decimal WebFareAmount { get; set; }

        /// <summary>
        /// These are the taxes that are added to the DislayAmountNoTaxes
        /// </summary>
        public decimal Taxes { get; set; }

        /// <summary>
        /// This is the amount minus the Taxes
        /// </summary>
        public decimal DisplayAmountNoTaxes { get; set; }

        public decimal FareAmtNoTaxes { get; set; }

        public decimal Discount { get; set; }

        public bool IsPrivateFare { get; set; }

        public bool IsPromoFare { get; set; }

        public bool IsPromoCodeApplied { get; set; }

        public Enums.PassengerTypes PassengerTypeId { get; set; }

        public string Cabin { get; set; }

        public bool Ismixed { get; set; }

        public string MixedCabin { get; set; }

        public string WebFareType { get; set; }

        public int SeatsAvailable { get; set; }

        public bool IsSoldOut(int numSeatsRequired = 1)
        {
            return this.SeatsAvailable < numSeatsRequired;
        }

        public decimal Total
        {
            get
            {
                return this.FareAmount; // +this.Taxes;
            }
        }

        public List<IncludedBaggage> CheckedBaggageIncludedInFare { get; set; }

        public List<ApplicableTaxDetail> ApplicableTaxDetails { get; set; }


        /// <summary>
        /// Deeps the copy.
        /// </summary>
        /// <returns></returns>
        public FlightFare DeepCopy()
        {
            var copy = (FlightFare)this.MemberwiseClone();

            copy.CheckedBaggageIncludedInFare = new List<IncludedBaggage>(this.CheckedBaggageIncludedInFare.ToArray());

            return copy;
        }

        //Added by IBS
        public bool IsSelected { get; set; }

        public bool IsNotCombinable { get; set; }

        //Pricing Analytics
        public decimal OriginalFare { get; set; }

        public string RuleId { get; set; }

        //Interline changes
        public string HashCode { get; set; }
        public List<Bookingcode> Bookingcodes { get; set; }
        public string LfId { get; set; }
        public List<PfIds> PfIds { get; set; }
        public string FareCarrier { get; set; }
        public string TicketDesignator { get; set; }

        //Multicity
        public int MulticityStopOverSolutionID { get; set; }
        public int MulticityStopOverLfID { get; set; }
        public int MulticityStopOverFareID { get; set; }
        public DateTime MulticityStopOverDepartureDate { get; set; }
    }

    [Serializable]
    public class Bookingcode
    {
        public string RBD { get; set; }
        public string cabin { get; set; }
        public int PFID { get; set; }
    }

    [Serializable]
    public partial class PfIds
    {
        public string PfId { get; set; }
        public string Cabin { get; set; }
        public string FareClass { get; set; }
        public string Date { get; set; }
        public bool IsOtherAirline { get; set; }
    } 
}
