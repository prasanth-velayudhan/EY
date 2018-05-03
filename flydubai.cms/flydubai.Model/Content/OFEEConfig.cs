using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    /// <summary>
    /// OFEE configurations
    /// </summary>
    [Serializable]
    public class OFEEConfig
    {
        [Key]
        public int Id { get; set; }

        public string ParentIATA { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public string Currency { get; set; }

        public decimal OFEE { get; set; }

        public bool Active { get; set; }

        public DateTime DateModified { get; set; }
    }
}
