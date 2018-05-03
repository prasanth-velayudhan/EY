using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Special Offer Version
    /// </summary>
    public class SpecialOfferVersion : EntityVersionBase<SpecialOffer, SpecialOfferVersion>
    {
        [Key]
        public int SpecialOfferVersionId { get; set; }

        public override int Id
        {
            get { return this.SpecialOfferVersionId; }
            set { this.SpecialOfferVersionId = value; }
        }

        public bool? AvailableToNonRegisteredUsers { get; set; }

        public bool? AvailableToRegisteredUsers { get; set; }

        public bool? AvailableToStaff { get; set; }

        public bool? AvailableToTravelAgents { get; set; }

        public string SpecialOfferType { get; set; }

        public string Title { get; set; }

        public int? Image { get; set; }

        public string ImagePath { get; set; }

        public string PromotionalCode { get; set; }

        public bool DisplayPromotionalCode { get; set; }

        public string AdditionalInformation { get; set; }

        public string Currency { get; set; }

        public decimal Price { get; set; }

        public bool IsPercentage { get; set; }

        public string PriceSuffix { get; set; }

        public string TravellingFrom { get; set; }

        public string TravellingTo { get; set; }

        public string ThirdPartyUrl { get; set; }

        public string BookButtonUrl { get; set; }

        public string TermsAndConditionsHtml { get; set; }

        public bool IsHotel { get; set; }

        public bool IsCarHire { get; set; }

        public bool IsGlobal { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ExpiryDate { get; set; }

        public virtual ICollection<Airport> Airports { get; set; }
    }
}
