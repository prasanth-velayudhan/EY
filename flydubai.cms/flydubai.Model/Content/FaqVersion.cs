using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Faq Version
    /// </summary>
    public class FaqVersion : EntityVersionBase<Faq, FaqVersion>
    {
        [Key]
        public int FaqVersionId { get; set; }

        public override int Id
        {
            get { return FaqVersionId; }
            set { FaqVersionId = value; }
        }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }
    }
}
