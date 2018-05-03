using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Site Search Labels
    /// </summary>
    public class SiteSearchLabels : LabelsBase
    {
        [Key]
        public int SiteSearchLabelsId { get; set; }

        [DefaultValue("Search results for")]
        public string SearchResultsLabel { get; set; }

        [DefaultValue("All results")]
        public string AllResultsLabel { get; set; }

        [DefaultValue("results found")]
        public string ResultsFoundLabel { get; set; }

        [DefaultValue("Page {0} of {1}")]
        [DisplayName("Paging text (use {0} for current page, {1} for total pages) (e.g. Page {0} of {1})")]
        public string SearchPaging { get; set; }

        [DefaultValue("Previous")]
        public string PagingPrevious { get; set; }

        [DefaultValue("Next")]
        public string PagingNext { get; set; }

        [DefaultValue("Sorry, there are no results for your search")]
        public string NoResultsTitle { get; set; }

        [DefaultValue("Sorry, there are no results in this category")]
        public string NoResultsCategoryTitle { get; set; }

        [DefaultValue("'{0}' in {1}")]
        [DisplayName("No results within category text (use {0} for search term, {1} for category) (e.g. {0} in {1})")]
        public string NoResultsCategory { get; set; }

        [DefaultValue("Please search again")]
        public string SearchAgain { get; set; }

        [DefaultValue("Suggestions")]
        public string Suggestions { get; set; }

        [DefaultValue("Categories")]
        public string CategoriesTitle { get; set; }

        [DefaultValue("All results")]
        public string CategoriesAllResults { get; set; }
    }
}
