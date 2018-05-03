namespace flydubai.DatabaseServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using flydubai.Common.Contracts.DatabaseServices;
    using flydubai.Model;

    /// <summary>
    /// Service to retrieve the time windows from the database
    /// </summary>
    /// <remarks></remarks>
    public class DepartureWindowDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepartureWindowDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public DepartureWindowDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets the departure windows.
        /// </summary>
        /// <returns>List of time windows</returns>
        /// <remarks></remarks>
        public List<DepartureWindow> GetDepartureWindows()
        {
            return this.repository.AsQueryable<DepartureWindow>().ToList();
        }
    }
}
