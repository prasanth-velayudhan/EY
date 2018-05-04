// Template: Controller Implementation (ApiControllerImplementation.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using flydubai.Booking.Api.Payment.Models;
using flydubai.Services;
using flydubai.Business;
using flydubai.Model;
using flydubai.Common.Exceptions;
using model = flydubai.Model;
using flydubai.Booking.Api.Builders;
namespace flydubai.Booking.Api.Payment
{
    public partial class ApiPaymentVoucherVerifyController : IApiPaymentVoucherVerifyController
    {
        private readonly IPaymentTasks _paymentTasks;
        public ApiPaymentVoucherVerifyController(IPaymentTasks paymentTasks)
        {
            _paymentTasks = paymentTasks;
        }
        /// <summary>
        /// Api for retriving Verify Voucher - Verify Voucher
        /// </summary>
        /// <param name="apipaymentvoucherverifypostrequestcontent"></param>
        /// <returns>ApiPaymentVoucherVerifyPostOKResponseContent</returns>
        public async Task<IHttpActionResult> Post(Models.ApiPaymentVoucherVerifyPostRequestContent requestContent)
        {
            // TODO: implement Post - route: api/Payment/Voucher/Verify/
            // var result = new ApiPaymentVoucherVerifyPostOKResponseContent();
            // return Ok(result);            

            var result = new ApiPaymentVoucherVerifyPostRequestContent();
            var resultinPrice = new Price();
            //var vm = new  UseVoucherViewModel { VoucherFormModel = formModel };
            // voucher number and pin is expected to be in uppercase.  Convert it here for convenience...
            requestContent.VoucherRefNo = requestContent.VoucherRefNo == null ? null : requestContent.VoucherRefNo.Trim().ToUpper();
            requestContent.VoucherPin = requestContent.VoucherPin == null ? null : requestContent.VoucherPin.Trim().ToUpper();
            var securityData = new model.SecurityData();
            object securityObj;
            Request.Properties.TryGetValue("securityData", out securityObj);
            securityData = (model.SecurityData)securityObj;
            try
            {
                resultinPrice = this._paymentTasks.GetVoucherValue(requestContent.VoucherRefNo, requestContent.VoucherPin, securityData);
            }
            catch (RadixxVoucherException ex)
            {
                throw new Exception();
            }
            var response = new PaymentBuilder().BuildVerifyVoucherResponse(resultinPrice, requestContent);
            return Ok(response);
        }

    }
}
