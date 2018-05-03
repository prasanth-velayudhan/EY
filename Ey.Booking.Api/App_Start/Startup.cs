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

        //private static IAirportService _airportTasks;
        //private static ICountryService _countryTasks;
        //private static IRouteMessageService _routeMessageTasks;
        //private static IPaymentTypeService _paymentTypeTasks;
        //private static IPaymentSettingsService _paymentSettingsTasks;
        //private static IApplicationSettingsTasks _applicationSettingsTasks;

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
            //  container.AssertConfigurationIsValid();//
          //  Debug.WriteLine(container.WhatDoIHave());

            HttpConfiguration httpConfiguration = new HttpConfiguration();
            httpConfiguration.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
            ConfigureLog();

            //_airportTasks = container.GetInstance<IAirportService>();
            //_countryTasks = container.GetInstance<ICountryService>();
            //_routeMessageTasks = container.GetInstance<IRouteMessageService>();
            //_paymentTypeTasks = container.GetInstance<IPaymentTypeService>();
            //_paymentSettingsTasks = container.GetInstance<IPaymentSettingsService>();
            //_applicationSettingsTasks = container.GetInstance<IApplicationSettingsTasks>();



            _SecurityServices = container.GetInstance<ISecurityService>();

            httpConfiguration.MessageHandlers.Add(new SecurityHandler(httpConfiguration.DependencyResolver.GetService(typeof(ISecurityTokenTask))
   as ISecurityTokenTask));



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

            var refreshCache = ConfigurationManager.AppSettings["refreshCacheOnStartup"];
            var parseResult = false;
            if (bool.TryParse(refreshCache, out parseResult) & parseResult)
            {
                //For static cahce
                // Set-up a background thread to reload globally cached data whenever the configured interval period expires.
                _refreshables = new List<IRefreshable>
                {
                    
                    //container.GetInstance<IAirportService>(),
                    //container.GetInstance<IRegionsService>(),
                    //container.GetInstance<IPassengerMessagesService>(),
                    //container.GetInstance<ICountryService>(),
                    //container.GetInstance<ICityService>(),
                    ////container.GetInstance<IApplicationSettingsTasks>(),
                    //container.GetInstance<IPaymentTypeService>(),
                    //container.GetInstance<IPaymentSettingsService>(),
                    //container.GetInstance<CodeTypeService>(),
                    //container.GetInstance<IExceptionResourceManager>(),
                    ////container.GetInstance<IFareBasisListCache>(),
                    //container.GetInstance<IBaggageService>(),
                    //container.GetInstance<ISeatingService>(),
                    //container.GetInstance<ICurrencyService>(),
                    //container.GetInstance<IMpesaSettingService>(),
                    //container.GetInstance<IRouteMessageService>(),
                    //container.GetInstance<IInterlineAgrementService>()

                };
                // Call the refresh for the first time on the web thread so everythiong is loaded & no errors
                RefreshGlobalCache(_refreshables);
            }
            //End static cache

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




        private static void RefreshGlobalCache(object stateInfo)
        {
            try
            {
                var refreshables = (IList<IRefreshable>)stateInfo;

                foreach (var cache in refreshables)
                {
                    cache.Refresh();
                }
            }
            catch (System.Exception ex)
            {
                //log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                // Log.Error("Error refreshing global cache", ex);
            }
        }
    }

}