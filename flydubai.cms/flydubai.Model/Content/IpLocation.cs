using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// IpLocation
    /// </summary>
    public class IpLocation
    {
        public long IpFrom { get; set; }

        public long IpTo { get; set; }

        public string CountryCode { get; set; }
    }
}
