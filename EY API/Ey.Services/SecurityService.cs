using Ey.Common;
using Ey.Services.SabreFareQuote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Services
{
    /// <summary>
    /// Service to retrieve a security token
    /// </summary>
    /// <remarks></remarks>
    public class SecurityService : ISecurityService
    {
        private readonly SSSAdvShopPortType _sabreService;
        public SecurityService(SSSAdvShopPortType sabreService)
        {         
            this._sabreService = sabreService;
        }
        /// <summary>
        /// Retrieves the security token.
        /// </summary>
        /// <returns>Token</returns>
        /// <remarks></remarks>
        public async Task<string> RetrieveSecurityTokenAsync()
        {
            string token = string.Empty;
            try
            {
                var secHeader = new Security()
                {
                    UsernameToken = new SecurityUsernameToken()
                    {
                        Username = ConfigurationManager.AppSettings["SabreUserName"],
                        Password = ConfigurationManager.AppSettings["SabrePassword"],
                        Organization = "EY",
                        Domain = "EY"
                    }
                };
                var msgHeader = new MessageHeader()
                {
                    ConversationId = "EY_Test",
                    From = new From() { PartyId = new PartyId[] { new PartyId() { type = "urn:x12.org:IO5:01", Value = "99999" } } },
                    To = new To() { PartyId = new PartyId[] { new PartyId() { type = "urn:x12.org:IO5:01", Value = "123123" } } },
                    CPAId = "EY",
                    Service = new Service() { type = "OTA", Value = "CDI" },
                    Action = "SessionCreateRQ",
                    MessageData = new MessageData()
                    {
                        MessageId = "mid:20001209-133003-2333@clientofsabre.com",
                        RefToMessageId = "mid:20001209-133003-2333@clientofsabre.com",
                        Timestamp = "2010-10-13T11:15:12Z",
                        TimeToLive = Convert.ToDateTime("2010-10-31T11:15:12Z")
                    }
                };

                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

                var res = this._sabreService.SSSAdvShopRQ(new SSSAdvShopRQRequest() { MessageHeader = msgHeader, Security = secHeader, OTA_AirLowFareSearchRQ = null });

                if (res != null && !string.IsNullOrEmpty(res.Security.BinarySecurityToken))
                {
                    token = res.Security.BinarySecurityToken;
                }
            }
            catch (Exception ex)
            {
                // log exception
            }
            return token;
        }
    }
}
