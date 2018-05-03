
namespace flydubai.Common.Exceptions
{
    using System;

    /// <summary>
    /// FlyDubai Seat Assignment Exception
    /// </summary>
    public class FlyDubaiSeatAssignmentException : ApplicationException
    {
        public FlyDubaiSeatAssignmentException(string message)
            : base(message)
        {
        }

    }
}
