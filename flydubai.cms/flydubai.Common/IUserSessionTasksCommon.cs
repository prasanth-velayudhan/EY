using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common
{
    public interface IUserSessionTasksCommon
    {
        Dictionary<string, object> GetUserSessionValue(List<string> key);
    }
}
