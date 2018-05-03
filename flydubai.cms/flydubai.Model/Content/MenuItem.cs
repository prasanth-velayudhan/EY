using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Menu Item
    /// </summary>
    public class MenuItem : EntityBase<MenuItem, MenuItemVersion>
    {
        [Key]
        public int MenuItemId { get; set; }

        public override int Id
        {
            get { return this.MenuItemId; }
            set { this.MenuItemId = value; }
        }
    }
}
