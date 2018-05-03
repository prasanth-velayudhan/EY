using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Business
{
    public interface IFlightTask
    {
        Task<Ey.Model.Results.FlightResults> GetFlightFareQuotes(Model.Search.SearchCriteria searchCriteria, Model.SecurityData securityData);
    }
}
