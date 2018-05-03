using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Careers Menu Item
    /// </summary>
    public class CareersMenuItem : EntityBase<CareersMenuItem, CareersMenuItemVersion>
    {
        [Key]
        public int CareersMenuItemId { get; set; }

        public override int Id
        {
            get { return this.CareersMenuItemId; }
            set { this.CareersMenuItemId = value; }
        }
    }
}
