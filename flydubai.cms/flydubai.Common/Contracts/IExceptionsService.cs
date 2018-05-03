using System.Collections.Generic;

using flydubai.Common.Model;

namespace flydubai.Common.Contracts
{
    /// <summary>
    /// ExceptionsService Interface
    /// </summary>
    public interface IExceptionsService
    {
        IEnumerable<ExceptionMessage> GetAllExceptions();
    }
}