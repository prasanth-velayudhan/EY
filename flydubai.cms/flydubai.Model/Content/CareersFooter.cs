using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Careers Footer
    /// </summary>
    public class CareersFooter : EntityBase<CareersFooter, CareersFooterVersion>
    {
        [Key]
        public int CareersFooterId { get; set; }

        public override int Id
        {
            get { return this.CareersFooterId; }
            set { this.CareersFooterId = value; }
        }
    }
}
