using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class DocumentInfo
    {
        public string DocType { get; set; }
        public string DocNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuingCountry { get; set; }
    }
}
