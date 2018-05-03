using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model.Content;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Interface for RouteMessageDatabaseService
    /// </summary>
    public interface IRouteMessageDatabaseService
    {
        List<RouteMessageVersion> Get();
        List<RouteMessageVersion> Get(int languageId);
    }
}
