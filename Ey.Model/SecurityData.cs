using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model
{
    public class SecurityData
    {
        public string ClientIpAddress { get; set; }
        public string SabreToken { get; set; }
        public string Referrer { get; set; }
        public string AppID { get; set; }
        public DateTime ExpiryDateTime { get; set; }
    }

}
