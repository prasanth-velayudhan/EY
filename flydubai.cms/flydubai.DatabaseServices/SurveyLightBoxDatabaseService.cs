using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Survey;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve and save the survey lightbox labels into the database
    /// </summary>
    /// <remarks></remarks>
    public class SurveyLightBoxDatabaseService : ISurveyLightBoxDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyLightBoxDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public SurveyLightBoxDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public List<SurveyLightBox> Get()
        {
            return this.repository.AsQueryable<SurveyLightBox>().ToList();
        }

        /// <summary>
        /// Gets the specified language.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public SurveyLightBox Get(string language)
        {
            return this.repository.AsQueryable<SurveyLightBox>().SingleOrDefault(x => x.Language == language);
        }

        /// <summary>
        /// Gets the with tracking.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public SurveyLightBox GetWithTracking(string language)
        {
            return this.repository.AsQueryableWithTracking<SurveyLightBox>().SingleOrDefault(x => x.Language == language);
        }

        /// <summary>
        /// Saves the specified survey light box.
        /// </summary>
        /// <param name="surveyLightBox">The survey light box.</param>
        /// <remarks></remarks>
        public void Save(SurveyLightBox surveyLightBox)
        {
            if (!this.repository.AsQueryable<SurveyLightBox>().Any(x => x.Language == surveyLightBox.Language))
            {
                this.repository.Add(surveyLightBox);
            }

            this.repository.SaveChanges();
        }
    }
}
