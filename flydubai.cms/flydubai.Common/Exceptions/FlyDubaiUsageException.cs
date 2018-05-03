using System;
using System.Collections.Generic;

namespace flydubai.Common.Exceptions
{
    /// <summary>
    /// FlyDubai Usage Exception
    /// </summary>
    public class FlyDubaiUsageException : ApplicationException
    {
        public FlyDubaiUsageException(string message)
            : base(message)
        {
        }
      
    }
}
