using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Ey.Common.Model
{
    public class WebsiteSetting
    {
        [Key]
        public int WebsiteSettingId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
