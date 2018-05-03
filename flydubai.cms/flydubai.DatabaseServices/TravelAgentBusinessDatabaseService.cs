using System.Collections.Generic;
using System.Linq;
using flydubai.Model;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Content;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve Travel agents from the database
    /// </summary>
    public class TravelAgentBusinessDatabaseService : ITravelAgentBusinessDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TravelAgentBusinessDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public TravelAgentBusinessDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets the cities.
        /// </summary>
        /// <param name="languageId">The language id.</param>
        /// <returns></returns>
        public List<City> GetCities(int languageId)
        {
            return this.repository.AsQueryable<TravelAgentVersion>()
                .OrderByDescending(x => x.Version)
                .Where(x => x.Parent.LanguageId == languageId)
                .Select(x => x.City)
                .Distinct()
                .ToList();
        }
    }
}
