using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Common.Model;

namespace flydubai.DatabaseServices
{
    using flydubai.Model;
    using flydubai.Model.Common;
    using flydubai.Model.Content;
    using flydubai.Model.Labels;

    /// <summary>
    /// Service to retrieve all the contries
    /// </summary>
    /// <remarks></remarks>
    public class UserDetailsDatabaseService : IUserDetailsDatabaseService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetailsDatabaseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public UserDetailsDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets all countries.
        /// </summary>
        /// <returns>List of countries</returns>
        /// <remarks></remarks>
        public IList<Country> GetAllCountries()
        {
            return this.repository.AsQueryable<Country>().Include(x => x.Localised).ToList();
        }


        /// <summary>
        /// Gets all countries.
        /// </summary>
        /// <returns>List of countries</returns>
        /// <remarks></remarks>
        public List<MonthLocalised> GetLocalisedMonths(string language)
        {
            return this.repository.AsQueryable<MonthLocalised>().Where(c=>c.Language==language).ToList();
        }
        public List<GSTTypesLabels> GetGSTTypes(string language)
        {
            return this.repository.AsQueryable<GSTTypesLabels>().Where(c => c.Language == language).ToList();
        }
        //Added for OFEE changes
        public List<OFEEConfig> GetOFEEConfigsForTA(string IATA, string parentIATA)
        {
            if (string.IsNullOrEmpty(parentIATA))
            {
                return this.repository.AsQueryable<OFEEConfig>().Where(c => (c.ParentIATA == IATA) && c.Active).ToList();
            }
            else
            {
                return this.repository.AsQueryable<OFEEConfig>().Where(c => (c.ParentIATA == parentIATA) && c.Active).ToList();
            }
        }
    }
}
