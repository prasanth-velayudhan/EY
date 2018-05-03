using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    public class IpCountryMapping
    {
        [Key]
        public int Id { get; set; }

        public decimal FromIp { get; set; }

        public decimal ToIp { get; set; }

        public string CountryCode3 { get; set; }
    }
}
