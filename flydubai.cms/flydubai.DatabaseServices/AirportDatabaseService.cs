using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve all airports from database
    /// </summary>
    /// <remarks></remarks>
    public class AirportDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AirportDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public AirportDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets all airports.
        /// </summary>
        /// <returns>List of airports</returns>
        /// <remarks></remarks>
        public List<Airport> GetAllAirports()
        {
            return this.repository.AsQueryable<Airport>().Include(a => a.Localised).Include(a => a.Destinations).Include(a => a.Country.Localised).ToList();
        }

        /// <summary>
        /// Gets all airports for update.
        /// </summary>
        /// <returns>List of airports</returns>
        /// <remarks></remarks>
        public List<Airport> GetAllAirportsForUpdate()
        {
            return this.repository.AsQueryableWithTracking<Airport>().Include(a => a.Localised).Include(a => a.Destinations).Include(a => a.Country.Localised).ToList();
        }

        //WR4 FR013 A-5851 : Start
        /// <summary>
        /// Returns all the airports as Queryable
        /// </summary>
        /// <returns></returns>
        public IQueryable<Airport> GetAllAirportsWithRouteMessages()
        {
            return this.repository.AsQueryable<Airport>();
        }
        //WR4 FR013 A-5851 : End

        //public IQueryable<AiportUpdatedDateTime> GetAirportUpdateDateTime()
        //{
        //    return this.repository.AsQueryableWithTracking<AiportUpdatedDateTime>();
        //}
    }
}
