using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.User
{
    public class ValidateMemberRS
    {
        public MemberProfiles memberProfiles { get; set; }
    }

    public class MemberProfile
    {
        public string memberID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public object tier { get; set; }
        public bool isValid { get; set; }
        public string age { get; set; }
        public string birthDate { get; set; }
        public Restrictions restrictions { get; set; }
    }
    public class Restrictions
    {
        public bool allowAccrual { get; set; }
        public bool allowRedemption { get; set; }
        public bool allowLogin { get; set; }
    }
    public class MemberProfiles
    {
        public string actionType { get; set; }
        public string processCode { get; set; }
        public string processMessage { get; set; }
        public int size { get; set; }
        public string processStatus { get; set; }
        public List<MemberProfile> memberProfile { get; set; }
    }
}