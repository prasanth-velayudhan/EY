using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common.Exceptions
{
    public class FlyDubaiLowAvailableCreditException : RadixxException
    {
        public FlyDubaiLowAvailableCreditException(RadixxException ex)
            : base(ex.Message, typeof(PNRLockedForModifications), ex.RadixxExceptionCode, ex.RadixxExceptionSource, ex.FlyDubaiOperation, ex.SecurityGuid, ex.RequestMessage, ex.ResponseMessage)
        {

        }
    }
}
