using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Services
{
    public interface IFlightService
    {
        Task<Ey.Model.Results.FlightResults> GetFlightFareQuotes(Ey.Model.Search.SearchCriteria searchCriteria, Ey.Model.SecurityData securityData);
    }
}
