using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Destination Guide Version
    /// </summary>
    public class DestinationGuideVersion : EntityVersionBase<DestinationGuide, DestinationGuideVersion>
    {
        [Key]
        public int DestinationGuideVersionId { get; set; }

        public override int Id
        {
            get { return this.DestinationGuideVersionId; }
            set { this.DestinationGuideVersionId = value; }
        }

        public string Name { get; set; }

        public string Headline { get; set; }

        public string BodyHtml { get; set; }

        public int? MainImage { get; set; }

        public virtual ICollection<DestinationCategory> DestinationCategories { get; set; }

        public string PageTitle { get; set; }

        public string Keywords { get; set; }

        public string Description { get; set; }

        public bool ShowMainImage { get; set; }
    }
}
