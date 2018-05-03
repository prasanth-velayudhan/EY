namespace flydubai.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    /// <summary>
    /// Country
    /// </summary>
    [Serializable]
    public class Country
    {
        public int CountryId { get; set; }

        [MaxLength(2)]
        public string AlphaNumeric2 { get; set; }

        [MaxLength(3)]
        public string AlphaNumeric3 { get; set; }
        
        [MaxLength(3)]
        public string IsoNumeric { get; set; }

        public string TelephoneCode { get; set; }

        public string WebsiteLanguage { get; set; }

        public bool IsPassportAndNationalityMandatoryTA { get; set; }

        public bool IsPassportAndNationalityMandatoryConsumer { get; set; }

        public bool IsPassportAndNationalityMandatoryMobile { get; set; }

        //FR12 A-5583//
        public bool IsApisIsMandatoryTA { get; set; }

        public bool IsApisIsMandatoryConsumer { get; set; }

        //FR12 A-5583//
        
        //FR110 A-5484//
        public bool IsCabinTypeBusiness { get; set; }

        public bool IsCabinTypeEconomy { get; set; }

        public bool IsCabinTypeAll { get; set; }

        public bool IsCabinTypeBusinessTA { get; set; }

        public bool IsCabinTypeEconomyTA { get; set; }

        public bool IsCabinTypeAllTA { get; set; }
        //FR110 A-5484//

        public virtual ICollection<CountryLocalised> Localised { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        /// <summary>
        /// retrieve the localised country information, based on passed-in language
        /// </summary>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        public CountryLocalised GetLocalisedCountry(string languageCode)
        {
            return this.Localised.Where(l => l.Language == languageCode).FirstOrDefault();
        }

        /// <summary>
        /// Get localised country name or null if none available
        /// </summary>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        public string GetLocalisedCountryName(string languageCode)
        {
            var localisedCountry = this.GetLocalisedCountry(languageCode);
            return localisedCountry == null ? null : localisedCountry.Name;
        }


        /// <summary>
        /// Gets the localised country id.
        /// </summary>
        /// <param name="languageCode">The language code.</param>
        /// <returns></returns>
        public int? GetLocalisedCountryId(string languageCode)
        {
            var localisedCountry = this.GetLocalisedCountry(languageCode);
            return localisedCountry == null ? (int?) null : localisedCountry.CountryLocalisedId;
        }

        public bool IsInsuranceMandatoryTA { get; set; }

        public bool IsInsuranceMandatoryConsumer { get; set; }

        public bool IsInsuranceMandatoryMobile { get; set; }
    }
}
