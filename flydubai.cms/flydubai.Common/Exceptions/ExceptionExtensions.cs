using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common.Exceptions
{
    /// <summary>
    /// Exception Extensions
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Gets the innermost exception message.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>Exception message</returns>
        public static string GetInnermostExceptionMessage(this Exception exception)
        {
            if (exception.InnerException == null)
            {
                return exception.Message;
            }
            return exception.InnerException.GetInnermostExceptionMessage();
        }
    }
}
