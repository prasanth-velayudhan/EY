using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common.Exceptions
{
    public class FlyDubaiSummaryPNRException : RadixxException
    {
        public FlyDubaiSummaryPNRException(RadixxException ex)
            : base(ex.Message, typeof(FlyDubaiSummaryPNRException), ex.RadixxExceptionCode, ex.RadixxExceptionSource, ex.FlyDubaiOperation, ex.SecurityGuid, ex.RequestMessage, ex.ResponseMessage)
        {

        }
    }
}
