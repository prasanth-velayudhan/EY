using System.Collections.Generic;

using flydubai.Model.Beta;


namespace flydubai.DatabaseServices
{

    public interface IBetaUniquePageTitleDatabaseService
    {
        List<UniquePageTitle> Get();

        UniquePageTitle Get(string language);

        UniquePageTitle GetWithTracking(string language);

        void Save(UniquePageTitle uniquePageTitle);
    }

}
