using System.Collections.Generic;

using flydubai.Model.Mpesa;

namespace flydubai.DatabaseServices
{
    public interface IMpesaSettingsDatabaseService
    {
        List<MpesaSetting> Get();

        MpesaSetting Get(int countryID);

        MpesaSetting GetWithTracking(int countryID);

        List<MpesaSetting> GetAllMpesa();

        void Save(MpesaSetting mPesaSetting);
    }
}
