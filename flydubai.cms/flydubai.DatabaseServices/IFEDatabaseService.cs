using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Booking;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Service to retrieve IFE ssr code info from the database
    /// </summary>
    /// <remarks></remarks>
    public class IFEDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="IFEDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public IFEDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets code.
        /// </summary>
        /// <returns>IFE ssr codet</returns>
        /// <remarks></remarks>
        public string GetIFECode()
        {
            return this.repository.AsQueryable<IFESSRCode>().First().IFECode;
        }
    }
}
