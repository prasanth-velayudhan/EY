using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.User
{
    public class GetPointsRS
    {
        public string xRate { get; set; }
        public string currencyCode { get; set; }
        public List<Conversion> conversions { get; set; }
    }

    public class Conversion
    {
        public string currency { get; set; }
        public string points { get; set; }
    }
}
