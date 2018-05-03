using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.PassengerDetails
{
    [Serializable]
    public class GSTInfo
    {
        public GSTInfo()
        {
            this.seriesNum = "299";
        }

        public string PNR { get; set; }
        public string seriesNum { get; set; }
        public int paxID { get; set; }
        public string GSTType { get; set; }
        public string GSTNum { get; set; }
        public string companyName { get; set; }
        public string issueDate { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string pinCode { get; set; }
        public string email { get; set; }
        public string companyNum { get; set; }
        public int altContactNum { get; set; }
        public int mobileNum { get; set; }
        public string userId { get; set; }



    }

    [Serializable]
    public class PassengerGSTDetails
    {
        public string securityGuid { get; set; }
        public List<GSTInfo> passengerGSTDetails { get; set; }
    }
}
