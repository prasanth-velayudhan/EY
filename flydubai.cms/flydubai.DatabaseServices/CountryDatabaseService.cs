using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve the countries from the database
    /// </summary>
    /// <remarks></remarks>
    public class CountryDatabaseService : ICountryDatabaseService
    {
        private readonly IRepository repository;
        private readonly string currentLanguage;

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public CountryDatabaseService(IRepository repository)
        {
            this.repository = repository;
            currentLanguage = System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
        }

        /// <summary>
        /// Gets all countries.
        /// </summary>
        /// <returns>List of countries</returns>
        /// <remarks></remarks>
        public IList<Country> GetAllCountries()
        {
            return this.repository.AsQueryable<Country>().Include(a => a.Localised).ToList();
        }

        /// <summary>
        /// Gets all localised countries.
        /// </summary>
        /// <returns>List of localised countries</returns>
        /// <remarks></remarks>
        public IEnumerable<CountryLocalised> GetAllLocalisedCountries()
        {            
            return this.repository.AsQueryable<CountryLocalised>().Include(x => x.Country).Where(x => x.Language == this.currentLanguage);
        }
    }
}
