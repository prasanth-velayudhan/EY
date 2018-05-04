using System.Collections.Generic;

using Ey.Common.Model;

namespace Ey.Common.Contracts
{
    /// <summary>
    /// ExceptionsService Interface
    /// </summary>
    public interface IExceptionsService
    {
        IEnumerable<ExceptionMessage> GetAllExceptions();
    }
}