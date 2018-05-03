using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Careers Footer Version
    /// </summary>
    public class CareersFooterVersion : EntityVersionBase<CareersFooter, CareersFooterVersion>
    {
        [Key]
        public int CareersFooterVersionId { get; set; }

        public override int Id
        {
            get { return this.CareersFooterVersionId; }
            set { this.CareersFooterVersionId = value; }
        }

        public string LinkText { get; set; }

        public string Url { get; set; }

        public int SortOrder { get; set; }

        public bool? OpenInNewWindow { get; set; }
    }
}
