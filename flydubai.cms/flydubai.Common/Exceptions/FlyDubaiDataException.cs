using System;
using System.Collections.Generic;

namespace flydubai.Common.Exceptions
{
    /// <summary>
    /// FlyDubai Data Exception
    /// </summary>
    public class FlyDubaiDataException : ApplicationException
    {
        public FlyDubaiDataException(string message)
            : base(message)
        {
            this.EntityExceptions = new List<FlyDubaiEntityException>();
        }

        public List<FlyDubaiEntityException> EntityExceptions { get; set; }        
    }
}
