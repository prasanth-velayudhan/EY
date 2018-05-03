using flydubai.Common.Contracts.DatabaseServices;

namespace flydubai.DatabaseServices
{
    using System.Collections.Generic;
    using System.Linq;

    using flydubai.Model;

    /// <summary>
    /// Service to retrieve and save labels into the database
    /// </summary>
    /// <remarks></remarks>
    public class LabelsService : ILabelsService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <remarks></remarks>
        public LabelsService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>List of Labels</returns>
        /// <remarks></remarks>
        public IEnumerable<T> GetAll<T>() where T : BaseLabels
        {
            return this.repository.AsQueryable<T>().ToList();
        }

        /// <summary>
        /// Gets the specified language code.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="languageCode">The language code.</param>
        /// <returns>Labels</returns>
        /// <remarks></remarks>
        public T Get<T>(string languageCode) where T : BaseLabels
        {
            return this.repository.AsQueryable<T>().SingleOrDefault(x => x.Language == languageCode);
        }

        /// <summary>
        /// Saves the specified labels.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="labels">The labels.</param>
        /// <remarks></remarks>
        public void Save<T>(T labels) where T : BaseLabels
        {
            if (!this.repository.AsQueryable<T>().Any(x => x.Language == labels.Language))
            {
                this.repository.Add<T>(labels);
            }

            this.repository.SaveChanges();
        }
    }
}