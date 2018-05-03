using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Ey.Booking.Api.DependencyResolution;
//using Ey.Business;
using Ey.Common;
using Ey.Model;
using StructureMap;
using System.Configuration;
using Ey.Common.Logging;
using Ey.Business;

namespace Ey.Booking.Api.ActionFilters
{

    public class SecurityHandler : DelegatingHandler
    {
        private readonly ISecurityTokenTask _securityTokenTask;


        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();
        public SecurityHandler(ISecurityTokenTask securityTokenTask)
        {
            _securityTokenTask = securityTokenTask;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            IEnumerable<string> headerValues;
            var tokenHeader = string.Empty;
            var AppID = string.Empty;

            if (request.Headers.TryGetValues("securityToken", out headerValues))
            {
                tokenHeader = headerValues.FirstOrDefault();
            }
           
            SecurityData securityData = new SecurityData();
            if (string.IsNullOrWhiteSpace(tokenHeader))
            {
                if (request.RequestUri.AbsolutePath.Contains("api/masters") )
                {
                    return await base.SendAsync(request, cancellationToken);
                }
                if (request.RequestUri.AbsolutePath.Contains("api/flights"))                    
                {                    
                    securityData = await _securityTokenTask.GenerateAsync(request.GetClientIpAddress(), "");
                }
                else
                {
                    return await SendError("API Key Missing on Request", HttpStatusCode.Forbidden);
                }
            }
            else
            {
                try
                {
                    securityData = _securityTokenTask.DecrySecurityData(tokenHeader);

                    if (securityData.ExpiryDateTime < DateTime.Now)
                    {
                        return await SendError("Expired API Key", HttpStatusCode.Forbidden);
                    }
                }
                catch
                {
                    return await SendError("Wrong API Key", HttpStatusCode.Forbidden);
                }
            }
            request.Properties.Add("securityToken", _securityTokenTask.EncryptSecurityData(securityData));

            request.Properties.Add("securityData", securityData);

            UpdateDependencyScope(request, securityData);

            return await base.SendAsync(request, cancellationToken).ContinueWith(task =>
            {
                var response = task.Result;
                if (response.IsSuccessStatusCode)
                {
                    object securityObj;
                    request.Properties.TryGetValue("securityToken", out securityObj);
                    if (securityObj != null) response.Headers.Add("securityToken", securityObj.ToString());
                }

                return response;
            }, cancellationToken); ;
        }
        internal static void UpdateDependencyScope(HttpRequestMessage request, SecurityData securityData)
        {
            var scope = request.GetDependencyScope() as StructureMapWebApiDependencyScope;

            scope?.CurrentNestedContainer
                .Configure(cfg => cfg.For<HttpRequestMessage>().Use(request));
            scope?.CurrentNestedContainer
               .Configure(cfg => cfg.For<SecurityData>().Use(securityData));
        }
        private Task<HttpResponseMessage> SendError(string error, HttpStatusCode code)
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent(error);
            response.StatusCode = code;

            return Task<HttpResponseMessage>.Factory.StartNew(() => response);
        }
        
        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;

        }
    }

    public static class HttpRequestMessageExtensions
    {
        public static string GetClientIpAddress(this HttpRequestMessage request)
        {
            try
            {
                IEnumerable<string> clientIp;
                string ipAddress = string.Empty;
                Microsoft.Owin.IOwinContext owinContext = request.GetOwinContext();
                if (owinContext != null)
                {
                    ipAddress = request.GetOwinContext().Request.RemoteIpAddress;

                    if (ipAddress == "127.0.0.1")
                    {
                        if (request.Headers.TryGetValues("X-Forwarded-For", out clientIp))
                        {
                            ipAddress = clientIp.FirstOrDefault();
                        }
                    }
                }
                return ipAddress;
            }
            catch 
            {

                return string.Empty;
            }

        }
    }
}