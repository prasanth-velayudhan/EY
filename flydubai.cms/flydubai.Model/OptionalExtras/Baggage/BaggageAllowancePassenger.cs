namespace flydubai.Model.OptionalExtras.Baggage
{
    using System.Collections.Generic;
    using System.Linq;

    using flydubai.Common;
    using System;

    /// <summary>
    /// Baggage Allowance Passenger
    /// </summary>
    public class BaggageAllowancePassenger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaggageAllowancePassenger"/> class.
        /// </summary>
        public BaggageAllowancePassenger()
        {
            this.BaggageAllowancesPerFlight = new List<BaggageAllowancePassengerFlight>();
        }

        public string PassengerName { get; set; }

        public Enums.PassengerTypes PassengerType { get; set; }

        public int SortOrder
        {
            get
            {
                switch (PassengerType)
                {
                    case Enums.PassengerTypes.Adult:
                        return 1;
                    case Enums.PassengerTypes.Child:
                        return 2;
                    case Enums.PassengerTypes.Infant:
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException("PassengerType");
                }
            }
        }

        public int PassengerId { get; set; }

        public bool IsPrimaryPassenger { get; set; }

        public List<BaggageAllowancePassengerFlight> BaggageAllowancesPerFlight { get; set; }

        public bool HaveAllFlightsSameBaggageAllowance
        {
            get
            {
                var firstBaggageAllowance = this.BaggageAllowancesPerFlight.First();

                foreach (var baggageAllowance in this.BaggageAllowancesPerFlight)
                {
                    if (baggageAllowance.BaggageAllowancePrices.Count() != firstBaggageAllowance.BaggageAllowancePrices.Count())
                    {
                        return false;
                    }

                    for (int i = 0; i < baggageAllowance.BaggageAllowancePrices.Count(); i++)
                    {
                        if (firstBaggageAllowance.BaggageAllowancePrices[i].Equals(baggageAllowance.BaggageAllowancePrices[i]) == false)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        public bool CanHaveAssignedOwnBaggage
        {
            get
            {
                //return this.PassengerType != Enums.PassengerTypes.Infant;
                return true;//made true as part of infanr baggage implementation
            }
        }

        //Interline changes
        public bool IsInterline{get;set;}
    }
}