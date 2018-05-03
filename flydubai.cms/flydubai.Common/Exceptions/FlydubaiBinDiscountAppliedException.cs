
namespace flydubai.Common.Exceptions
{
    using System;

    /// <summary>
    /// FlyDubai Seat Assignment Exception
    /// </summary>
    public class FlydubaiBinDiscountAppliedException : ApplicationException
    {
        public FlydubaiBinDiscountAppliedException(Exception ex)
            : base(ex.Message)
        {
        }

    }
}
