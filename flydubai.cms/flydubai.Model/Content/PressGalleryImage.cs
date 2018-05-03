using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Press Gallery Image
    /// </summary>
    public class PressGalleryImage : EntityBase<PressGalleryImage, PressGalleryImageVersion>
    {
        [Key]
        public int PressGalleryImageId { get; set; }

        public override int Id
        {
            get { return this.PressGalleryImageId; }
            set { this.PressGalleryImageId = value; }
        }
    }
}
