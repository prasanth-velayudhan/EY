using Ey.Common;
using Ey.Model;
using Ey.Model.Search;
using Ey.Services.SabreFareQuote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ey.Services
{
    public class FlightService : IFlightService
    {
        public async Task<Ey.Model.Results.FlightResults> GetFlightFareQuotes(SearchCriteria searchCriteria, SecurityData securityData)
        {
            Builders.FlightFareQuoteBuilder fltServiceRqRsBuilder = new Builders.FlightFareQuoteBuilder();
            var secHeader = new Security()
            {
                BinarySecurityToken = securityData.SabreToken
            };
            var msgHeader = fltServiceRqRsBuilder.GetFlightFareMessageHeader();
            OTA_AirLowFareSearchRQ frReq = fltServiceRqRsBuilder.GetFlightFareSearchRequest(searchCriteria);

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Transport;
            binding.OpenTimeout = new TimeSpan(0, 100, 0);
            binding.CloseTimeout = new TimeSpan(0, 100, 0);
            binding.SendTimeout = new TimeSpan(0, 100, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 100, 0);
            binding.MaxReceivedMessageSize = 2147483647;
            binding.MaxBufferSize = 2147483647;
            binding.MaxBufferPoolSize = 2147483647;
            SSSAdvShopPortTypeClient client = new SSSAdvShopPortTypeClient(binding, new EndpointAddress(new Uri("https://sws-crt.cert.sabre.com")));

            var os = client.SSSAdvShopRQ(ref msgHeader, ref secHeader, frReq);

            //var os1 = await client.SSSAdvShopRQAsync(msgHeader, secHeader, frReq);
            //os1.OTA_AirLowFareSearchRS

            return fltServiceRqRsBuilder.BuildResponse(os);
        }
    }
}
