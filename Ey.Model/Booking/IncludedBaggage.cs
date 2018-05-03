using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model.Booking
{
    /// <summary>
    /// Included Baggage
    /// </summary>
    [Serializable]
    public class IncludedBaggage
    {
        public string Code { get; set; }

        public int Weight { get; set; }

        public string Type { get; set; }
    }


    [Serializable]
    public class ApplicableTaxDetail
    {
        public decimal Amt { get; set; }
        public string TaxCode { get; set; }
        public int TaxID { get; set; }
    }
}
