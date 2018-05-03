using System;
using System.Collections.Generic;

namespace flydubai.Common.Exceptions
{
    /// <summary>
    /// FlyDubai Service Exception
    /// </summary>
    public class FlyDubaiServiceException : ApplicationException
    {
        public FlyDubaiServiceException(string message, SystemException exception)
            : base(message, exception)
        {
        }
    }
}
