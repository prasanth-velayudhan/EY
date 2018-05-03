using System.Collections.Generic;
using flydubai.DatabaseServices;
using flydubai.Model.Content;

namespace flydubai.Business
{
    /// <summary>
    /// Group of tasks related to Payment points
    /// </summary>
    /// <remarks></remarks>
    public class PaymentPointTasks : IPaymentPointTasks
    {
        private readonly FlydubaiContext context;
        private readonly ILanguageConfiguration languageConfiguration;

        private readonly int languageId;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentPointTasks"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="langConfig">The lang config.</param>
        /// <remarks></remarks>
        public PaymentPointTasks(FlydubaiContext context, ILanguageConfiguration langConfig)
        {
            this.context = context;
            this.languageConfiguration = langConfig;

            this.languageId = this.languageConfiguration.CurrentLanguage.Id;
        }

        /// <summary>
        /// Gets all payment point versions.
        /// </summary>
        /// <returns>List of payment points</returns>
        /// <remarks></remarks>
        public IEnumerable<PaymentPointVersion> GetAllPaymentPointVersions()
        {
            return this.context.Set<PaymentPointVersion>()
                               .Include(x => x.Parent)
                               .Where(x => x.Parent.LanguageId == this.languageId)
                               .ToList()
                               .Where(x => x.Status == EntityVersionStatus.Published);
        }

        /// <summary>
        /// Gets the payment points for city.
        /// </summary>
        /// <param name="cityId">The city id.</param>
        /// <returns>List of payments points</returns>
        /// <remarks></remarks>
        public IEnumerable<PaymentPointVersion> GetPaymentPointsForCity(int cityId)
        {
            return this.context.Set<PaymentPointVersion>()
                               .Include(x => x.Parent)
                               .Where(x => x.Parent.LanguageId == this.languageId
                                      && x.CityId == cityId)
                               .ToList()
                               .Where(x => x.Status == EntityVersionStatus.Published);

        }

        /// <summary>
        /// Gets the payment point countries.
        /// </summary>
        /// <returns>List of Id and Country name pairs</returns>
        /// <remarks></remarks>
        public IEnumerable<KeyValuePair<int, string>> GetPaymentPointCountries()
        {
            var countries = this.context.Set<PaymentPointVersion>()
                .Where(x => x.City.Country.Localised.Any(y => y.Language == this.languageConfiguration.CurrentLanguage.Code))
                .Select(x => x.City.Country)
                .GroupBy(x => x.CountryId)
                .Select(x => x.FirstOrDefault())
                .Where(x => x != null)
                .Select(x => new { Id = x.CountryId, Localised = x.Localised.FirstOrDefault(y => y.Language == this.languageConfiguration.CurrentLanguage.Code) })
                .ToList();

            var localised = countries
                .Where(x => x.Localised != null)
                .Select(x => new KeyValuePair<int, string>(x.Id, x.Localised.Name))
                .Distinct()
                .OrderBy(x => x.Value)
                .ToList();

            return localised;
        }
    }
}
