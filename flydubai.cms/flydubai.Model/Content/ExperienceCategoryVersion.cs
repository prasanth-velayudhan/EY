using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Experience Category Version
    /// </summary>
    public class ExperienceCategoryVersion : EntityVersionBase<ExperienceCategory, ExperienceCategoryVersion>
    {
        [Key]
        public int ExperienceCategoryVersionId { get; set; }

        public override int Id
        {
            get { return this.ExperienceCategoryVersionId; }
            set { this.ExperienceCategoryVersionId = value; }
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string UrlText { get; set; }

        public virtual ICollection<Media> Images { get; set; }
    }
}
