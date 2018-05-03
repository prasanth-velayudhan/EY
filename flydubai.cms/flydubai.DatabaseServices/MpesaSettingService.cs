using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Content;
using System.Collections.Generic;
using System.Linq;

namespace flydubai.DatabaseServices
{
    public class MpesaSettingDatabaseService
    {
        private readonly IRepository repository;

        public MpesaSettingDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<MpesaSettings> Get()
        {
            return this.repository.AsQueryable<MpesaSettings>().ToList();
        }
    }
}
