using Ey.Model;
using Ey.Model.Results;
using Ey.Model.Search;
using Ey.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Business
{
    public class FlightTask : IFlightTask
    {
        private readonly IFlightService _flightService;
        public FlightTask(IFlightService flightService)
        {
            this._flightService = flightService;
        }

        public async Task<Ey.Model.Results.FlightResults> GetFlightFareQuotes(SearchCriteria searchCriteria, SecurityData securityData)
        {
            return await this._flightService.GetFlightFareQuotes(searchCriteria, securityData);
        }

        public async Task<List<BrandedFareInfo>> GetIncludedServices(SearchCriteria searchCriteria, SecurityData securityData)
        {
            return await this._flightService.GetIncludedServices(searchCriteria, securityData);
        }
    }
}
