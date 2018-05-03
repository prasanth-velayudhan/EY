using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.SetCharges
{
    public class FareBrand
    {
        public int fareBrandID { get; set; }
        public string fareBrandName { get; set; }
        public List<FareInfo> fareInfos { get; set; }
    }
}
