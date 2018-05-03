using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// News Article Version
    /// </summary>
    public class NewsArticleVersion : EntityVersionBase<NewsArticle, NewsArticleVersion>
    {
        [Key]
        public int NewsArticleVersionId { get; set; }

        public override int Id
        {
            get { return this.NewsArticleVersionId; }
            set { this.NewsArticleVersionId = value; }
        }

        [Column(TypeName = "datetime2")]
        public DateTime NewsArticleDate { get; set; }

        public string Title { get; set; }

        public string SummaryHtml { get; set; }

        public string BodyHtml { get; set; }

        public int? ThumbnailImage { get; set; }

        public int? Image { get; set; }

        public string ImageCaption { get; set; }

        public string VideoTitle { get; set; }

        public string VideoUrl { get; set; }

        public virtual ICollection<NewsArticleTag> Tags { get; set; }
    }
}
