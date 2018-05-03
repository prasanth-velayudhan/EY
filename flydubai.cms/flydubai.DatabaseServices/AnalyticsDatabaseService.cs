using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model.Content.Analytics;
using flydubai.Common.Contracts.DatabaseServices;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve and save google analytics client code from the database
    /// </summary>
    /// <remarks></remarks>
    public class AnalyticsDatabaseService : IAnalyticsDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public AnalyticsDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets the analytics.
        /// </summary>
        /// <returns>Google analytics info</returns>
        /// <remarks></remarks>
        public GoogleAnalytics Get()
        {
            return this.repository.AsQueryable<GoogleAnalytics>().SingleOrDefault();
        }

        /// <summary>
        /// Gets the analytics with tracking.
        /// </summary>
        /// <returns>Google analytics info</returns>
        /// <remarks></remarks>
        public GoogleAnalytics GetWithTracking()
        {
            return this.repository.AsQueryableWithTracking<GoogleAnalytics>().SingleOrDefault();
        }

        /// <summary>
        /// Saves the specified google analytics.
        /// </summary>
        /// <param name="googleAnalytics">The google analytics.</param>
        /// <remarks></remarks>
        public void Save(GoogleAnalytics googleAnalytics)
        {
            if (this.repository.Find<GoogleAnalytics>(googleAnalytics.VersionId) == null)
            {
                this.repository.Add(googleAnalytics);
            }

            this.repository.SaveChanges();
        }
    }
}
