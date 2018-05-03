using System.Collections.Generic;
using System.Linq;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve logs from the database
    /// </summary>
    /// <remarks></remarks>
    public class LogDatabaseService : ILogDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public LogDatabaseService(IRepository repository)
        {
            this.repository = repository; 
        }

        /// <summary>
        /// Gets the specified take.
        /// </summary>
        /// <param name="take">The take.</param>
        /// <returns>List of logs</returns>
        /// <remarks></remarks>
        public List<Log> Get(int take)
        {
            return this.repository.AsQueryable<Log>().Where(l => l.Level != "INFO").Take(take).OrderByDescending(l => l.Date).ToList();
        }

        /// <summary>
        /// Gets the specified skip.
        /// </summary>
        /// <param name="skip">The skip.</param>
        /// <param name="take">The take.</param>
        /// <returns>The logs</returns>
        /// <remarks></remarks>
        public List<Log> Get(int skip, int take)
        {
            return this.repository.AsQueryable<Log>().Where(l => l.Level != "INFO").OrderByDescending(l => l.Date).Skip(skip).Take(take).ToList();
        }

        /// <summary>
        /// Gets the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>The logs</returns>
        /// <remarks></remarks>
        public List<Log> Get(string query)
        {
            return this.repository.SqlQuery<Log>(query).ToList();
        }
    }
}
