using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Customer
{
    public class UserInfo
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public bool RememberUser { get; set; }
        public bool IsAuthenticated { get; set; }
        public string SecurityToken { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public long Points { get; set; }
        public bool IsRedemptionAllowed { get; set; }
        public string TierName { get; set; }
    }
}
