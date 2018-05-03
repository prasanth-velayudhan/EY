namespace flydubai.Model.Content
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using flydubai.Model.Common;

    /// <summary>
    /// Payment Point Partner Type
    /// </summary>
    public class PaymentPointPartnerType
    {
        public PaymentPointPartnerType()
        {
            this.InUse = true;
        }

        [Key]
        public int PaymentPointPartnerTypeId { get; set; }

        [Required]
        public string Name { get; set; }

        // helper property to determine if any of the payment points are currently published.
        public bool InUse { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }

        [Required]
        [ForeignKey("Language")]
        public virtual int LanguageId { get; set; }

        public virtual ICollection<PaymentPointVersion> PaymentPoints { get; set; }
    }
}