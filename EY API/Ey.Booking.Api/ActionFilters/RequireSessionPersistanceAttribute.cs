using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Ey.Common;
using Ey.Common.Logging;

namespace Ey.Booking.Api.ActionFilters
{
    class RequireSessionPersistanceAttribute : ActionFilterAttribute
    {       
        public bool WaitForPersistancce { get; set; }

        public override async Task OnActionExecutingAsync(HttpActionContext actionContext,
            CancellationToken cancellationToken)
        {
           var session = actionContext.Request.GetDependencyScope()
                .GetService(typeof(ISessionStorage)) as ISessionStorage;

            if (session != null)
            {
              var result= await session.InitAsync();
              
            }
            await base.OnActionExecutingAsync(actionContext, cancellationToken);
        }



        public override async Task OnActionExecutedAsync(HttpActionExecutedContext actionExecutedContext,
            CancellationToken cancellationToken)
        {           
            if (actionExecutedContext.Exception == null)
            {
                var session = actionExecutedContext.Request.GetDependencyScope()
                .GetService(typeof(ISessionStorage)) as ISessionStorage;

                var result = await session.PersistAsync();
            }

            base.OnActionExecuted(actionExecutedContext);
        }
    }
}
    ;