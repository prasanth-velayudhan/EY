
namespace flydubai.Common.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// PNR Locked For Modifications
    /// </summary>
    public class PNRLockedForModifications : RadixxException
    {
        public PNRLockedForModifications(RadixxException ex)
            : base(ex.Message, typeof(PNRLockedForModifications), ex.RadixxExceptionCode, ex.RadixxExceptionSource, ex.FlyDubaiOperation, ex.SecurityGuid, ex.RequestMessage, ex.ResponseMessage)
        {

        }

    }
}
