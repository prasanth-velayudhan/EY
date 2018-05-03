using System.Collections.Generic;
using flydubai.Common.Model;

namespace flydubai.DatabaseServices
{
    using flydubai.Model;
    using flydubai.Model.Common;
using flydubai.Model.Content;
    using flydubai.Model.Labels;

    /// <summary>
    /// Interface for UserDetailsDatabaseService
    /// </summary>
    /// <remarks></remarks>
    public interface IUserDetailsDatabaseService
    {
        IList<Country> GetAllCountries();
        List<MonthLocalised> GetLocalisedMonths(string language);
        List<OFEEConfig> GetOFEEConfigsForTA(string IATA, string parentIATA);   //OFEE changes
        List<GSTTypesLabels> GetGSTTypes(string language);
    }
}