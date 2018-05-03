
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
    public class TierTypeDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TierTypeDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public TierTypeDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets the code types.
        /// </summary>
        /// <returns>List of code types</returns>
        /// <remarks></remarks>
        public IList<TierType> GetTierTypes()
        {
            return this.repository.AsQueryable<TierType>().ToList();
        }
    }
}
