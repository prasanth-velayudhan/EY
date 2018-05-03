using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.RePricing
{
    public class Repricer
    {
        public enum action
        {
            addPax,
            removePax,
            changeDate,
            upgradeToBusiness,
            cancelPnr,
            cancelSegment,
            modifyPnrAddPax,
            modifyPnrChangeDate,
        }
        public enum subAction
        {
            none,
            oneSearch
        }
        public enum fareFilterMethod
        {
            none,
            lowestFarePerFareType
        }
        public class Request
        {
            public string pointOfSale { get; set; }
            public string carrier { get; set; }
            public string PNR { get; set; }
            public string channel { get; set; }
            public string subChannel { get; set; }
            public string currency { get; set; }
            public string promoCode { get; set; }
            public string securityGUID { get; set; }
            public string requestorIATA { get; set; }
            public Modifydetails modifyDetails { get; set; }
        }
        public class ModifyPnrRequest
        {
            public Request modifyRequest { get; set; }
        }
        public class Modifydetails
        {
            public Origindestinations originDestinations { get; set; }
            public string action { get; set; }
            public string subAction { get; set; }
            public string fareFilterMethod { get; set; }
            public string taxBreakdown { get; set; }
            public Paxinfo[] paxDetails { get; set; }
        }

        public class Origindestinations
        {
            //public string cabin { get; set; }
            public Origindestination[] originDestination { get; set; }
            public string fareBrand { get; set; }
            public string fareClass { get; set; }
        }

        public class Origindestination
        {
            public string oldODRef { get; set; }
            public int[] oldPaxRef { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public Nullable<DateTime> depDateTime { get; set; }
            public Nullable<DateTime> departureDate { get; set; }
            public depDateRange depDateRange { get; set; }
            public Paxdetail[] paxDetails { get; set; }
            public Oldpaxref[] oldPaxRefs { get; set; }
            public string fareBrandName { get; set; }
            public bool orgMetro { get; set; }
            public bool destMetro { get; set; }
            public string cabin { get; set; }
        }

        public class Paxdetail
        {
            public string paxID { get; set; }
            public string PTC { get; set; }
            public string fareClass { get; set; }
            public string tier { get; set; }
            public string cabin { get; set; }
            public string fbc { get; set; }
            public string fareBrand { get; set; }
        }

        public class depDateRange
        {
            public DateTime start { get; set; }
            public DateTime end { get; set; }
        }

        public class Paxinfo
        {
            public string paxID { get; set; }
            public string fName { get; set; }
            public string mName { get; set; }
            public string lName { get; set; }
            public string title { get; set; }
            public int age { get; set; }
            public Nullable<DateTime> DOB { get; set; }
            public string gender { get; set; }
            public string PTC { get; set; }
            public string associatedPax { get; set; }
            public string ffNum { get; set; }
            public string passport { get; set; }
            public string nationality { get; set; }
            public string comment { get; set; }
            public Address address { get; set; }
            public Contact[] contacts { get; set; }
        }

        public class Address
        {
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string postal { get; set; }
            public string country { get; set; }
        }

        public class Contact
        {
            public int ID { get; set; }
            public int paxID { get; set; }
            public string contact { get; set; }
            public string type { get; set; }
            public int extension { get; set; }
            public int countryCode { get; set; }
            public int areaCode { get; set; }
            public bool preferred { get; set; }
        }
        public class Oldpaxref
        {
            public int[] oldPaxRef { get; set; }
            public int fareID { get; set; }
        }
    }
}
