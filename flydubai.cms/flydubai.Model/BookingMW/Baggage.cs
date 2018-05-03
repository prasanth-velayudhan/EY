using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class Baggage
    {
        public int BagId { get; set; }
        public string Key { get; set; }
        public int BagNumber { get; set; }
        public decimal BagWeight { get; set; }
        public string BagCode { get; set; }
        public int BagChecked { get; set; }
        public int Pet { get; set; }
        public int BagActive { get; set; }
        public int BagTagPrinted { get; set; }
        public int RecordNumber { get; set; }
    }
}
