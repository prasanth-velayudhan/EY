using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Text.RegularExpressions;
using Ey.Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Ey.Model;
//using System.ServiceModel;

namespace Ey.Booking.Api.Handlers
{
    public class LogRequestAndResponseHandler : DelegatingHandler
    {
        DateTime reqTime = DateTime.MinValue;
        DateTime resTime = DateTime.MinValue;
        private static readonly ILog log = LogProvider.GetCurrentClassLogger();
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!log.IsDebugEnabled())
            {
                return await base.SendAsync(request, cancellationToken);
            }

            // let other handlers process the request
            var result = await base.SendAsync(request, cancellationToken);
            // log request body
            if (request.Content != null && !request.RequestUri.AbsolutePath.Contains("api/masters"))
            {
                var requestBody = await request.Content.ReadAsStringAsync();

                reqTime = DateTime.Now;
                if (string.IsNullOrEmpty(requestBody))
                {
                    requestBody = request.RequestUri != null ? request.RequestUri.ToString() : "";
                    reqTime = DateTime.Now;
                }


                // once response body is ready, log it
                if (result.Content != null)
                {
                    var responseBody = await result.Content.ReadAsStringAsync();

                    resTime = DateTime.Now;


                    var headerValues = request.Properties["securityToken"];

                    //var securityData = new SecurityData();
                    //if (request.Properties["securityData"] != null)
                    //{
                    //    securityData = (SecurityData)request.Properties["securityData"];
                    //}

                    log.Debug("Request and Response");
                    using (LogProvider.OpenMappedContext("IPAddress", GetClientIp(request)))
                    {
                        using (LogProvider.OpenMappedContext("ApiResponse", responseBody))
                        {
                            using (LogProvider.OpenMappedContext("ApiRequest", requestBody))
                            {
                                using (LogProvider.OpenMappedContext("securityToken", Convert.ToString(headerValues)))
                                {
                                    //using (LogProvider.OpenMappedContext("securityData", Convert.ToString(securityData.RadixxToken)))
                                    //{
                                    //    log.Debug("RequestTime : " + reqTime.ToString() + " ## " + "ResponseTime : " + resTime.ToString());
                                    //}
                                }
                            }
                        }
                    }
                }
                else if (request.Content != null && result.Content == null)
                {
                    using (LogProvider.OpenMappedContext("ApiRequest", requestBody))
                    {
                        log.Debug("RequestTime : " + reqTime.ToString());
                    }

                }
               
            }
            return result;
        }

        private string GetClientIp(HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            }

            //if (request.Properties.ContainsKey(RemoteEndpointMessageProperty.Name))
            //{
            //    RemoteEndpointMessageProperty prop;
            //    prop = (RemoteEndpointMessageProperty)request.Properties[RemoteEndpointMessageProperty.Name];
            //    return prop.Address;
            //}

            return null;
        }
    }
}