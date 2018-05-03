using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Media Category
    /// </summary>
    public class MediaCategory
    {
        public int MediaCategoryId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Media> Media { get; set; }
    }
}
