using System;

namespace Ey.Common
{
    public interface ICache
    {
        T Get<T>(string key);
        void Set<T>(string key, T value);
        void Set<T>(string key, T value, TimeSpan duration);
        void Set<T>(string key, T value, TimeSpan duration, bool isSlidingExpiration);
        void Remove(string key);
        //bool TryGetValue(string key, out string value);
        T TryGetValue<T>(string key);
        
    }
}
