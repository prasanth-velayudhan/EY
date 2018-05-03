
namespace flydubai.Common.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Flydubai critical payment exception
    /// </summary>
    public class FlydubaiCriticalPaymentException : ApplicationException
    {
        public FlydubaiCriticalPaymentException(string message) : base(message)
        {
            
        }

        public FlydubaiCriticalPaymentException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
    }
}
