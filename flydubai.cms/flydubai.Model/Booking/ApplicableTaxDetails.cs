using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Booking
{
    [Serializable]
    public class ApplicableTaxDetails
    {
        public decimal Amt { get; set; }
        public string TaxCode { get; set; }
        public int TaxID { get; set; }
    }
}
