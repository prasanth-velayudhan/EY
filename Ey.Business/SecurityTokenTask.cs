using Ey.Common;
using Ey.Common.Encryption;
using Ey.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Business
{
    public class SecurityTokenTask : ISecurityTokenTask
    {
        private readonly ISecurityService _securityService;
        private readonly string _headerKey;
        //private readonly IApplicationSettingsTasks _settingsTasks;
        //private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();

        public SecurityTokenTask(ISecurityService securityService)
        {
            _securityService = securityService;
            _headerKey = ConfigurationManager.AppSettings["SecureHeaderHashKey"];
        }

        public DateTime GetSessionBeginTime(SecurityData securityData)
        {
            var exptime = 45;
            int.TryParse(ConfigurationManager.AppSettings["SabreSessionExpiryMinutes"],
                out exptime);
            return securityData.ExpiryDateTime.AddMinutes(exptime * -1);
        }

        public int GetRemainingSessionDuration(SecurityData securityData)
        {
            var currentTime = DateTime.Now;
            var tokenStartTime = GetSessionBeginTime(securityData);
            return Convert.ToInt32(((Constants.SessionTimeoutDuration) * 60) - ((currentTime - tokenStartTime).TotalSeconds));
        }

        public async Task<SecurityData> GenerateAsync(string ipAddress, string referer)
        {
            var sabreToken = await _securityService.RetrieveSecurityTokenAsync();
            
            int exptime = 45;
            int.TryParse(ConfigurationManager.AppSettings["SabreSessionExpiryMinutes"],
                out exptime);
            return new SecurityData()
            {
                SabreToken = sabreToken,
                ClientIpAddress = ipAddress,
                Referrer = referer,
                ExpiryDateTime = DateTime.Now.AddMinutes(exptime)
            };
        }

        public SecurityData DecrySecurityData(string token)
        {
            var result = EncryptionHelper.Decrypt(token, _headerKey);
            var data = result.Split('_');
            return new SecurityData
            {
                ClientIpAddress = data[1],
                SabreToken = data[0],
                Referrer = data[2],
                ExpiryDateTime = DateTime.Parse(data[3])
            };

        }

        public string EncryptSecurityData(SecurityData securityData)
        {
            //return
            //    EncryptionHelper.Encrypt(
            //        $"{securityData.RadixxToken}_{securityData.ClientIpAddress}_{securityData.Referrer}_{securityData.ExpiryDateTime}", _headerKey);

            var clientIPAddress = "";
            var Referrer = "";

            if (securityData.ClientIpAddress != null && !string.IsNullOrEmpty(securityData.ClientIpAddress))
            {
                clientIPAddress = securityData.ClientIpAddress.Split(',')[0];
            }

            return
              EncryptionHelper.Encrypt(
                  $"{securityData.SabreToken}_{clientIPAddress}_{Referrer}_{securityData.ExpiryDateTime}", _headerKey);
        }
    }
}
