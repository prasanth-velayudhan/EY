// Template: Controller Interface (ApiControllerInterface.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using flydubai.Booking.Api.Booking.Models;


namespace flydubai.Booking.Api.Booking
{
    public interface IApiBookingPrintController
    {

        Task<IHttpActionResult> Get();
    }
}
