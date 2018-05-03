using System.Collections.Generic;
using flydubai.Model;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Interface for CityDatabaseService
    /// </summary>
    /// <remarks></remarks>
    public interface ICityDatabaseService
    {
        IList<City> GetAllCities();
        
        IList<City> GetCities(int countryId);

        IEnumerable<CityLocalised> GetAllLocalisedCities();
        
        City GetSingleCity(int cityId);
    }
}