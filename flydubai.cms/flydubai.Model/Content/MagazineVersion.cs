using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Magazine Version
    /// </summary>
    public class MagazineVersion : EntityVersionBase<Magazine, MagazineVersion>
    {
        public int MagazineVersionId { get; set; }

        public override int Id
        {
            get { return this.MagazineVersionId; }
            set { this.MagazineVersionId = value; }
        }

        public string FileName { get; set; }

        public string DownloadFileName { get; set; }

        public int? Image { get; set; }

        public string ExternalUrl { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime MagazineDate { get; set; }
    }
}
