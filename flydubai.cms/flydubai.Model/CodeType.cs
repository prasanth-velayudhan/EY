namespace flydubai.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;

    /// <summary>
    /// Code Type
    /// </summary>
    [Serializable]
    public class CodeType
    {
        [Key]
        [Required]
        [StringLength(4)]
        [DisplayName("Meal Code. (Maximum length should be three and should be in English)")]
        public string CodeTypeId { get; set; }

        public virtual CodeTypeCategory CodeTypeCategory { get; set; }

        public virtual ICollection<CodeTypeLocalised> Localised { get; set; }

        public bool GdsEnabled { get; set; }

        [Required]
        [DisplayName("Meal Master Code")]
        public string MasterCode { get; set; }

        public int? BaggagePieces { get; set; }

        public string BaggageClass { get; set; }

    }
}
