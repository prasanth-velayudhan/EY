using flydubai.Model.BookingMW.SummaryPnr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.ProcessFOP
{
    public class ProcessFOPRS
    {
        public SummaryPnrRS ViewPNR { get; set; }
        public ProcessPaymentResponse ProcessPaymentResponse { get; set; }
    }
}
