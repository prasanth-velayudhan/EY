using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Common;
using flydubai.Model.Content;
using System.Data.Entity;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// FareTypeID Database Service
    /// </summary>
    public class FareTypeIDDatabaseService : IFareTypeIDDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FareTypeIDDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public FareTypeIDDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        ///  Get FareTypeID Names
        /// </summary>
        /// <returns></returns>
        public List<FareBrandIDLabel> Get()
        {
            return this.repository.AsQueryable<FareBrandIDLabel>().Distinct().ToList();
        }

        /// <summary>
        ///  Get FareTypeID Names for specified language
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        public List<FareBrandIDLabel> Get(int languageId)
        {
            return this.repository.AsQueryable<FareBrandIDLabel>()
              .Where(r => r.LanguageId == languageId)
              .ToList()
              .Distinct()
              .ToList();
        }
    }
}
