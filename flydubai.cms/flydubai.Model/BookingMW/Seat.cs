using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class Seat
    {
        public int PersonOrgID { get; set; }
        public int LogicalFlightID { get; set; }
        public int PhysicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string SeatSelected { get; set; }
        public string RowNumber { get; set; }
        public bool AlreadyAdded { get; set; }
        public DateTime DepartureDate_DT
        {
            get { return Convert.ToDateTime(DepartureDate); }
        }
    }
}
