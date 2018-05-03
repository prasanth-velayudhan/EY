using System.Collections.Generic;

using flydubai.Model.Currency;

namespace flydubai.DatabaseServices
{
    public interface ICurrencySettingsDatabaseService
    {
        List<CurrencySetting> Get();

        CurrencySetting Get(string groupname);

        CurrencySetting GetWithTracking(string groupname);

        List<CurrencySetting> GetAllCurr();

        void Save(CurrencySetting currencySettings);
    }
}
