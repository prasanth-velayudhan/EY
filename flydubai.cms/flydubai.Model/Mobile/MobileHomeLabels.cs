using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Home Labels
    /// </summary>
    public class MobileHomeLabels : BaseLabels
    {
        public string BookFlight { get; set; }
        public string FlightStatus { get; set; }
        public string Timetable { get; set; }
        public string ViewTicket { get; set; }
        public string ContactUs { get; set; }
        public string MyBookings { get; set; }

        public string FlydubaiFullSite { get; set; }
        /* WR8:WR-132:A-4740:Add Policies hyperlink to the mobile website Start */
        public string Policies { get; set; }
        /* WR8:WR-132:A-4740:Add Policies hyperlink to the mobile website End */
    }
}
