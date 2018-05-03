using flydubai.Model.Content;

namespace flydubai.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    /// <summary>
    /// Airport Localised
    /// </summary>
    [Serializable]
    public class AirportLocalised : ILocalisable
    {
        public int AirportLocalisedId { get; set; }
        
        public string AirportCode { get; set; }

        public virtual Airport Airport { get; set; }

        public string Language
        {
            get;
            set;
        }

        public CountryLocalised CountryLocalised
        {
            get
            {
                return Airport.Country != null ? Airport.Country.Localised.FirstOrDefault(x => x.Language == this.Language) : null;
            }
        }

        [MaxLength(256)]
        [Required]
        public string AirportName { get; set; }

        [MaxLength(256)]
        public string City { get; set; }

        [ForeignKey("DestinationGuide")]
        public int? DestinationGuideId { get; set; }

        [ForeignKey("DestinationGuideId")]
        public virtual DestinationGuide DestinationGuide { get; set; }

        //IBS - Metro Search
        [MaxLength(256)]
        public string MetroName { get; set; }
    }
}