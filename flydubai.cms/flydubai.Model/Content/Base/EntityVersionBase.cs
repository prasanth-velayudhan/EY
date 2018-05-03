using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Entity Version Base
    /// </summary>
    /// <typeparam name="TParent">The type of the parent.</typeparam>
    /// <typeparam name="TVersion">The type of the version.</typeparam>
    public abstract class EntityVersionBase<TParent, TVersion> : IEntityVersionBase<TParent, TVersion>
        where TParent : class, IEntityBase<TParent, TVersion>, new()
        where TVersion : class, IEntityVersionBase<TParent, TVersion>, new()
    {
        /// <summary>
        /// The ID must be overridden to map to the unique ID property as EF4.1 cannot handle database generated IDs when they all have the same property name
        /// </summary>
        [NotMapped]
        public abstract int Id { get; set; }

        [ForeignKey("Parent")]
        public int ParentId { get; set; }

        public string UrlIdentifier { get; set; }

        public string CmsName { get; set; }

        public int Version { get; set; }

        public bool IsDraft { get; set; }

        [ForeignKey("CreatedBy")]
        public int? CreatedById { get; set; }

        [ForeignKey("CreatedById")]
        public Member CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        [ForeignKey("ApprovedBy")]
        public int? ApprovedById { get; set; }

        [ForeignKey("ApprovedById")]
        public Member ApprovedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ApprovedDate { get; set; }

        [ForeignKey("PublishedBy")]
        public int? PublishedById { get; set; }

        [ForeignKey("PublishedById")]
        public Member PublishedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PublishedDate { get; set; }

        [ForeignKey("UnpublishedBy")]
        public int? UnpublishedById { get; set; }

        [ForeignKey("UnpublishedById")]
        public Member UnpublishedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UnpublishedDate { get; set; }

        [ForeignKey("ParentId")]
        public virtual TParent Parent { get; set; }

        [NotMapped]
        public bool IsNewVersion { get; set; }

        // If this logic changes, remember to update ContentBusiness and ContentCmsBusiness.
        public EntityVersionStatus Status
        {
            get
            {
                if (this.UnpublishedDate.HasValue && this.IsDraft)
                {
                    return EntityVersionStatus.Unpublished;
                }
                
                if (this.IsDraft)
                {
                    return EntityVersionStatus.Draft;
                }

                if (this.PublishedDate.HasValue)
                {
                    return EntityVersionStatus.Published;
                }

                if (this.ApprovedDate.HasValue)
                {
                    return EntityVersionStatus.Approved;
                }

                return EntityVersionStatus.Submitted;
            }
        }
    }
}
