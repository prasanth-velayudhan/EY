using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.ExternalPricing
{
    public class CompanionFareConfigs
    {
        [Key]
        public int CompanionFareID { get; set; }
        public string OriginAirportCode { get; set; }
        public string DestinationAirportCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string CompanionFareKey { get; set; }
        public bool IsActive { get; set; }
        public bool IsReturn { get; set; }
        public DateTime OutFromDate { get; set; }
        public DateTime OutToDate { get; set; }
        public DateTime InFromDate { get; set; }
        public DateTime InToDate { get; set; }
        public string Iata { get; set; }
        public string OfferType { get; set; }
    }
}
