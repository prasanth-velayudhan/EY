using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model
{
    /// <summary>
    /// Exception Message Area
    /// </summary>
    public class ExceptionMessageArea
    {
        [Key]
        public int ExceptionMessageAreaId { get; set; }

        public string Name { get; set; }
    }
}
