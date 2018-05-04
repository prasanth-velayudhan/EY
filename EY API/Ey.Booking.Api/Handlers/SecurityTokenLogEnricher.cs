using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Web;
using Ey.Model;
using Serilog.Core;
using Serilog.Events;
using System.Linq;
using Ey.Common.Encryption;

namespace Ey.Booking.Api.Handlers
{

    public class SecurityTokenLogEnricher : ILogEventEnricher
    {
        private readonly string _headerKey;

        public SecurityTokenLogEnricher()
        {
            _headerKey = ConfigurationManager.AppSettings["SecureHeaderHashKey"];

        }

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            if (HttpContext.Current == null || HttpContext.Current.Items["owin.Environment"] == null)
                return;

            var request = HttpContext.Current.GetOwinContext().Request;

            if (request == null)
                return;
            string[] headerValues;
            var tokenHeader = string.Empty;
            if (request.Headers.TryGetValue("securityToken", out headerValues))
            {
                tokenHeader = headerValues.FirstOrDefault();
            }
            if (request.Uri.AbsolutePath.Contains("api/payment/verifyGateWayResponse"))
            {
                tokenHeader = request.Uri.AbsolutePath.Split('/')[4];
            }
            if (request.Uri.AbsolutePath.Contains("api/payment/get3dpage"))
            {
                tokenHeader = request.Uri.AbsolutePath.Split('/')[5];
            }

            if (tokenHeader != null)
            {

                logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty(
                       "securityToken", tokenHeader));

                try
                {
                    var result = EncryptionHelper.Decrypt(tokenHeader, _headerKey);
                    var data = result.Split('_');
                    logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty(
                      "RadixxSecurityToken", data[0]));
                    logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty(
                   "ExpiryDateTime", data[3]));
                    logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty(
                  "AppID", data[4]));

                }
                catch
                {
                    try
                    {

                   
                    string[] AppID;
                    request.Headers.TryGetValue("appID", out AppID);
                    logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty(
                 "AppID", AppID.FirstOrDefault()));
                    }
                    catch (System.Exception)
                    {

                     
                    }
                }

            }
        }
    }
}