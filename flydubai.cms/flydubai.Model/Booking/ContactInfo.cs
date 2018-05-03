using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Booking
{
    /// <summary>
    /// Contact Info
    /// </summary>
    [Serializable]
    public class ContactInfo
    {
        public int PersonOrgID { get; set; }

        //Added for Ancillary sales in GDS booking
        public int ContactID { get; set; }

        public string ContactField { get; set; }

        public Enums.ContactTypes ContactType { get; set; }

        public bool PreferredContactMethod { get; set; }

        public string AreaCode { get; set; }

        public string CountryCode { get; set; }

        public string PhoneNumber { get; set; }

        public bool ValidatedContact { get; set; }
    }
}
