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
    public class CodeTypeDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeTypeDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public CodeTypeDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets the code types.
        /// </summary>
        /// <returns>List of code types</returns>
        /// <remarks></remarks>
        public IList<CodeType> GetCodeTypes()
        {
            return this.repository.AsQueryable<CodeType>().Include(x => x.CodeTypeCategory).Include(x => x.Localised).ToList();
        }
    }
}
