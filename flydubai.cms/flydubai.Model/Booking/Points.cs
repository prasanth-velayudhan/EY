using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Booking
{
    public class Points
    {
        public string FFNumber { get; set; }
        public string CurrencyCode { get; set; }
        public decimal OriginalAmount { get; set; }
        public long RefundPoints { get; set; } 
    }
}
