using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common
{
    /// <summary>
    /// SessionStorage Interface
    /// </summary>
    public interface ISessionStorage
    {
        object this[string name] { get; set; }

        bool ContainsKey(string name);
    }
}
