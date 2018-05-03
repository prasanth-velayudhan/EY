using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Emergency
    /// </summary>
    public class Emergency
    {
        [Key]
        public int EmergencyId { get; set; }

        public string UrlIdentifier { get; set; }

        public string CmsName { get; set; }

        public int LanguageId { get; set; }

        public string IconCssClass { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Date { get; set; }

        public bool DisplayDate { get; set; }

        public string Time { get; set; }

        public string Title { get; set; }

        public string StatementHtml { get; set; }

        public bool DisplayMoreInformation { get; set; }

        public virtual ICollection<EmergencyUpdate> Updates { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public bool IsArchived { get; set; }
    }
}
