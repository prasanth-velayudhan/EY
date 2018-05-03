using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Interface for LogDatabaseService
    /// </summary>
    /// <remarks></remarks>
    public interface ILogDatabaseService
    {
        List<Log> Get(int take);

        List<Log> Get(int skip, int take);

        List<Log> Get(string query);
    }
}
