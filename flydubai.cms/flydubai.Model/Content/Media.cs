using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Media
    /// </summary>
    public class Media
    {
        [Key]
        public int MediaId { get; set; }

        [ForeignKey("MediaCategory")]
        public int? MediaCategoryId { get; set; }

        [ForeignKey("MediaCategoryId")]
        public virtual MediaCategory MediaCategory { get; set; }

        public string Name { get; set; }

        public string FileName { get; set; }

        public string DownloadFileName { get; set; }

        public int FileSize { get; set; }

        public bool IsImage { get; set; }

        public int? ImageWidth { get; set; }

        public int? ImageHeight { get; set; }

        public bool IsDeleted { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        public int? LastModifiedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastModifiedDate { get; set; }

        public int? DeletedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DeletedDate { get; set; }
    }
}
