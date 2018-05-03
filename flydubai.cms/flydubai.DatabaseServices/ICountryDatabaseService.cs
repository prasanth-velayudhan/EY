using System.Collections.Generic;
using flydubai.Common.Model;

namespace flydubai.DatabaseServices
{
    using flydubai.Model;

    /// <summary>
    /// Interface for CountryDatabaseService
    /// </summary>
    /// <remarks></remarks>
    public interface ICountryDatabaseService
    {
        IList<Country> GetAllCountries();
        IEnumerable<CountryLocalised> GetAllLocalisedCountries();
    }
}