namespace flydubai.Business
{
    using System.Collections.Generic;
    using System.Linq;

    using flydubai.DatabaseServices;
    using flydubai.Model.Common;

    /// <summary>
    /// Service to retrieve and save languages into the database
    /// </summary>
    /// <remarks></remarks>
    public class LanguageService : ILanguageService
    {
        private readonly FlydubaiContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageService"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <remarks></remarks>
        public LanguageService(FlydubaiContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Gets all languages.
        /// </summary>
        /// <returns>List of languages</returns>
        /// <remarks></remarks>
        public IEnumerable<Language> GetAll()
        {
            return this.context.Set<Language>().ToList();
        }

        /// <summary>
        /// Gets the specified language id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The language</returns>
        /// <remarks></remarks>
        public Language Get(int id)
        {
            return this.context.Set<Language>().Find(id);
        }

        /// <summary>
        /// Saves the specified language.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <remarks></remarks>
        public void Save(Language language)
        {
            if (this.context.Set<Language>().Find(language.Id) == null)
            {
                this.context.Set<Language>().Add(language);
            }

            this.context.SaveChanges();
        }
    }
}