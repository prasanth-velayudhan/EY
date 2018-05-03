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
    /// Route Message Database Service
    /// </summary>
    public class RouteMessageDatabaseService : IRouteMessageDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteMessageDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public RouteMessageDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets list of Route message's.
        /// </summary>
        /// <returns></returns>
        public List<RouteMessageVersion> Get()
        {
            return this.repository.AsQueryable<RouteMessageVersion>().Include(x => x.Parent).OrderByDescending(r => r.Version)
                //.Where(r => r.Status == EntityVersionStatus.Published)
                .Distinct()
                .ToList();
        }
       
        public List<RouteMessageVersion> Get(int languageId)
        {
            return this.repository.AsQueryable<RouteMessageVersion>()
                .Where(r => r.Parent.LanguageId == languageId)
                .ToList()
                .GroupBy(r => r.ParentId)
                .Select(r => r.OrderByDescending(x => x.Version)
                                 .FirstOrDefault(x => x.Status == EntityVersionStatus.Published))
                .Where(r => r != null)
                .Distinct()
                .ToList();
        }
    }
}
