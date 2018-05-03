using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.Beta;
namespace flydubai.DatabaseServices
{
    public class BetaUniquePageTitleDatabaseService : IBetaUniquePageTitleDatabaseService
    {
        private readonly IRepository repository;


        public BetaUniquePageTitleDatabaseService(IRepository repository)
        {
            this.repository = repository;
        }

        public List<UniquePageTitle> Get()
        {
            return this.repository.AsQueryable<UniquePageTitle>().ToList();
        }

        public UniquePageTitle Get(string language)
        {
            return this.repository.AsQueryable<UniquePageTitle>().SingleOrDefault(x => x.Language == language);
        }

        public UniquePageTitle GetWithTracking(string language)
        {
            return this.repository.AsQueryableWithTracking<UniquePageTitle>().SingleOrDefault(x => x.Language == language);
        }

        public void Save(UniquePageTitle uniquePageTitle)
        {
            if (!this.repository.AsQueryable<UniquePageTitle>().Any(x => x.Language == uniquePageTitle.Language))
            {
                this.repository.Add(uniquePageTitle);
            }

            this.repository.SaveChanges();
        }
    }
}
