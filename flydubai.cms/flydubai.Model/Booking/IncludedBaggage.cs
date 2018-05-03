using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Booking
{
    /// <summary>
    /// Included Baggage
    /// </summary>
    [Serializable]
    public class IncludedBaggage
    {
        public string Code { get; set; }

        public int Weight { get; set; }
    }
}
