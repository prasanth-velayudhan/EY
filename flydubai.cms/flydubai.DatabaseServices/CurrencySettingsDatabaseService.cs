using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Currency;

namespace flydubai.DatabaseServices
{
    public class CurrencySettingsDatabaseService:ICurrencySettingsDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyLightBoxDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public CurrencySettingsDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public List<CurrencySetting> Get()
        {
            return this.repository.AsQueryable<CurrencySetting>().ToList();
        }

        /// <summary>
        /// Gets the specified language.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public CurrencySetting Get(string groupname)
        {
            return this.repository.AsQueryable<CurrencySetting>().SingleOrDefault(x => x.GroupName == groupname);
        }

        /// <summary>
        /// Gets the with tracking.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public CurrencySetting GetWithTracking(string groupname)
        {
            return this.repository.AsQueryableWithTracking<CurrencySetting>().SingleOrDefault(x => x.GroupName == groupname);
        }

        /// <summary>
        /// Saves the specified survey light box.
        /// </summary>
        /// <param name="surveyLightBox">The survey light box.</param>
        /// <remarks></remarks>
        public void Save(CurrencySetting currencySettings)
        {
            if (!this.repository.AsQueryable<CurrencySetting>().Any(x => x.GroupName == currencySettings.GroupName))
            {
                this.repository.Add(currencySettings);
            }

            this.repository.SaveChanges();
        }
        public List<CurrencySetting> GetAllCurr() {
            return this.repository.AsQueryable<CurrencySetting>().ToList();
        }
    }
}
