using System.Collections.Generic;
using System.Linq;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model;
using flydubai.Model.Content;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve the Special offers from the database
    /// </summary>
    public class SpecialOfferDatabaseService : ISpecialOfferDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialOfferDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public SpecialOfferDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets the airports.
        /// </summary>
        /// <param name="languageId">The language id.</param>
        /// <returns></returns>
        public List<Airport> GetAirports(int languageId)
        {
            var airportCodes = this.repository.AsQueryable<SpecialOfferVersion>()
                //.Where(s => s.IsDraft && !s.UnpublishedDate.HasValue && s.PublishedDate.HasValue && !string.IsNullOrEmpty(s.TravellingTo) && !string.IsNullOrEmpty(s.TravellingFrom))
                .Where(x => x.Parent.LanguageId == languageId)
                .OrderByDescending(x => x.Version)
                .Select(x => new { x.TravellingTo, x.TravellingFrom })
                .Distinct();

            IList<string> distinctAirportCodes = airportCodes.Select(a => a.TravellingFrom).Union(airportCodes.Select(a => a.TravellingTo)).ToList();

            return distinctAirportCodes.Select(airportCode => this.repository.AsQueryable<Airport>().FirstOrDefault(a => a.AirportCode == airportCode)).Where(a => a != null).ToList();
        }
    }
}
