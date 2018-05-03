using System;
using System.Collections.Generic;
using System.Linq;

using Splendid.Common;

using flydubai.Common.Contracts;
using flydubai.Common.Contracts.Model;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Common.Model;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve the exception messages from the database
    /// </summary>
    /// <remarks></remarks>
    public class ExceptionsService : IExceptionsService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionsService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public ExceptionsService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets all exceptions.
        /// </summary>
        /// <returns>List of exception messages</returns>
        /// <remarks></remarks>
        public IEnumerable<ExceptionMessage> GetAllExceptions()
        {
            return this.repository.AsQueryable<ExceptionMessage>().ToList();
        }
    }
}
