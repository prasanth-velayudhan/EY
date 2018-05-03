
namespace flydubai.Common.Exceptions
{
    using System;

    /// <summary>
    /// FlyDubai Seat Assignment Exception
    /// </summary>
    public class FlydubaiMealSoldOutException : ApplicationException
    {
        public FlydubaiMealSoldOutException(string message)
            : base(message)
        {
        }

    }
}
