using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.OptionalExtras.Baggage
{
    /// <summary>
    /// Baggage Allowance Availability
    /// </summary>
    public class BaggageAllowanceAvailability
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
        public static IEnumerable<BaggageAllowanceAvailability> GetBaggageAvailability(List<BaggageAllowancePassenger> baggagePassengers )
        {
            if (!baggagePassengers.Any(x => x.CanHaveAssignedOwnBaggage))
            {
                return new List<BaggageAllowanceAvailability>();
            }

            return baggagePassengers.Where(a => a.CanHaveAssignedOwnBaggage)
                                    .First().BaggageAllowancesPerFlight
                                            .SelectMany(f => f.BaggageAllowancePrices
                                                                     .Where(p => !string.IsNullOrEmpty(p.CodeType))
                                                                     .Select(p => new BaggageAllowanceAvailability()
                                                                     {
                                                                         CodeType = p.CodeType,
                                                                         CheckedWeight = p.CheckedWeight,
                                                                         QuantityAvailable = p.QuantityAvailable,
                                                                         LFID = f.LFID,
                                                                         FlightNumber = string.Join("/", f.FlightLegs.Select(l => string.Format("{0}{1}", l.OperatingCarrier, l.FlightNum))),
                                                                         DepartureDate = f.DepartureDate
                                                                     }));            
        }
    }
}
