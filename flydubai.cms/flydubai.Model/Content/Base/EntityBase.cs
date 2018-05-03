using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    using flydubai.Model.Common;

    /// <summary>
    /// Entity Base
    /// </summary>
    /// <typeparam name="TParent">The type of the parent.</typeparam>
    /// <typeparam name="TVersion">The type of the version.</typeparam>
    public abstract class EntityBase<TParent, TVersion> : IEntityBase<TParent, TVersion>
        where TParent : class, IEntityBase<TParent, TVersion>, new()
        where TVersion : class, IEntityVersionBase<TParent, TVersion>, new()
    {
        /// <summary>
        /// The ID must be overridden to map to the unique ID property as EF4.1 cannot handle database generated IDs when they all have the same property name
        /// </summary>
        [NotMapped]
        public abstract int Id { get; set; }

        [ForeignKey("Language")]
        public int LanguageId { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }

        public virtual ICollection<TVersion> Versions { get; set; }

        public TVersion PublishedVersion
        {
            get
            {
                if (this.Versions == null)
                {
                    return null;
                }

                return this.Versions
                    .Where(x => x.Status == EntityVersionStatus.Published || x.Status == EntityVersionStatus.Unpublished)
                    .OrderByDescending(x => x.Version)
                    .Take(1)
                    .FirstOrDefault(x => x.Status == EntityVersionStatus.Published);
            }
        }

        public TVersion LatestVersion
        {
            get
            {
                if (this.Versions == null)
                {
                    return null;
                }

                return this.Versions.OrderByDescending(x => x.Version).FirstOrDefault();
            }
        }

        /// <summary>
        /// Versions the specified version.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns>TVersion</returns>
        public TVersion Version(int version)
        {
            if (this.Versions == null)
            {
                return null;
            }

            return this.Versions.SingleOrDefault(x => x.Version == version);
        }

        /// <summary>
        /// Latests the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>TVersion</returns>
        public TVersion Latest(Func<TVersion, bool> filter)
        {
            if (this.Versions == null)
            {
                return null;
            }

            return this.Versions.OrderByDescending(x => x.Version).FirstOrDefault(filter);
        }
    }
}
