using System;
using System.Configuration;
using System.Threading.Tasks;
using Couchbase;
using Ey.Common.Logging;
using Couchbase.Core;

namespace Ey.Common
{
    public class InCouchBaseCache : ICache
    {
        private readonly string _masterDataBucketName;


        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();

        public InCouchBaseCache()
        {

            _masterDataBucketName = ConfigurationManager.AppSettings["CouchBaseMasterDataBucket"];
        }

        public async Task<T> GetAsync<T>(string key)
        {

            ValidateKey(key);

            var bucket = ClusterHelper.GetBucket(_masterDataBucketName);
            {

                var data = await bucket.GetAsync<T>(key);
                if (data.Success)
                {
                    return data.Value;
                }
            }
            return default(T);

        }

        public void Remove(string key)
        {

            var bucket = ClusterHelper.GetBucket(_masterDataBucketName);
            {
                bucket.Remove(key);
            }


        }


        public T Get<T>(string key)
        {
            ValidateKey(key);
            var bucket = ClusterHelper.GetBucket(_masterDataBucketName);
            {
                var data = bucket.Get<T>(key);
                if (data.Success)
                {
                    return data.Value;
                }
            }

            return default(T);
        }

        public void Set<T>(string key, T value)
        {
            ValidateKey(key);
            SetValue<T>(key, value);


        }

        public void Set<T>(string key, T value, TimeSpan duration)
        {
            SetValue<T>(key, value, duration);

        }

        public void Set<T>(string key, T value, TimeSpan duration, bool isSlidingExpiration)
        {
            SetValue<T>(key, value, duration, isSlidingExpiration);
        }

        private void SetValue<T>(string key, T value, TimeSpan? duration = null, bool isSlidingExpiration = false)
        {

            ValidateKey(key);

            var bucket = ClusterHelper.GetBucket(_masterDataBucketName);
            {
                var upsert = bucket.Upsert(key, value);

                if (!upsert.Success)
                {
                    Logger.ErrorException(upsert.Message, upsert.Exception);
                }

            }

        }

        /// <summary>
        /// Validate the key and out the value
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public T TryGetValue<T>(string key)
        {

            if (key == null)
                throw new ArgumentNullException(nameof(key));
            Logger.Info($"Begin Read for Key { key}");
            var startTime = DateTime.Now;
            var bucket = ClusterHelper.GetBucket(_masterDataBucketName);
            {

                var data = bucket.Get<T>(key);
                if (data.Success)
                {
                    return data.Value;
                }
                Logger.ErrorException(data.Message, data.Exception);
            }
            using (
                LogProvider.OpenMappedContext("TotalTimeTaken", DateTime.Now.Subtract(startTime).Milliseconds.ToString())
                )
            {
                Logger.Info($"End Read for Key {key}");
            }
            return default(T);


        }


        private void ValidateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Key can not be null or empy");
        }

    }
}
