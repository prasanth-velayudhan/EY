using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Customer
{
    public class LogoutRS
    {
        public LogoutResponse logoutResponse { get; set; }
    }

    public class LogoutResponse
    {
        public string processCode { get; set; }
        public string processMessage { get; set; }
        public string processStatus { get; set; }
    }
}
