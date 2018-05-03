using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Customer
{
    public class AuthenticateRS
    {
        public string processCode { get; set; }
        public string processMessage { get; set; }
        public string processStatus { get; set; }
        public string securityToken { get; set; }
        public string memberID { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string middleName { get; set; }
        public string surname { get; set; }
        public string points { get; set; }
        public string tier { get; set; }
        public string dob { get; set; }
        public string nationality { get; set; }
        public string mobileIntCode { get; set; }
        public string mobileNumber { get; set; }
        public string status { get; set; }
    }
}
