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

        public Task<Ey.Model.Results.FlightResults> GetFlightFareQuotes(SearchCriteria searchCriteria, SecurityData securityData)
        {
            return this._flightService.GetFlightFareQuotes(searchCriteria, securityData);
        }
    }
}
