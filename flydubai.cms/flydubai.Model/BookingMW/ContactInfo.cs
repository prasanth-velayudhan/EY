using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    [Serializable]
    public class ContactInfo
    {
        public int ContactID { get; set; }
        public string Key { get; set; }
        public int PersonOrgID { get; set; }
        public string ContactField { get; set; }
        public int ContactType { get; set; }
        public string Extension { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Display { get; set; }
        public bool PreferredContactMethod { get; set; }
        public bool ValidatedContact { get; set; }
    }
}
