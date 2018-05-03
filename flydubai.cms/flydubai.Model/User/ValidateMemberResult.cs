using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.User
{
    public class ValidateMemberResult
    {
        public string processCode { get; set; }
        public string processMessage { get; set; }
        public string processStatus { get; set; }
        public bool allowAccrual { get; set; }
        public int age { get; set; }
        public string memberID { get; set; }
        public string tier { get; set; }
    }
}