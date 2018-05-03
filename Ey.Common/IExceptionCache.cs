using System.Collections.Generic;

using Ey.Common.Contracts.Model;

namespace Ey.Common
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