// Template: Controller Implementation (ApiControllerImplementation.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using flydubai.Booking.Api.Payment.Models;
using flydubai.Business;
using flydubai.Model.Payment;
using flydubai.Common.Exceptions;
using model = flydubai.Model;
using flydubai.Booking.Api.Builders;
namespace flydubai.Booking.Api.Payment
{
    public partial class ApiPaymentVoucherUseController : IApiPaymentVoucherUseController
    {
        private readonly IPaymentTasks _paymentTasks;
        public ApiPaymentVoucherUseController(IPaymentTasks paymentTasks)
        {

            _paymentTasks = paymentTasks;
        }
        /// <summary>
        /// Api for retriving Use Voucher - Use Voucher
        /// </summary>
        /// <param name="apipaymentvoucherusepostrequestcontent"></param>
        /// <returns>ApiPaymentVoucherUsePostOKResponseContent</returns>
        public async Task<IHttpActionResult> Post(Models.ApiPaymentVoucherUsePostRequestContent apipaymentvoucherusepostrequestcontent)
        {
        // TODO: implement Post -route: api / Payment / Voucher / Use /
            // var result = new ApiPaymentVoucherUsePostOKResponseContent();
            //return Ok(result);
            var resultinPmtDetails = new VoucherPaymentDetails();
            var securityData = new model.SecurityData();
            object securityObj;
            Request.Properties.TryGetValue("securityData", out securityObj);
            securityData = (model.SecurityData)securityObj;
            // securityData.RadixxToken = "4caf1207-c744-417d-8053-5a835f7d6a00";
            try
            {
                resultinPmtDetails = this._paymentTasks.AddVoucher(apipaymentvoucherusepostrequestcontent.VoucherRefNo.Trim(), apipaymentvoucherusepostrequestcontent.VoucherPin.Trim(), securityData);
                //this.UserSessionTasks.UserSession.VoucherSequenceNumber++;
            }

            //return this.VoucherInput();
            catch (RadixxVoucherException ex)
            {
                throw new Exception();
            }
            PaymentBuilder useVoucherBuilder = new PaymentBuilder();
            return Ok(useVoucherBuilder.BuildUseVoucherResponse(resultinPmtDetails));
          
        }

    }
}
