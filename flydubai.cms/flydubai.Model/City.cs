using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model
{
    /// <summary>
    /// City
    /// </summary>
    public class City
    {
        public City()
        {
            this.Localised = new List<CityLocalised>();
        }

        [Key]
        public int CityId { get; set; }

        [Required]
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        [Required]
        [ForeignKey("Country")]
        public virtual int CountryId { get; set; }

        public virtual ICollection<CityLocalised> Localised { get; set; }

        public string CMSEnglishCityName { get; set; }
        //WR3:FR-010:A-4627 - start
        public bool IsActive { get; set; }
        //WR3:FR-010:A-4627 - end

        /// <summary>
        /// Gets the localised city.
        /// </summary>
        /// <param name="languageCode">The language code.</param>
        /// <returns></returns>
        public CityLocalised GetLocalisedCity(string languageCode)
        {
            return this.Localised.Where(l => l.Language == languageCode).FirstOrDefault();
        }

        /// <summary>
        /// Gets the name of the localised city.
        /// </summary>
        /// <param name="languageCode">The language code.</param>
        /// <returns></returns>
        public string GetLocalisedCityName(string languageCode)
        {
            var localisedCity = this.GetLocalisedCity(languageCode);
            return localisedCity == null ? null : localisedCity.Name;
        }

    }
}
