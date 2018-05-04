using System.Collections.Generic;
using flydubai.DatabaseServices;
using flydubai.Model.Content;

namespace flydubai.Business
{
    /// <summary>
    /// Group of tasks related to special offers
    /// </summary>
    /// <remarks></remarks>
    public class SpecialOfferTasks : ISpecialOfferTasks
    {
        private readonly FlydubaiContext context;
        private readonly ILanguageConfiguration languageConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialOfferTasks"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="languageConfiguration">The language configuration.</param>
        /// <remarks></remarks>
        public SpecialOfferTasks(FlydubaiContext context, ILanguageConfiguration languageConfiguration)
        {
            this.context = context;
            this.languageConfiguration = languageConfiguration;
        }

        /// <summary>
        /// Gets the published offers for registered users.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public IEnumerable<SpecialOfferVersion> GetPublishedOffersForRegisteredUsers()
        {
            var languageId = this.languageConfiguration.CurrentLanguage.Id;

            var results = this.context.Set<SpecialOfferVersion>()
                .Include(x => x.Parent);

            return results
                .Where(x => x.Parent.LanguageId == languageId)
                .Where(x => x.AvailableToRegisteredUsers.HasValue && x.AvailableToRegisteredUsers.Value)
                .ToList()  // Doesn't work without this. LINQ to Entities bug?
                .GroupBy(x => x.ParentId)
                .Select(x => x
                    .OrderByDescending(y => y.Version)
                    .FirstOrDefault(y => y.Status == EntityVersionStatus.Published))
                .Where(x => x != null)
                .ToList();
        }
    }
}
