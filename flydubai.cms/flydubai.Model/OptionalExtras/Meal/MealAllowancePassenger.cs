namespace flydubai.Model.OptionalExtras.Meal
{
    using System.Collections.Generic;
    using System.Linq;

    using flydubai.Common;
    using System;

    /// <summary>
    /// Baggage Allowance Passenger
    /// </summary>
    public class MealAllowancePassenger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaggageAllowancePassenger"/> class.
        /// </summary>
        public MealAllowancePassenger()
        {
            this.MealAllowancesPerFlight = new List<MealAllowancePassengerFlight>();
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

        public bool WasMealAssinged { get; set; }

        public List<MealAllowancePassengerFlight> MealAllowancesPerFlight { get; set; }

        public bool HaveAllFlightsSameMealAllowance
        {
            get
            {
                var firstBaggageAllowance = this.MealAllowancesPerFlight.First();

                foreach (var baggageAllowance in this.MealAllowancesPerFlight)
                {
                    if (baggageAllowance.MealAllowancePrices.Count() != firstBaggageAllowance.MealAllowancePrices.Count())
                    {
                        return false;
                    }

                    for (int i = 0; i < baggageAllowance.MealAllowancePrices.Count(); i++)
                    {
                        if (firstBaggageAllowance.MealAllowancePrices[i].Equals(baggageAllowance.MealAllowancePrices[i]) == false)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        public bool CanHaveAssignedOwnMeal
        {
            get
            {
                return this.PassengerType != Enums.PassengerTypes.Infant;
            }
        }
    }
}