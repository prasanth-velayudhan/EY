using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Press Gallery Image Version
    /// </summary>
    public class PressGalleryImageVersion : EntityVersionBase<PressGalleryImage, PressGalleryImageVersion>
    {
        [Key]
        public int PressGalleryImageVersionId { get; set; }

        public override int Id
        {
            get { return this.PressGalleryImageVersionId; }
            set { this.PressGalleryImageVersionId = value; }
        }

        public string Name { get; set; }

        public string Category { get; set; }

        public int? Thumbnail { get; set; }

        public int? Preview { get; set; }

        public string SmallFileName { get; set; }

        public string SmallDownloadFileName { get; set; }

        public string SmallResolution { get; set; }

        public string SmallFileSize { get; set; }

        public string MediumFileName { get; set; }

        public string MediumDownloadFileName { get; set; }

        public string MediumResolution { get; set; }

        public string MediumFileSize { get; set; }

        public string LargeFileName { get; set; }

        public string LargeDownloadFileName { get; set; }

        public string LargeResolution { get; set; }

        public string LargeFileSize { get; set; }
    }
}
