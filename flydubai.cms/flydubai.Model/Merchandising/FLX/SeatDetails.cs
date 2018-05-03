using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Merchandising.FLX
{
    public class SeatDetails
    {
        public string RowNumber { get; set; }
        public string SeatConfig { get; set; }
        public bool IsWingSeat { get; set; }
        public bool IsExitSeat { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsPreBooked { get; set; }
        public Enums.SeatSSRCode SeatSSRCode { get; set; }
        public int SeatAmount { get; set; }

    }
}
