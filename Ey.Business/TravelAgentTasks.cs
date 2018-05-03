using System.Collections.Generic;
using flydubai.DatabaseServices;
using flydubai.Model.Content;

namespace flydubai.Business
{
    /// <summary>
    /// Group of tasks related to travel agents
    /// </summary>
    /// <remarks></remarks>
    public class TravelAgentTasks : ITravelAgentTasks
    {
        private readonly FlydubaiContext context;
        private readonly ILanguageConfiguration languageConfiguration;

        private readonly int languageId;

        /// <summary>
        /// Initializes a new instance of the <see cref="TravelAgentTasks"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="languageConfig">The language config.</param>
        /// <remarks></remarks>
        public TravelAgentTasks(FlydubaiContext context, ILanguageConfiguration languageConfig)
        {
            this.context = context;
            this.languageConfiguration = languageConfig;
            this.languageId = this.languageConfiguration.CurrentLanguage.Id;
        }

        /// <summary>
        /// Gets all travel agents.
        /// </summary>
        /// <returns>List of travel agents</returns>
        /// <remarks></remarks>
        public IEnumerable<TravelAgentVersion> GetAllTravelAgents()
        {
            return this.context.Set<TravelAgentVersion>()
                               .Include(t => t.Parent)
                               .Where(t => t.Parent.LanguageId == this.languageId)
                               .ToList()
                               .Where(t => t.Status == EntityVersionStatus.Published);
        }

        /// <summary>
        /// Gets all travel agents for city.
        /// </summary>
        /// <param name="cityId">The city id.</param>
        /// <returns>List of travel agents</returns>
        /// <remarks></remarks>
        public IEnumerable<TravelAgentVersion> GetAllTravelAgentsForCity(int cityId)
        {
            return this.context.Set<TravelAgentVersion>()
                               .Include(t => t.Parent)
                               .Where(t => t.Parent.LanguageId == this.languageId 
                                      && t.CityId == cityId)
                               .ToList()
                               .Where(t => t.Status == EntityVersionStatus.Published);
        }

        /// <summary>
        /// Gets the travel agent countries.
        /// </summary>
        /// <returns>List of Id and name pairs</returns>
        /// <remarks></remarks>
        public IEnumerable<KeyValuePair<int, string>> GetTravelAgentCountries()
        {
            var countries = this.context.Set<TravelAgentVersion>()
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
