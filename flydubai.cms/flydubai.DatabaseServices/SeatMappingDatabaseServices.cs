using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Booking;

namespace flydubai.DatabaseServices
{

    /// <summary>
    /// Service to retrieve all Seat Mapping from database
    /// </summary>
    /// <remarks></remarks>
    public class SeatMappingDatabaseServices
    {
        private readonly IRepository repository;


        /// <summary>
        /// Initializes a new instance of the <see cref="SeatMappingDatabaseServices"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public SeatMappingDatabaseServices(IRepository repository)
        {
            this.repository = repository;
        }


        /// <summary>
        /// Gets all SeatMappings.
        /// </summary>
        /// <returns>List of airports</returns>
        /// <remarks></remarks>
        public List<SeatMapping> GetAllSeatMappings()
        {
            return this.repository.AsQueryable<SeatMapping>().ToList();
        }

    }
}
