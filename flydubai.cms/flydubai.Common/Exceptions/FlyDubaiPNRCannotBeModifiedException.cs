
namespace flydubai.Common.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// FlyDubai PNR Cannot Be Modified Exception
    /// </summary>
    public class FlyDubaiPNRCannotBeModifiedException : ApplicationException
    {
        public FlyDubaiPNRCannotBeModifiedException(string message)
            : base(message)
        {
            
        }
    }
}
