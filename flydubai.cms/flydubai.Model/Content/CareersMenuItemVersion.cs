using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Careers Menu Item Version
    /// </summary>
    public class CareersMenuItemVersion : EntityVersionBase<CareersMenuItem, CareersMenuItemVersion>
    {
        [Key]
        public int CareersMenuItemVersionId { get; set; }

        public override int Id
        {
            get { return this.CareersMenuItemVersionId; }
            set { this.CareersMenuItemVersionId = value; }
        }

        public string WebsiteSection { get; set; }

        public string LinkText { get; set; }

        public string Url { get; set; }

        public int SortOrder { get; set; }
    }
}
