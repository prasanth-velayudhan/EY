using System;
using System.Collections.Generic;

namespace flydubai.Common.Exceptions
{
    /// <summary>
    /// Radixx voucher Exception
    /// </summary>
    public class RadixxVoucherException : ApplicationException
    {
        public readonly string Code;
        public readonly string Message;
        public readonly string Actor;

        public RadixxVoucherException(string code, string message, string actor)
            : base(message)
        {
            this.Code = code;
            this.Message = message;
            this.Actor = actor;
        }
    }
}
