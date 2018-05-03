using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Menu Item Version
    /// </summary>
    public class MenuItemVersion : EntityVersionBase<MenuItem, MenuItemVersion>
    {
        public int MenuItemVersionId { get; set; }

        public override int Id
        {
            get { return this.MenuItemVersionId; }
            set { this.MenuItemVersionId = value; }
        }

        public string WebsiteSection { get; set; }

        public string LinkText { get; set; }

        public string Url { get; set; }

        public int SortOrder { get; set; }
    }
}
