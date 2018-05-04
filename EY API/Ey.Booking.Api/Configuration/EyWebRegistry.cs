using System.Web;
using Couchbase;
using Ey.Common;
using StructureMap;
using StructureMap.Graph;
//using Ey.Website.Common.Cache;
//using Ey.Website.Common.Helpers;

namespace Ey.Booking.Api.Configuration
{
    /// <summary>
    /// EyWebRegistry class
    /// </summary>
    public class EyWebRegistry : Registry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EyWebRegistry" /> class.
        /// </summary>
        /// <param name="binFolder">An instance of <see cref="System.String" />.</param>
        public EyWebRegistry()
        {
            Scan(assemblyScanner =>
            {
                assemblyScanner.WithDefaultConventions();
                assemblyScanner.AssembliesFromApplicationBaseDirectory();
                assemblyScanner.TheCallingAssembly();
                assemblyScanner.LookForRegistries();
            });
            ClusterHelper.Initialize("couchbaseClients/couchbase");
          
            this.For<HttpContextBase>().Use(x => GetContext());
           
           // this.For<SecurityData>().Use(x => GetSecurityData()).Transient();
            //this.For<ISessionStorage>().Use<CouchBaseSessionStore>();
            //this.For<ILockable>().Use<CouchBaseLock>();
            this.For<Cluster>().Use(ClusterHelper.Get()).Singleton();
            this.For<CacheManager>().Use(new CacheManager(new InCouchBaseCache())).Singleton();
            // this.For<ISessionPesistanceStore>().Use<RedisSessionStorage>();
        }
        ///// <summary>
        ///// Gets the radixx security Token for the data.
        ///// </summary>
        ///// <returns><see cref="SecurityData" /></returns>
        //private static SecurityData GetSecurityData()
        //{
          
        //   var request=  (HttpRequestMessage)HttpContext.Current.Items["MS_HttpRequestMessage"];
        //    if (request == null)
        //        return null;
        //    SecurityData securityData;
        //    object securityObj;
        //    request.Properties.TryGetValue("securityData", out securityObj);
        //    securityData = (SecurityData)securityObj;
        //    return securityData;
        //}

        /// <summary>
        /// Gets the current context.
        /// </summary>
        /// <returns><see cref="HttpContextBase" /></returns>
        private static HttpContextBase GetContext()
        {
            if (HttpContext.Current == null)
           { 
                return null;
            }

            var context = new HttpContextWrapper(HttpContext.Current);

            return context;
        }
    }
}