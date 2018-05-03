using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Interface of EntityVersionBase
    /// </summary>
    /// <typeparam name="TParent">The type of the parent.</typeparam>
    /// <typeparam name="TVersion">The type of the version.</typeparam>
    public interface IEntityVersionBase<TParent, TVersion>
        where TParent : class, IEntityBase<TParent, TVersion>, new()
        where TVersion : class, IEntityVersionBase<TParent, TVersion>, new()
    {
        int Id { get; set; }

        int ParentId { get; set; }

        string UrlIdentifier { get; set; }

        string CmsName { get; set; }

        int Version { get; set; }

        bool IsDraft { get; set; }

        int? CreatedById { get; set; }

        DateTime? CreatedDate { get; set; }

        int? ApprovedById { get; set; }

        DateTime? ApprovedDate { get; set; }

        int? PublishedById { get; set; }

        DateTime? PublishedDate { get; set; }

        int? UnpublishedById { get; set; }

        DateTime? UnpublishedDate { get; set; }

        TParent Parent { get; set; }

        bool IsNewVersion { get; set; }

        EntityVersionStatus Status { get; }
    }
}
