using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Promotional Teaser Version
    /// </summary>
    public class PromotionalTeaserVersion : EntityVersionBase<PromotionalTeaser, PromotionalTeaserVersion>
    {
        [Key]
        public int PromotionalTeaserVersionId { get; set; }

        public override int Id
        {
            get { return PromotionalTeaserVersionId; }
            set { PromotionalTeaserVersionId = value; }
        }

        public string Title { get; set; }

        public string DescriptionHtml { get; set; }

        public int? SmallImage { get; set; }

        public string SmallImagePath { get; set; }

        public int? MainImage { get; set; }

        public string MainImagePath { get; set; }

        public string BookNowUrl { get; set; }

        public bool? OpenInNewWindow { get; set; }

        public bool ShowOnProfile { get; set; }

        public bool ShowOnConfirmation { get; set; }

        public bool ImageOnly { get; set; }

        //START A-5469:WR3:FR001
        public bool ShowBannerOnBottom { get; set; }

        public string TABookNowUrl { get; set; }

        public string TAMainImagePath { get; set; }

        public int? TAMainImage { get; set; }
        //END A-5469:WR3:FR001
    }
}
