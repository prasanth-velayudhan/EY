namespace flydubai.Common
{
    /// <summary>
    /// SecurityService Interface
    /// </summary>
    public interface ISecurityService
    {
        string RetrieveSecurityToken();

        string RetrieveSecurityTokenForCacheRefreshes();
    }
}
