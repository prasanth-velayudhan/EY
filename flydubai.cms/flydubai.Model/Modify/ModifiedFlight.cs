using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using flydubai.Model.Booking;

namespace flydubai.Model.Modify
{
    /// <summary>
    /// Modified Flight
    /// </summary>
    [Serializable]
    public class ModifiedFlight
    {
        public LogicalFlight OldLogicalFlight { get; set; }

        public LogicalFlight NewLogicalFlight { get; set; }
    }
}
