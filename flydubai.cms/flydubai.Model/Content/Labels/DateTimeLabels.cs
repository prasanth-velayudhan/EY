using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// DateTime Labels
    /// </summary>
    [DisplayName("Date & time labels")]
    public class DateTimeLabels : LabelsBase
    {
        [Key]
        public int DateTimeLabelsId { get; set; }

        [DefaultValue("Yesterday")]
        [DisplayName("Day: Yesterday")]
        public string Yesterday { get; set; }

        [DefaultValue("Today")]
        [DisplayName("Day: Today")]
        public string Today { get; set; }

        [DefaultValue("Tomorrow")]
        [DisplayName("Day: Tomorrow")]
        public string Tomorrow { get; set; }

        [DefaultValue("January")]
        [DisplayName("Month 01 - January")]
        public string January { get; set; }

        [DefaultValue("February")]
        [DisplayName("Month 02 - February")]
        public string February { get; set; }

        [DefaultValue("March")]
        [DisplayName("Month 03 - March")]
        public string March { get; set; }

        [DefaultValue("April")]
        [DisplayName("Month 04 - April")]
        public string April { get; set; }

        [DefaultValue("May")]
        [DisplayName("Month 05 - May")]
        public string May { get; set; }

        [DefaultValue("June")]
        [DisplayName("Month 06 - June")]
        public string June { get; set; }

        [DefaultValue("July")]
        [DisplayName("Month 07 - July")]
        public string July { get; set; }

        [DefaultValue("August")]
        [DisplayName("Month 08 - August")]
        public string August { get; set; }

        [DefaultValue("September")]
        [DisplayName("Month 09 - September")]
        public string September { get; set; }

        [DefaultValue("October")]
        [DisplayName("Month 10 - October")]
        public string October { get; set; }

        [DefaultValue("November")]
        [DisplayName("Month 11 - November")]
        public string November { get; set; }

        [DefaultValue("December")]
        [DisplayName("Month 12 - December")]
        public string December { get; set; }
    }
}
