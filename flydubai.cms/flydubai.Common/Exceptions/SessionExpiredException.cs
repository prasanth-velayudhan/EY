using System;

namespace flydubai.Common.Exceptions
{
    /// <summary>
    /// Session Expired Exception
    /// </summary>
    public class SessionExpiredException : ApplicationException
    {
        public SessionExpiredException(string strOptExceptionMsg = "Application Session Expired")
            : base(strOptExceptionMsg)
        {
        }
    }
}
