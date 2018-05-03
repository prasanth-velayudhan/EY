using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// News Article Labels
    /// </summary>
    [DisplayName("News article labels")]
    public class NewsArticleLabels : LabelsBase
    {
        [Key]
        public int NewsArticleLabelsId { get; set; }

        [DefaultValue("News")]
        [DisplayName("Main article title")]
        public string ArticleTitle { get; set; }

        [DefaultValue("News articles")]
        [DisplayName("Large module title")]
        public string LargeModuleTitle { get; set; }

        [DefaultValue("News")]
        [DisplayName("Small module title")]
        public string SmallModuleTitle { get; set; }

        [DefaultValue("See all news")]
        [DisplayName("Small module see all news link")]
        public string SmallModuleSeeAllNews { get; set; }

        [DefaultValue("Back to list")]
        [DisplayName("Back to list link")]
        public string BackToList { get; set; }

        [DefaultValue("See all news")]
        public string LargeModuleSeeAllLink { get; set; }

        [DefaultValue("Read more")]
        [DisplayName("Large module read more link")]
        public string LargeModuleReadMore { get; set; }

        [DefaultValue("More")]
        [DisplayName("Small module read more link")]
        public string SmallModuleReadMore { get; set; }

        [DefaultValue("More like this")]
        [DisplayName("More like this link")]
        public string MoreLikeThis { get; set; }

        [DefaultValue("Page {0} of {1}")]
        [DisplayName("Paging text (use {0} for current page, {1} for total pages) (e.g. Page {0} of {1})")]
        public string PageNumberOfTotal { get; set; }

        [DefaultValue("Next")]
        public string PaginationNext { get; set; }

        [DefaultValue("Previous")]
        public string PaginationPrevious { get; set; }

        [DefaultValue("No news articles")]
        [DisplayName("No news articles text")]
        public string NoNewsText { get; set; }

        [DefaultValue("News archive")]
        [DisplayName("News archive module title")]
        public string NewsArchiveTitle { get; set; }

        [DefaultValue("Select a month")]
        [DisplayName("News archive - select a month")]
        public string SelectMonth { get; set; }

        [DefaultValue("Select a year")]
        [DisplayName("News archive - select a year")]
        public string SelectYear { get; set; }

        [DefaultValue("Search")]
        [DisplayName("News archive - search button")]
        public string NewsArchiveSearch { get; set; }

        [DefaultValue("Other news articles")]
        public string ListModuleTitle { get; set; }

        [DefaultValue("Related articles")]
        public string RelatedArticlesPageTitle { get; set; }

        [DefaultValue("Other news articles")]
        public string RelatedArticlesModuleTitle { get; set; }

        [DefaultValue("News and updates - flydubai")]
        public string RssFeedTitle { get; set; }

        public string RssFeedDescription { get; set; }

        [DefaultValue("(Click the above image to see the video)")]
        public string ClickImageToOpenVideoText { get; set; }
    }
}
