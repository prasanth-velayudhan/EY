using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// News Article Tag
    /// </summary>
    public class NewsArticleTag
    {
        [Key]
        public int NewsArticleTagId { get; set; }

        public string Name { get; set; }
    }
}
