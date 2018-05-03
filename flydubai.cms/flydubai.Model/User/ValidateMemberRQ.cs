using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.User
{
    public class ValidateMemberRQ
    {
        public IList<vmemberProfile> vmemberProfile { get; set; }
    }

    public class vmemberProfile
    {
        public string memberID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int personID { get; set; }
    }
}
