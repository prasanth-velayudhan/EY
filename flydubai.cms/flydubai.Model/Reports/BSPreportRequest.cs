using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Reports
{
    public class BSPreportRequest
    {
        public ReportParameter ReportParameter { get; set; }
        public TransactionInfos TransactionInfos { get; set; }
    }

    public class TransactionInfos
    {
        public string securityGUID { get; set; }
        public string IPAddress { get; set; }
        public string userid { get; set; }
    }

    public class ReportParameter
    {
        public string ReportID { get; set; }
        public string ReportName { get; set; }
        public string ReportParameters { get; set; }
        public string ReportOutPutFormat { get; set; }
        public string ReportCreatedByUser { get; set; }
        public string CreatedFromLoc { get; set; }
        public string DeliveryType { get; set; }
        public string DeliverTo { get; set; }
    }
}
