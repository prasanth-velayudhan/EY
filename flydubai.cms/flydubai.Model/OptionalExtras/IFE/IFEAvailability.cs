using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.OptionalExtras.IFE
{
    /// <summary>
    /// IFE Availability
    /// </summary>
    public class IFEAvailability
    {
        public int LFID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string FlightNumber { get; set; }
        public string CodeType { get; set; }

        /// <summary>
        /// Gets the IFE availability.
        /// </summary>
        /// <param name="IFEPassengers">The IFE passengers.</param>
        /// <returns></returns>


        public static IEnumerable<IFEAvailability> IFEAvail(List<IFEPassenger> IFEPassengers)
        {

            return IFEPassengers.Where(a => a.CanHaveOwnIFE)
                                    .First().IFEsPerFlight
                                            .SelectMany(f => f.IFEPrices
                                                                     .Where(p => !string.IsNullOrEmpty(p.CodeType))
                                                                     .Select(p => new IFEAvailability()
                                                                     {
                                                                         CodeType = p.CodeType,
                                                                         LFID = f.LFID,
                                                                         FlightNumber = string.Join("/", f.FlightLegs.Select(l => string.Format("{0}{1}", l.OperatingCarrier, l.FlightNum))),
                                                                         DepartureDate = f.DepartureDate
                                                                     }));
        }

    }
}

