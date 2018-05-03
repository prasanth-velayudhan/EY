using System.Collections.Generic;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Content;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Database service for IP Country mapping
    /// </summary>
    public class IpCountryMappingDatabaseService : IIpCountryMappingDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="IpCountryMappingDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public IpCountryMappingDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IpCountryMapping> Get()
        {
            return this.repository.AsQueryable<IpCountryMapping>();
        }
    }
}
