using flydubai.Model.Results;

namespace flydubai.Model.Journey
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using flydubai.Common;
    using flydubai.Model.Common;

    /// <summary>
    /// Journey Flight
    /// </summary>
    [Serializable]
    public class JourneyFlight : Flight
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyFlight"/> class.
        /// </summary>
        /// <param name="segmentId">The segment id.</param>
        public JourneyFlight(int segmentId)
        {
            this.segmentId = segmentId;
            this.FlightFares = new List<FlightFare>();
            this.Passengers = new List<JourneyPassenger>();
        }

        private readonly int segmentId;
        public string FareIdPerSegmentKey { get; set; }     //Added by a-5467 - Platinum changes
        public bool IsWithinCutoffPeriod { get; set; }
        public bool possibleIFE { get; set; }

        public bool ContainsCircularFlight
        {
            get
            {
                var uniqueFlightNumbers = this.Legs.Select(x => x.FlightNum).Distinct();

                return this.Legs.Count() > 1 && this.Legs.Count() > uniqueFlightNumbers.Count();
            }
        }

        public bool ContainsConnectionFlight
        {
            get
            {
                var uniqueFlightNumbers = this.Legs.Select(x => x.FlightNum).Distinct();

                return this.Legs.Count() > 1 && this.Legs.Count() == uniqueFlightNumbers.Count();
            }
        }

        public int SegmentId
        {
            get
            {
                return this.segmentId;
            }
        }

        public List<JourneyPassenger> Passengers { get; set; }

        public string LogicalFlightKey { get; set; }

        public decimal Total
        {
            get
            {
                return this.Passengers.Sum(p => this.GetPassengerFareInfo(p.PassengerType).FareAmount
                    + p.OptionalExtras.Sum(o => o.Total));
            }
        }

        public decimal TotalWithoutInsurance
        {
            get
            {
                return this.Passengers.Sum(p => this.GetPassengerFareInfo(p.PassengerType).FareAmount
                 + p.OptionalExtras.Where(o => o.GetType() != typeof(InsuranceOptionalExtra) && o.GetType() != typeof(TFEEOptionalExtra)).Sum(o => o.Total));
            }
        }

        public decimal DiscountAmount
        {
            get
            {
                return this.Passengers.Sum(p => this.GetPassengerFareInfo(p.PassengerType).Discount);
            }
        }

        public IEnumerable<string> FareBasisCodes
        {
            get
            {
                return this.FlightFares.Select(x => x.FareBasisCode).Distinct();
            }
        }

        public FlightFare GetPassengerFareInfo(Enums.PassengerTypes passengerType)
        {
            return this.FlightFares.First(fi => fi.PassengerTypeId == passengerType);
        }

        public List<FlightFare> GetPassengersByFareInfo(Enums.PassengerTypes passengerType)
        {
            return this.FlightFares.Where(fi => fi.PassengerTypeId == passengerType).Distinct(new FlightFareComparer()).ToList();
        }
        //Y class meal - MBRD, SBRD or string.Empty if no inventory available
        public string AvailableMealInventoryMstrCode { get; set; }
    }

    public class FlightFareComparer : IEqualityComparer<FlightFare>
    {
        /// <summary>
        /// Returns true if same
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool Equals(FlightFare x, FlightFare y)
        {
            return x.FareId == y.FareId && x.FareBasisCode.ToLower() == y.FareBasisCode.ToLower();
        }

        /// <summary>
        /// Returns the hash code
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int GetHashCode(FlightFare obj)
        {
            return obj.FareId.GetHashCode() + obj.FareBasisCode.GetHashCode();
        }
    }
}
