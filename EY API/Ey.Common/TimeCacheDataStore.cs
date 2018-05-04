using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Common
{
    public class TimedCacheDataStore<T>
    {
        private readonly TimeSpan cacheTimeout = new TimeSpan(0, 0, 30);
        private readonly object syncLock = new object();
        private DateTime lastUpdated = DateTime.UtcNow;
        private int integerDatafield = int.MinValue;
        private IEnumerable<T> data;
        private object item;

        public TimedCacheDataStore(TimeSpan? timeout = null)
        {
            if (!timeout.HasValue)
                return;
            this.cacheTimeout = timeout.Value;
        }

        public IEnumerable<T> Get(Func<IEnumerable<T>> refreshCache)
        {
            lock (this.syncLock)
            {
                if (this.data != null)
                {
                    if (!(this.lastUpdated.Add(this.cacheTimeout) < DateTime.UtcNow))
                        goto label_7;
                }
                this.data = refreshCache();
                this.lastUpdated = DateTime.UtcNow;
            }
            label_7:
            return this.data;
        }

        public T GetItem(Func<T> refreshCache)
        {
            lock (this.syncLock)
            {
                if (this.item != null)
                {
                    if (!(this.lastUpdated.Add(this.cacheTimeout) < DateTime.UtcNow))
                        goto label_7;
                }
                this.item = (object)refreshCache();
                this.lastUpdated = DateTime.UtcNow;
            }
            label_7:
            return (T)this.item;
        }

        public int GetSingleIntegerValue(Func<int> refreshCache)
        {
            lock (this.syncLock)
            {
                if (this.integerDatafield != int.MinValue)
                {
                    if (!(this.lastUpdated.Add(this.cacheTimeout) < DateTime.UtcNow))
                        goto label_7;
                }
                this.integerDatafield = refreshCache();
                this.lastUpdated = DateTime.UtcNow;
            }
            label_7:
            return this.integerDatafield;
        }

        public void Expire()
        {
            lock (this.syncLock)
              this.lastUpdated = DateTime.UtcNow.AddSeconds(-1.0);
        }
    }
}
