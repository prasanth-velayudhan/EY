using System.Collections.Generic;
using flydubai.Model;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// interface of SpecialOfferDatabaseService
    /// </summary>
    public interface ISpecialOfferDatabaseService
    {
        List<Airport> GetAirports(int languageId);
    }
}
