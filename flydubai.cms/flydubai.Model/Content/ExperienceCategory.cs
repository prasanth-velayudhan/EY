using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Experience Category
    /// </summary>
    public class ExperienceCategory : EntityBase<ExperienceCategory, ExperienceCategoryVersion>
    {
        [Key]
        public int ExperienceCategoryId { get; set; }

        public override int Id
        {
            get { return this.ExperienceCategoryId; }
            set { this.ExperienceCategoryId = value; }
        }
    }
}
