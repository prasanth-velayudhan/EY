using Ey.Booking.Api.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Ey.Booking.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            GlobalConfiguration.Configuration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.LocalOnly;
            config.Formatters.Add(new RAML.Api.Core.XmlSerializerFormatter());
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Filters.Add(new ProcessExceptionFilterAttribute());
        }
    }
}