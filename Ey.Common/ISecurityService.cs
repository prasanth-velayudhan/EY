using System.Threading.Tasks;

namespace Ey.Common
{
    /// <summary>
    /// SecurityService Interface
    /// </summary>
    public interface ISecurityService
    {
        //string RetrieveSecurityTokenForCacheRefreshes();

        /// <summary>
        /// Retrieves the security token.
        /// </summary>
        /// <returns>Token</returns>
        /// <remarks></remarks>
        Task<string> RetrieveSecurityTokenAsync();
    }
}
