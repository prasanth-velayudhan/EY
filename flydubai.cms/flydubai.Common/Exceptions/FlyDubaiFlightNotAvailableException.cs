
namespace flydubai.Common.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// FlyDubai Flight Not Available Exception
    /// </summary>
    public class FlyDubaiFlightNotAvailableException : ApplicationException
    {
        public FlyDubaiFlightNotAvailableException(string message) : base(message)
        {
            
        }
    }
}
