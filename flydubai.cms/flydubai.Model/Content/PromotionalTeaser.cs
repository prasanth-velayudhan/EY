using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Promotional Teaser
    /// </summary>
    public class PromotionalTeaser : EntityBase<PromotionalTeaser, PromotionalTeaserVersion>
    {
        [Key]
        public int PromotionalTeaserId { get; set; }

        public override int Id
        {
            get { return PromotionalTeaserId; }
            set { PromotionalTeaserId = value; }
        }
    }
}
