namespace flydubai.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Special Offer Version Airport
    /// </summary>
    [Serializable]
    public class SpecialOfferVersionAirport
    {
        [Key]
        [MaxLength(4)]
        [Required]
        public int SpecialOfferVersionId { get; set; }

        public string AirportCode { get; set; }
    }
}
