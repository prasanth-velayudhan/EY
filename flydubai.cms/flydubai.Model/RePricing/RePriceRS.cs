using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.RePricing
{
    public class RePriceRS
    {
        public Repriceresult repriceResult { get; set; }
        public class Repriceresult
        {
            public Origindestinations originDestinations { get; set; }
            public Segmentdetails segmentDetails { get; set; }
            public Oldorderrefunddetails oldOrderRefundDetails { get; set; }
            public Taxdetails taxDetails { get; set; }
            public Servicedetails serviceDetails { get; set; }
            public Exception[] Exceptions { get; set; }
        }
       
        public class Origindestinations
        {
            public Origindestination[] originDestination { get; set; }
        }

        public class Origindestination
        {
            public string odID { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public DateTime depDateTime { get; set; }
            public DateTime arrDateTime { get; set; }
            public double flightTime { get; set; }
            public int tripID { get; set; }
            public Farebrands fareBrands { get; set; }
            public Flightsegmentdetails flightSegmentDetails { get; set; }
            public Paxrefunddetails paxRefundDetails { get; set; }
        }

        public class Farebrands
        {
            public Farebrand[] fareBrand { get; set; }
        }

        public class Farebrand
        {
            public string fareBrandID { get; set; }
            public string solnID { get; set; }
            public string fareBrandName { get; set; }
            public string filterRemove { get; set; }
            public Fareinfos fareInfos { get; set; }
        }

        public class Fareinfos
        {
            public Fareinfo[] fareInfo { get; set; }
        }

        public class Fareinfo
        {
            public Pax[] pax { get; set; }
        }

        public class Pax
        {
            public int paxID { get; set; }
            public string PTC { get; set; }
            public string fareID { get; set; }
            public string paxCount { get; set; }
            public string fareClass { get; set; }
            public string FBC { get; set; }
            public string baseFare { get; set; }
            public string tax { get; set; }
            public string total { get; set; }
            public string cabin { get; set; }
            public string seatsAvailable { get; set; }
            public string infantSeatsAvailable { get; set; }
            public string specialMarketed { get; set; }
            public string promotionCatID { get; set; }
            public Applicabletaxdetails applicableTaxDetails { get; set; }
            public string changeCost { get; set; }
            public int?[] includedServiceRef { get; set; }
            public string status { get; set; }
            public Modifyflightdetail[] modifyFlightDetails { get; set; }
        }

        public class Applicabletaxdetails
        {
            public Applicabletaxdetail[] applicableTaxDetail { get; set; }
        }

        public class Applicabletaxdetail
        {
            public string taxID { get; set; }
            public string amt { get; set; }
            public string initiatingTaxID { get; set; }
        }

        public class Flightsegmentdetails
        {
            public Flightsegmentdetail[] flightSegmentDetail { get; set; }
        }

        public class Flightsegmentdetail
        {
            public string segmentID { get; set; }
            public DateTime depDateTime { get; set; }
        }

        public class Segmentdetails
        {
            public Segmentdetail[] segmentDetail { get; set; }
        }

        public class Segmentdetail
        {
            public string segmentID { get; set; }
            public DateTime depDateTime { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public string international { get; set; }
            public DateTime arrDateTime { get; set; }
            public double flightTime { get; set; }
            public string mrktCarrier { get; set; }
            public string mrktFlightNum { get; set; }
            public string operCarrier { get; set; }
            public string fromTerminal { get; set; }
            public string toTerminal { get; set; }
            public string aircraftType { get; set; }
        }

        public class Oldorderrefunddetails
        {
            public string resCurrency { get; set; }
            public DateTime bookDateTime { get; set; }
            public Origindestinations originDestinations { get; set; }
        }
        
        public class Paxrefunddetails
        {
            public Pax[] pax { get; set; }
        }

        public class Modifyflightdetail
        {
            public Charge[] charges { get; set; }
        }

        public class Charge
        {
            public float amt { get; set; }
            public string codeType { get; set; }
            public int chargeID { get; set; }
        }

        public class Taxdetails
        {
            public Taxdetail[] taxDetail { get; set; }
        }

        public class Taxdetail
        {
            public string taxID { get; set; }
            public string taxCode { get; set; }
            public string codeType { get; set; }
            public string taxDesc { get; set; }
        }

        public class Servicedetails
        {
            public Servicedetail[] serviceDetail { get; set; }
        }

        public class Servicedetail
        {
            public string ID { get; set; }
            public string code { get; set; }
            public string desc { get; set; }
        }
        public class Exception
        {
            public int ExceptionCode { get; set; }
            public string ExceptionDescription { get; set; }
            public object ExceptionSource { get; set; }
            public object ExceptionLevel { get; set; }
        }
    }
}
