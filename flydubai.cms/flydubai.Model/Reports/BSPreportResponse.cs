using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Reports
{
    public class BSPreportResponse
    {
        public bool ReportStatus { get; set; }
        public int status { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public string devMessage { get; set; }
    }
}
