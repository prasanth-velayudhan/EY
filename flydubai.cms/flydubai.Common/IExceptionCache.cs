using System.Collections.Generic;

using flydubai.Common.Contracts.Model;

namespace flydubai.Common
{
    /// <summary>
    /// ExceptionCache interface
    /// </summary>
    public interface IExceptionCache
    {
        IEnumerable<IExceptionMessage> GetExceptions();

        string GetExceptionMessage(string key);
    }
}