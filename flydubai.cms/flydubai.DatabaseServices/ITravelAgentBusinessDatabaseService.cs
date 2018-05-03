using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Interface of TravelAgentBusinessDatabaseService
    /// </summary>
    public interface ITravelAgentBusinessDatabaseService
    {
        List<City> GetCities(int languageId);
    }
}
