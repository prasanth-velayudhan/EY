using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http;
using Ey.Booking.Api.ActionFilters;
using Ey.Booking.Api.DependencyResolution;
using Ey.Business;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using StructureMap;
using System;
using System.Collections.Generic;
using Ey.Common.Contracts;
using Ey.Services;
using Ey.Common;
using System.Configuration;
using Ey.Booking.Api.Handlers;
using Ey.Common.Contracts.Business;
using Serilog;
using Serilog.Enrichers;
using Serilog.Formatting.Json;
using Serilog.Sinks.RollingFile;
using Couchbase;
using System.Threading;

[assembly: OwinStartup(typeof(Ey.Booking.Api.Startup))]
namespace Ey.Booking.Api
{
    public class Startup
    {
        private static IList<IRefreshable> _refreshables;

        private static ISecurityService _SecurityServices;

        public void Configuration(IAppBuilder app)
        {          
            var context = new OwinContext(app.Properties);
            var token = context.Get<CancellationToken>("host.OnAppDisposing");
            if (token != CancellationToken.None)
            {
                token.Register(ClusterHelper.Close);
            }
            // setup http configuration
            IContainer container = IoC.Initialize();
            HttpConfiguration httpConfiguration = new HttpConfiguration();
            httpConfiguration.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
            ConfigureLog();
            _SecurityServices = container.GetInstance<ISecurityService>();
            httpConfiguration.MessageHandlers.Add(new SecurityHandler(httpConfiguration.DependencyResolver.GetService(typeof(ISecurityTokenTask)) as ISecurityTokenTask));
            httpConfiguration.MessageHandlers.Add(new LogRequestAndResponseHandler());
            WebApiConfig.Register(httpConfiguration);
            var policy = new CorsPolicy
            {
                AllowAnyHeader = true,
                AllowAnyMethod = true,
                
                SupportsCredentials = true
            };

            var origins = ConfigurationManager.AppSettings[Constants.CorsOriginsSettingKey];

            if (!string.IsNullOrEmpty(origins))
            {
                foreach (var origin in origins.Split(';'))
                {
                    policy.Origins.Add(origin);
                }
            }
            else
            {
                policy.AllowAnyOrigin = true;
            }
            policy.ExposedHeaders.Add("securityToken");

            app.UseCors(new CorsOptions
            {
                PolicyProvider = new CorsPolicyProvider
                {
                    PolicyResolver = cc => Task.FromResult(policy)
                }
            });

            app.UseWebApi(httpConfiguration);            
        }

        private static void ConfigureLog()
        {
            string sLogPath = ConfigurationManager.AppSettings["logpath"];
            Log.Logger = new LoggerConfiguration().ReadFrom.AppSettings()
            .WriteTo.Sink(new RollingFileSink(Path.Combine(sLogPath, "Web-Log-{Date}.txt")
                            , new JsonFormatter(), null, null, null))
                         .Enrich.FromLogContext()
                         .Enrich.With(new ThreadIdEnricher(),
                         new MachineNameEnricher(), new SecurityTokenLogEnricher())
                         .CreateLogger();
        }

        protected void Application_UpdateRequestCache(object sender, EventArgs e)
        {
            //Response.Write("Application_UpdateRequestCache" + "<br/>");
        }
        private void PrintCurrentIntegratedPipelineStage(IOwinContext context, string msg)
        {
            var currentIntegratedpipelineStage = HttpContext.Current.CurrentNotification;
            context.Get<TextWriter>("host.TraceOutput").WriteLine(
                "Current IIS event: " + currentIntegratedpipelineStage
                + " Msg: " + msg);
        }        
    }

}