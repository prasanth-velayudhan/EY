using System.Collections.Generic;
using flydubai.DatabaseServices;
using flydubai.Model.Content;

namespace flydubai.Business
{
    /// <summary>
    /// Group of tasks related to promotional teasers
    /// </summary>
    /// <remarks></remarks>
    public class PromotionalTeaserBusiness : IPromotionalTeaserBusiness
    {
        private readonly FlydubaiContext context;
        private readonly ILanguageConfiguration languageConfiguration;

        public PromotionalTeaserBusiness(FlydubaiContext context, ILanguageConfiguration languageConfiguration)
        {
            this.context = context;
            this.languageConfiguration = languageConfiguration;
        }

        /// <summary>
        /// Gets the published items for profile.
        /// </summary>
        /// <returns>List of promotional teaser</returns>
        /// <remarks></remarks>
        public IEnumerable<PromotionalTeaserVersion> GetPublishedItemsForProfile()
        {
            var languageId = this.languageConfiguration.CurrentLanguage.Id;

            var results = this.context.Set<PromotionalTeaserVersion>()
                .Include(x => x.Parent)
                .Where(x => x.Parent.LanguageId == languageId && x.ShowOnProfile)
                .ToList()  // Doesn't work without this. LINQ to Entities bug?
                .GroupBy(x => x.ParentId)
                .Select(x => x
                    .OrderByDescending(y => y.Version)
                    .FirstOrDefault(y => y.Status == EntityVersionStatus.Published))
                .Where(x => x != null)
                .ToList();

            return results;
        }

        /// <summary>
        /// Gets the published items for confirmation.
        /// </summary>
        /// <returns>List of promotional teasers</returns>
        /// <remarks></remarks>
        public IEnumerable<PromotionalTeaserVersion> GetPublishedItemsForConfirmation()
        {
            var languageId = this.languageConfiguration.CurrentLanguage.Id;

            var results = this.context.Set<PromotionalTeaserVersion>()
                .Include(x => x.Parent)
                .Where(x => x.Parent.LanguageId == languageId && x.ShowOnConfirmation)
                .ToList()  // Doesn't work without this. LINQ to Entities bug?
                .GroupBy(x => x.ParentId)
                .Select(x => x
                    .OrderByDescending(y => y.Version)
                    .FirstOrDefault(y => y.Status == EntityVersionStatus.Published))
                .Where(x => x != null)
                .ToList();

            return results;
        }
    }
}
