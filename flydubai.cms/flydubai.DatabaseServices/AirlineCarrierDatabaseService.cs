using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.DatabaseServices
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;

    using flydubai.Common.Contracts.DatabaseServices;
    using flydubai.Model;

    public class AirlineCarrierDatabaseService
    {
        private readonly IRepository repository;

        public AirlineCarrierDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        public IList<AirlineCarriers> GetAirlineCarriers()
        {
            return this.repository.AsQueryable<AirlineCarriers>().Include(x => x.Localised).ToList();
        }
    }
}
