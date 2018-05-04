
using System;
using System.Configuration;
using System.Runtime.Caching;
using System.Runtime.InteropServices;


namespace Ey.Common
{
  
    public  class CacheManager
    {
        private readonly int _expiryMinutes;
        public ICache DistributedCacheInstance { get; }
        private readonly object syncLock = new object();
        public CacheManager (InCouchBaseCache inDistributedCacheInstance)
        {
            DistributedCacheInstance = inDistributedCacheInstance;
            var inMemoryCacheRefreshMinutes = ConfigurationManager.AppSettings["InMemoryCacheExpiryMinutes"];
            _expiryMinutes = 0;
            if (!int.TryParse(inMemoryCacheRefreshMinutes, out _expiryMinutes))
            {
                _expiryMinutes = 60;
            }
        }
        public T Get<T>(string key )
        {
            
            var cache = MemoryCache.Default;
            if (!cache.Contains(key))
            {                
               var  result = DistributedCacheInstance.TryGetValue<T>(key);
                var cacheItem = new CacheItem(key, result);
                var policy = new CacheItemPolicy {AbsoluteExpiration = DateTime.Now.AddMinutes(_expiryMinutes)};
                lock (this.syncLock)
                {
                    if (result!=null)
                    {
                      
                        MemoryCache.Default.Add(cacheItem, policy);
                    }
                  
                }
            }
            var value = (T)Convert.ChangeType(cache[key], typeof(T)); 
            return value;
          
        }
  


    }
}
