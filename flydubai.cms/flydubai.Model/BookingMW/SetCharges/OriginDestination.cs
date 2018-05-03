using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.SetCharges
{
    public class OriginDestination
    {
        public string ID { get; set; }
        public int odID { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string flightNum { get; set; }
        public DateTime depDate { get; set; }
        public bool isPromoApplied { get; set; }
        public List<FareBrand> fareBrand { get; set; }
        public List<SegmentDetail> segmentDetails { get; set; }
    }   
}
