using flydubai.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    [Serializable]
    public class Person
    {
        public int PersonOrgID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string DOB_DT { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public int NationalityLaguageID { get; set; }
        public string RelationType { get; set; }
        public int WBCID { get; set; }
        public int PTCID { get; set; }
        public string PTC { get; set; }
        public int TravelsWithPersonOrgID { get; set; }
        public string RedressNumber { get; set; }
        public string KnownTravelerNumber { get; set; }
        public bool MarketingOptIn { get; set; }
        public bool UseInventory { get; set; }
        public Address Address { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }
        public string Passport { get; set; }
        public string Nationality { get; set; }
        public long ProfileId { get; set; }
        public bool IsPrimaryPassenger { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }
        public List<DocumentInfo> DocumentInfos { get; set; }
        public string FrequentFlyerNumber { get; set; }
        public string Suffix { get; set; }
        public string TierName { get; set; }
        public string passportIssueCountry { get; set; }
        public DateTime passportExpiryDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Key { get; set; }
        public string Postal { get; set; }
        public string State { get; set; }        
    }
}
