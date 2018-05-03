using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace flydubai.DatabaseServices
{
    using flydubai.Model.Content;

    //FR-004 FZWR-5 A-5851 Web Release 3
    public interface IWebsiteSettingService
    {
        string GetAirportCacheRefreshDuration();
    }
}
