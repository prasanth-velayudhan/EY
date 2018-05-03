using System;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Payment Point Version
    /// </summary>
    public class PaymentPointVersion : EntityVersionBase<PaymentPoint, PaymentPointVersion>
    {
        [Key]
        public int PaymentPointVersionId { get; set; }

        public override int Id
        {
            get { return this.PaymentPointVersionId; }
            set { this.PaymentPointVersionId = value; }
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public string FullAddress { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }
        
        [ForeignKey("City")]
        public virtual int? CityId { get; set; }

        [ForeignKey("PaymentPointPartnerTypeId")]
        public virtual PaymentPointPartnerType PaymentPointPartnerType { get; set; }

        [Required]
        [ForeignKey("PaymentPointPartnerType")]
        public virtual int PaymentPointPartnerTypeId { get; set; }
    }
}