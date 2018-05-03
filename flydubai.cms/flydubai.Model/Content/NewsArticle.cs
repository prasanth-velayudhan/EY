using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// News Article
    /// </summary>
    public class NewsArticle : EntityBase<NewsArticle, NewsArticleVersion>
    {
        [Key]
        public int NewsArticleId { get; set; }

        public override int Id
        {
            get { return this.NewsArticleId; }
            set { this.NewsArticleId = value; }
        }
    }
}
