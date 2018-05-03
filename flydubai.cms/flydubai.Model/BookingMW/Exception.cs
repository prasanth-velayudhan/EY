using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
     [Serializable]
    public class Exception
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public int ExceptionLevel { get; set; }
    }
}
