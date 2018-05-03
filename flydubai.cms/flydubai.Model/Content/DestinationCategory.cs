using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Destination Category
    /// </summary>
    public class DestinationCategory
    {
        [Key]
        public int DestinationCategoryId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<DestinationGuideVersion> DestinationGuideVersions { get; set; }
    }
}
