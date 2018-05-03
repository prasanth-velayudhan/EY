using System.Collections.Generic;

using flydubai.Model.Survey;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Interface for SurveyLightBoxDatabaseService
    /// </summary>
    /// <remarks></remarks>
    public interface ISurveyLightBoxDatabaseService
    {
        List<SurveyLightBox> Get();

        SurveyLightBox Get(string language);

        SurveyLightBox GetWithTracking(string language);

        void Save(SurveyLightBox surveyLightBox);
    }
}
