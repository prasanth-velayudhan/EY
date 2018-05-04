using System;
using System.Collections.Generic;

namespace Ey.Common.Exceptions
{
    /// <summary>
    /// Ey Service Exception
    /// </summary>
    public class EyServiceException : ApplicationException
    {
        public EyServiceException(string message, SystemException exception)
            : base(message, exception)
        {
        }
    }
}
