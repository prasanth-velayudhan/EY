using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Common
{
    /// <summary>
    /// SessionStorage Interface
    /// </summary>
    public interface ISessionStorage
    {
        object this[string name] { get; set; }
         
        bool ContainsKey(string name);
        T GetAs<T>(string key);
        Task<bool> InitAsync();
        Task<bool> PersistAsync();
        bool RemoveKey(string name);
    }


}
