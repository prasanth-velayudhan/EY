using Ey.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Business
{
    public interface ISecurityTokenTask
    {
        SecurityData DecrySecurityData(string token);
        Task<SecurityData> GenerateAsync(string ipAddress, string referer);
        string EncryptSecurityData(SecurityData securityData);
        DateTime GetSessionBeginTime(SecurityData securityData);
        int GetRemainingSessionDuration(SecurityData securityData);
    }
}
