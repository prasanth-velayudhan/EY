using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Contingency Update
    /// </summary>
    public class ContingencyUpdate
    {
        [Key]
        public int ContingencyUpdateId { get; set; }

        public string UrlIdentifier { get; set; }

        public string CmsName { get; set; }

        [ForeignKey("Contingency")]
        public int ContingencyId { get; set; }

        [ForeignKey("ContingencyId")]
        public Contingency Contingency { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdateDate { get; set; }

        public string Time { get; set; }

        public string Title { get; set; }

        public string ShortSummary { get; set; }

        public string SummaryHtml { get; set; }

        public string BodyHtml { get; set; }

        public int? ThumbnailImage { get; set; }

        public int? Image { get; set; }

        public string VideoTitle { get; set; }

        public string VideoUrl { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public bool IsArchived { get; set; }
    }
}
