using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Mpesa
{
    public class MpesaSetting
    {
        [Key]
        public long SettingId { get; set; }
        public int CountryID { get; set; }
        public string Currency { get; set; }
        public string FOP { get; set; }
        public string PaymentType { get; set; }
        public string AccountNo { get; set; }
        public bool IsActive { get; set; }
    }
}
