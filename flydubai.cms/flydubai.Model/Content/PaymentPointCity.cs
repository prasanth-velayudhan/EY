namespace flydubai.Model.Content
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using flydubai.Model.Common;

    //public class PaymentPointCity
    //{
    //    public PaymentPointCity()
    //    {
    //        this.InUse = true;
    //    }

    //    [Key]
    //    public int PaymentPointCityId { get; set; }

    //    [Required]
    //    public string Name { get; set; }

    //    [Required]
    //    [ForeignKey("CountryId")]
    //    public virtual Country Country { get; set; }

    //    [Required]
    //    [ForeignKey("Country")]
    //    public virtual int CountryId { get; set; }

    //    // helper property to determine if any of the payment points are currently published.
    //    public bool InUse { get; set; }

    //    [ForeignKey("LanguageId")]
    //    public virtual Language Language { get; set; }

    //    [Required]
    //    [ForeignKey("Language")]
    //    public virtual int LanguageId { get; set; }

    //    public virtual ICollection<PaymentPointVersion> PaymentPoints { get; set; }
    //}
}