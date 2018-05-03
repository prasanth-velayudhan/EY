using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Common
{
    public class MonthLocalised
    {
        [Key]
        public int MonthLocalisedId { get; set; }
        public int Month { get; set; }
        public string MonthCode { get; set; }
        public string Language { get; set; }
    }
}
