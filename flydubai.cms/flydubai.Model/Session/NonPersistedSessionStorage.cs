using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using flydubai.Common;

namespace flydubai.Model.Session
{

    /// <summary>
    /// Non Persisted Session Storage
    /// </summary>
    [Serializable]
    public class NonPersistedSessionStorage : ISessionStorage
    {
        private readonly Dictionary<string, object> _storage = new Dictionary<string, object>();

        public object this[string name]
        {
            get
            {
                if (!this.ContainsKey(name))
                {
                    return null;
                }
                return _storage[name];
            }
            set
            {
                _storage[name] = value;
            }
        }

        /// <summary>
        /// Determines whether the specified name contains key.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        ///   <c>true</c> if the specified name contains key; otherwise, <c>false</c>.
        /// </returns>
        public bool ContainsKey(string name)
        {
            return _storage.ContainsKey(name);
        }
    }
}
