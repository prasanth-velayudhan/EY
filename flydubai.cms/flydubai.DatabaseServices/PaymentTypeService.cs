using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Content;
using System.Collections.Generic;
using System.Linq;

namespace flydubai.DatabaseServices
{
    public class PaymentTypeDatabaseService
    {
        private readonly IRepository repository;

        public PaymentTypeDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<PaymentTypes> Get()
        {
            return this.repository.AsQueryable<PaymentTypes>().ToList();
        }
    }
}
