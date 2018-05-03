using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Beta;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve and save the labels used on the beta interceptor lightbox screen
    /// </summary>
    /// <remarks></remarks>
    public class BetaInterceptLightBoxDatabaseService : IBetaInterceptLightBoxDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInterceptLightBoxDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public BetaInterceptLightBoxDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public List<InterceptLightBox> Get()
        {
            return this.repository.AsQueryable<InterceptLightBox>().ToList();
        }

        /// <summary>
        /// Gets the specified language.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <returns>The labels for that language</returns>
        /// <remarks></remarks>
        public InterceptLightBox Get(string language)
        {
            return this.repository.AsQueryable<InterceptLightBox>().SingleOrDefault(x => x.Language == language);
        }

        /// <summary>
        /// Gets the with tracking.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <returns>The labels</returns>
        /// <remarks></remarks>
        public InterceptLightBox GetWithTracking(string language)
        {
            return this.repository.AsQueryableWithTracking<InterceptLightBox>().SingleOrDefault(x => x.Language == language);
        }

        /// <summary>
        /// Saves the specified intercept light box.
        /// </summary>
        /// <param name="interceptLightBox">The intercept light box.</param>
        /// <remarks></remarks>
        public void Save(InterceptLightBox interceptLightBox)
        {
            if (!this.repository.AsQueryable<InterceptLightBox>().Any(x => x.Language == interceptLightBox.Language))
            {
                this.repository.Add(interceptLightBox);
            }

            this.repository.SaveChanges();
        }
    }
}
