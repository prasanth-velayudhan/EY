using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Press Gallery Labels
    /// </summary>
    public class PressGalleryLabels : LabelsBase
    {
        [Key]
        public int PressGalleryLabelsId { get; set; }

        [DefaultValue("Images")]
        public string ImagesTitle { get; set; }

        [DefaultValue("Videos")]
        public string VideosTitle { get; set; }
        
        [DefaultValue("Sort")]
        public string Sort { get; set; }
        
        [DefaultValue("Sort by")]
        public string SortBy { get; set; }
        
        [DefaultValue("All")]
        public string AllCategories { get; set; }

        [DefaultValue("Page {0} of {1}")]
        [DisplayName("Paging text (use {0} for current page, {1} for total pages) (e.g. Page {0} of {1})")]
        public string PagingText { get; set; }

        [DefaultValue("Next")]
        public string PaginationNext { get; set; }

        [DefaultValue("Previous")]
        public string PaginationPrevious { get; set; }

        [DefaultValue("Download Options")]
        public string DownloadOptions { get; set; }

        [DefaultValue("Download")]
        public string DownloadLink { get; set; }

        [DefaultValue("Small")]
        public string SmallImage { get; set; }

        [DefaultValue("Medium")]
        public string MediumImage { get; set; }

        [DefaultValue("Large")]
        public string LargeImage { get; set; }

        [DefaultValue("Low")]
        public string LowVideo { get; set; }

        [DefaultValue("Medium")]
        public string MediumVideo { get; set; }

        [DefaultValue("High")]
        public string HighVideo { get; set; }

        [DefaultValue("Please enter your email address")]
        public string EmailPrompt { get; set; }

        [DefaultValue("Submit")]
        public string SubmitEmail { get; set; }

        [DefaultValue("Image and video gallery")]
        public string SidebarTitle { get; set; }

        [DefaultValue("Search")]
        public string SidebarSearchButton { get; set; }

        [DefaultValue("Category")]
        public string LightboxCategoryLabel { get; set; }

        [DefaultValue("Heading")]
        public string LightboxHeadingLabel { get; set; }
    }
}
