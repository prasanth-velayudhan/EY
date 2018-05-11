using Ey.Common;
using Ey.Model;
using Ey.Model.Results;
using Ey.Model.Search;
using Ey.Services.SabreFareQuote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ey.Services
{
    public class FlightService : IFlightService
    {
        private readonly IHttpClientService _httpClentService;
        private readonly SSSAdvShopPortType _sabreService;

        public FlightService(IHttpClientService httpClentService, SSSAdvShopPortType sabreService)
        {
            this._httpClentService = httpClentService;
            this._sabreService = sabreService;
        }
        private async Task<Ey.Model.Results.FlightResults> GetFareQuotes(SearchCriteria searchCriteria, SecurityData securityData)
        {
            Builders.FlightFareQuoteBuilder fltServiceRqRsBuilder = new Builders.FlightFareQuoteBuilder();
            var secHeader = new Security()
            {
                BinarySecurityToken = securityData.SabreToken
            };
            var msgHeader = fltServiceRqRsBuilder.GetFlightFareMessageHeader();
            OTA_AirLowFareSearchRQ frReq = fltServiceRqRsBuilder.GetFlightFareSearchRequest(searchCriteria);
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            var res = this._sabreService.SSSAdvShopRQ(new SSSAdvShopRQRequest() { MessageHeader = msgHeader, Security = secHeader, OTA_AirLowFareSearchRQ = frReq });
            return fltServiceRqRsBuilder.BuildResponse(res.OTA_AirLowFareSearchRS, frReq.TravelerInfoSummary.PriceRequestInformation.CurrencyCode);
        }
        public async Task<Ey.Model.Results.FlightResults> GetFlightFareQuotes(SearchCriteria searchCriteria, SecurityData securityData)
        {
            var fareTask = Task.Run(() => this.GetFareQuotes(searchCriteria, securityData));
            //Task<BrandedFareInfo>[] tasks = searchCriteria.Flights.Select((criteria, i) => Task.Run(() => GetFareBrandInfo(criteria, securityData.SabreToken, i + 1))).ToArray();
            Task.WaitAll();
            var result = fareTask.Result;
            //result.BrandedFareInfo = new List<BrandedFareInfo>();
            //foreach (var tsk in tasks)
            //{
            //    if (tsk.Result != null)
            //    {
            //        result.BrandedFareInfo.Add(tsk.Result);
            //    }
            //}
            return result;
        }

        private async Task<BrandedFareInfo> GetFareBrandInfo(FlightCriteria criteria, string token, int criteriaIndex)
        {
            BrandedFareInfo response = null;

            try
            {
                string origin = criteria.Origin.Trim();
                string dest = criteria.Destination.Trim();
                string url = string.Format("{0}/{1}/{2}/{3}/{4}", ConfigurationManager.AppSettings["BrandedFareServiceUrl"], origin, dest, Constants.AirportCountryCodes[origin], Constants.AirportCountryCodes[dest]);
                response = await _httpClentService.GetAsync<BrandedFareInfo>(url, token);
                response.SegmentId = criteriaIndex;
            }
            catch (Exception ex)
            {
                string json = File.ReadAllText(@"D:\Sreekanth\Work\POCs\Ethihad Web\Temp\AUH_BAH BrandedFares.json");
                response = Newtonsoft.Json.JsonConvert.DeserializeObject<BrandedFareInfo>(json);
                response.SegmentId = criteriaIndex;
            }
            return response;
        }

    }
}
