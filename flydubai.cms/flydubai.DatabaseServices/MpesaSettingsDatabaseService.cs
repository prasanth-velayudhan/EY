using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Mpesa;

namespace flydubai.DatabaseServices
{
    public class MpesaSettingsDatabaseService : IMpesaSettingsDatabaseService
    {
         private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyLightBoxDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
         public MpesaSettingsDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public List<MpesaSetting> Get()
        {
            return this.repository.AsQueryable<MpesaSetting>().ToList();
        }

        /// <summary>
        /// Gets the specified language.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public MpesaSetting Get(int  countryID)
        {
            return this.repository.AsQueryable<MpesaSetting>().SingleOrDefault(x => x.CountryID == countryID);
        }

        /// <summary>
        /// Gets the with tracking.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public MpesaSetting GetWithTracking(int countryID)
        {
            return this.repository.AsQueryableWithTracking<MpesaSetting>().SingleOrDefault(x => x.CountryID == countryID);
        }

        /// <summary>
        /// Saves the specified survey light box.
        /// </summary>
        /// <param name="surveyLightBox">The survey light box.</param>
        /// <remarks></remarks>
        public void Save(MpesaSetting mpesaSetting)
        {
            if (!this.repository.AsQueryable<MpesaSetting>().Any(x => x.CountryID == mpesaSetting.CountryID))
            {
                this.repository.Add(mpesaSetting);
            }

            this.repository.SaveChanges();
        }
        public List<MpesaSetting> GetAllMpesa()
        {
            return this.repository.AsQueryable<MpesaSetting>().ToList();
        }
    }
}
