using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Press Gallery Video
    /// </summary>
    public class PressGalleryVideo : EntityBase<PressGalleryVideo, PressGalleryVideoVersion>
    {
        [Key]
        public int PressGalleryVideoId { get; set; }

        public override int Id
        {
            get { return this.PressGalleryVideoId; }
            set { this.PressGalleryVideoId = value; }
        }
    }
}
