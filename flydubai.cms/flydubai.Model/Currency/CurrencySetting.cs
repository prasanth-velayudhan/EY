using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Currency
{
    public class CurrencySetting
    {
        [Key]
        public int CurrencyGroupID { get; set; }
        public string GroupName { get; set; }
        public string Currencies { get; set; }
        public decimal ThresholdPrice { get; set; }

    }
}
