// Template: Controller Implementation (ApiControllerImplementation.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using flydubai.Booking.Api.Payment.Models;
using flydubai.Booking.Api.ActionFilters;
using flydubai.Common;
using flydubai.Common.Exceptions;
using flydubai.Business;
using flydubai.Model;
using flydubai.Model.Booking;
using flydubai.Model.Journey;
namespace flydubai.Booking.Api.Payment
{
    [RequireSessionPersistance]
    public partial class ApiPaymentPayLaterController : IApiPaymentPayLaterController
    {
      
        private readonly ISessionStorage _sessionStorage;
        private readonly IPaymentTasks _paymentTasks;
        public ApiPaymentPayLaterController(ISessionStorage sessionStorage,IPaymentTasks paymentTasks)
        {
            _sessionStorage = sessionStorage;
            _paymentTasks = paymentTasks;
        }
        /// <summary>
        /// Api for retriving Pay Later Amount - PayLater
        /// </summary>
        /// <param name="apipaymentpaylaterpostrequestcontent"></param>
        /// <returns>ApiPaymentPayLaterPostOKResponseContent</returns>
        public async Task<IHttpActionResult> Post(Models.ApiPaymentPayLaterPostRequestContent apipaymentpaylaterpostrequestcontent)
        {

            YourJourney summaryPNRJourney = (YourJourney)_sessionStorage["summaryPNRJourney"];
            PassengerNameRecord actualPNR = new PassengerNameRecord();
            var securityData = new SecurityData();
            object securityObj;
            Request.Properties.TryGetValue("securityData", out securityObj);
            securityData = (SecurityData)securityObj;
            try
            {
                actualPNR = this._paymentTasks.PayLater(summaryPNRJourney, securityData);
                return Ok();

            }

            //  //BookingResponseBuilder bookRes = new BookingResponseBuilder();
            //  //ApiBookingCreatePNRPostOKResponseContent response = bookRes.BuildResponse(actualPNR, requestContent);
            //return Ok(response);
            ////PaymentBuilder useVoucherBuilder = new PaymentBuilder();
            ////return Ok(useVoucherBuilder.BuildUseVoucherResponse(resultinPmtDetails));
           
            catch (RadixxVoucherException ex)
            {
                throw new Exception();
            }


        }

    }
}
