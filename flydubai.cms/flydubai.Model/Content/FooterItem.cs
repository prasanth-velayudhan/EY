using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Footer Item
    /// </summary>
    public class FooterItem : EntityBase<FooterItem, FooterItemVersion>
    {
        [Key]
        public int FooterItemId { get; set; }

        public override int Id
        {
            get { return this.FooterItemId; }
            set { this.FooterItemId = value; }
        }
    }
}
