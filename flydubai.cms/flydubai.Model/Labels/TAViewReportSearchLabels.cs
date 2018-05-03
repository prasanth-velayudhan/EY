using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace flydubai.Model.Labels
{
   public class TAViewReportSearchLabels :BaseLabels 
    {
        [DefaultValue("{Distributor Name}")]
        public string SelectDates { get; set; }
        [DefaultValue("useremail@domain.com")]
        public string EmailID { get; set; }
        [DefaultValue("Agency Name:")]
        public string AgencyName { get; set; }
        [DefaultValue("dd/mm/yyyy")]
        public string ReportStartDate { get; set; }
        [DefaultValue("dd/mm/yyyy")]
        public string ReportEndDate { get; set; }
        [DefaultValue("Run Reports")]
        public string UpdateResults { get; set; }
        [DefaultValue("{Distributor Name}")]
        public string DefaultAgencyname { get; set; }
        [DefaultValue("useremail@domain.com")]
        public string DefaultEmail { get; set; }
        [DefaultValue("dd/mm/yyyy")]
        public string DefaultStartDate { get; set; }
        [DefaultValue("dd/mm/yyyy")]
        public string DefaultEndDate { get; set; }
    }
}

