
namespace flydubai.DatabaseServices
{
    using flydubai.Common.Contracts.DatabaseServices;
    using flydubai.Common.Model;
    using flydubai.Model.Content;
    using System.Linq;
    //FR-004 FZWR-5 A-5851 Web Release 3
    public class WebsiteSettingService : IWebsiteSettingService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteSettingService"/> class.
        /// </summary>
        /// <param name="repository">repository</param>
        public WebsiteSettingService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets the airport cache refresh duration
        /// </summary>
        /// <returns></returns>
        public string GetAirportCacheRefreshDuration() 
        {
            return this.repository.AsQueryable<WebsiteSetting>().SingleOrDefault(e => e.Key == "AirportCacheRefreshDuration").Value;
        }
    }
}
