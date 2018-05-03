using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Booking;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve hand baggage info from the database
    /// </summary>
    /// <remarks></remarks>
    public class BaggageDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaggageDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public BaggageDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets the hand baggage weight.
        /// </summary>
        /// <returns>Hand baggage weight</returns>
        /// <remarks></remarks>
        public int GetHandBaggageWeight()
        {
            return this.repository.AsQueryable<HandBaggage>().First().Weight;
        }

        /// <summary>
        /// Gets the business hand baggage weight.
        /// </summary>
        /// <returns>Hand baggage weight</returns>
        /// <remarks></remarks>
        public int GetBusinessHandBaggageWeight()
        {
            return this.repository.AsQueryable<BusinessHandBaggage>().First().Weight;
        }
    }
}
