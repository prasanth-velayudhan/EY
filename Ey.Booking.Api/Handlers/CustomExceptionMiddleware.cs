//using Ey.Booking.Api.Models;
using Ey.Booking.Api.Models;
using Ey.Common.Logging;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;
using System.Web.Http.Results;

namespace Ey.Booking.Api.Handlers
{

    public class ProcessExceptionFilterAttribute : ExceptionFilterAttribute, IExceptionFilter
    {
        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
     
   
            Logger.ErrorException("Capturing unhandled exception", actionExecutedContext.Exception);
            actionExecutedContext.Request.CreateResponse(HttpStatusCode.InternalServerError,
                new Notification
                {
                    CmsKey = "InternalServerError",
                    DefaultMessage = "Internal Server Error",
                    DisplayLevel = "G",
                    CanContinue = false
                } );
        }
    }
}