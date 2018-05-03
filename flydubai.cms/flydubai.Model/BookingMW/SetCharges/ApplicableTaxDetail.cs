using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.SetCharges
{
    public class ApplicableTaxDetail
    {
        public decimal amt { get; set; }
        public string taxCode { get; set; }
        public int taxID { get; set; }
    }
}
