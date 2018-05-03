using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model.Content;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Interface for FareTypeIDDatabaseService
    /// </summary>
    public interface IFareTypeIDDatabaseService
    {
        List<FareBrandIDLabel> Get();
        List<FareBrandIDLabel> Get(int languageId);
    }
}
