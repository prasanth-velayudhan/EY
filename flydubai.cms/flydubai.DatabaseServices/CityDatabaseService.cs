using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model;
using System.Data.Entity;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve the cities from the database
    /// </summary>
    /// <remarks></remarks>
    public class CityDatabaseService : ICityDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CityDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public CityDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets all cities.
        /// </summary>
        /// <returns>List of cities</returns>
        /// <remarks></remarks>
        public IList<City> GetAllCities()
        {
            return this.repository.AsQueryable<City>().Include(a => a.Localised).ToList();
        }

        /// <summary>
        /// Gets the cities for a country.
        /// </summary>
        /// <param name="countryId">The country id.</param>
        /// <returns>List of cities</returns>
        /// <remarks></remarks>
        public IList<City> GetCities(int countryId)
        {
            return this.repository.AsQueryable<City>().Include(a => a.Localised).Where(x => x.Country.CountryId == countryId).ToList();
        }

        /// <summary>
        /// Gets all localised cities.
        /// </summary>
        /// <returns>List of localised cities</returns>
        /// <remarks></remarks>
        public IEnumerable<CityLocalised> GetAllLocalisedCities()
        {
            string currentLanguage = System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            return this.repository.AsQueryable<CityLocalised>().Include(x => x.City).Where(x => x.Language == currentLanguage);
        }

        /// <summary>
        /// Gets the single city.
        /// </summary>
        /// <param name="cityId">The city id.</param>
        /// <returns>The city</returns>
        /// <remarks></remarks>
        public City GetSingleCity(int cityId)
        {
            return this.repository.AsQueryable<City>().Include(c => c.Localised).Where(c => c.CityId == cityId).FirstOrDefault();
        }

    }
}
