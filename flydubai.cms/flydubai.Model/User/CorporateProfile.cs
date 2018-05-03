using System;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.User
{
    [Serializable]
    public class CorporateProfileRS
    {
        public string UserId { get; set; }
        public string Corporate { get; set; }
        public string IATA { get; set; }
    }

    [Serializable]
    public class CorporateProfileRQ
    {
        public string Token { get; set; }
    }
}
