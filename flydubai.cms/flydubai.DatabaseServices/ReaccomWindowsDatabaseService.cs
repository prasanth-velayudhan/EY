using System.Data.Entity;

namespace flydubai.DatabaseServices
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;

    using flydubai.Common.Contracts.DatabaseServices;
    using flydubai.Model;

    /// <summary>
    /// Service to retrieve the code types from the database
    /// </summary>
    /// <remarks></remarks>
    public class ReaccomWindowsDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeTypeDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public ReaccomWindowsDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets the code types.
        /// </summary>
        /// <returns>List of code types</returns>
        /// <remarks></remarks>
        public IList<ReaccomWindows> GetAllReaccomWindows()
        {
            return this.repository.AsQueryable<ReaccomWindows>().ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public ReaccomWindows GetReaccomWindowForOriginAndDestination(string origin,string destination)
        {
            return this.repository.AsQueryable<ReaccomWindows>().Where(x => x.Origin.ToUpper() == origin.ToUpper() && x.Destination.ToUpper()==destination.ToUpper()).First();
        }
    }
}
