using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Model.ExternalPricing;
using System.Data.Entity;


namespace flydubai.DatabaseServices
{
   public class CompanionFareDatabaseService
    {
       private readonly IRepository repository;

       public CompanionFareDatabaseService(IRepository repository)
       {
           this.repository = repository;
       }

       public List<CompanionFareConfigs> GetAllCompanionFares()
       {
           return this.repository.AsQueryable<CompanionFareConfigs>().ToList();
       }
    }
}
