using System.Collections.Generic;

using flydubai.Model.Beta;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Interface for BetaInterceptLightBoxDatabaseService
    /// </summary>
    /// <remarks></remarks>
    public interface IBetaInterceptLightBoxDatabaseService
    {
        List<InterceptLightBox> Get();

        InterceptLightBox Get(string language);

        InterceptLightBox GetWithTracking(string language);

        void Save(InterceptLightBox interceptLightBox);
    }
}
