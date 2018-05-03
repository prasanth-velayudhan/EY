using flydubai.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace flydubai.Model.BookingMW
{
    public class PnrStatusResponse
    {
        public Enums.PNRValidStatus PNRValidStatus { get; set; }
        public string rLOCs { get; set; }
    }
}