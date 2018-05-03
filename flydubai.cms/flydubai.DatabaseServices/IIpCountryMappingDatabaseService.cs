using System.Collections.Generic;
using flydubai.Model.Content;

namespace flydubai.DatabaseServices
{

    /// <summary>
    /// Interface for IP Country mapping
    /// </summary>
    public interface IIpCountryMappingDatabaseService
    {
        IEnumerable<IpCountryMapping> Get();
    }
}