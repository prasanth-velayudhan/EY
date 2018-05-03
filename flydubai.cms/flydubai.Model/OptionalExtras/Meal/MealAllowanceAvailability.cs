using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.OptionalExtras.Meal
{
    /// <summary>
    /// Baggage Allowance Availability
    /// </summary>
    public class MealAllowanceAvailability
    {
        public int LFID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string FlightNumber { get; set; }
        public string CodeType { get; set; }
        public int QuantityAvailable { get; set; }
        public int CheckedWeight { get; set; }


        /// <summary>
        /// Gets the baggage availability.
        /// </summary>
        /// <param name="baggagePassengers">The baggage passengers.</param>
        /// <returns></returns>
        public static IEnumerable<MealAllowanceAvailability> GetMealAvailability(List<MealAllowancePassenger> mealPassengers)
        {
            if (!mealPassengers.Any(x => x.CanHaveAssignedOwnMeal))
            {
                return new List<MealAllowanceAvailability>();
            }

            return mealPassengers.Where(a => a.CanHaveAssignedOwnMeal)
                                    .First().MealAllowancesPerFlight
                                            .SelectMany(f => f.MealAllowancePrices
                                                                     .Where(p => !string.IsNullOrEmpty(p.CodeType))
                                                                     .Select(p => new MealAllowanceAvailability()
                                                                     {
                                                                         CodeType = p.CodeType,
                                                                         //CheckedWeight = p.CheckedWeight,
                                                                         QuantityAvailable = p.QuantityAvailable,
                                                                         LFID = f.LFID,
                                                                         FlightNumber = string.Join("/", f.FlightLegs.Select(l => string.Format("{0}{1}", l.OperatingCarrier, l.FlightNum))),
                                                                         DepartureDate = f.DepartureDate
                                                                     }));
        }
    }
}
