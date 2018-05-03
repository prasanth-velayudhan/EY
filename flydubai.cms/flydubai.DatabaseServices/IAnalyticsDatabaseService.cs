using flydubai.Model.Content.Analytics;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Interface for AnalyticsDatabaseService
    /// </summary>
    /// <remarks></remarks>
    public interface IAnalyticsDatabaseService
    {
        GoogleAnalytics Get();

        GoogleAnalytics GetWithTracking();

        void Save(GoogleAnalytics googleAnalytics);
    }
}
