using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    using flydubai.Model.Common;

    /// <summary>
    /// Interface of entityBase
    /// </summary>
    /// <typeparam name="TParent">The type of the parent.</typeparam>
    /// <typeparam name="TVersion">The type of the version.</typeparam>
    public interface IEntityBase<TParent, TVersion>
        where TParent : class, IEntityBase<TParent, TVersion>, new()
        where TVersion : class, IEntityVersionBase<TParent, TVersion>, new()
    {
        int Id { get; set; }

        int LanguageId { get; set; }

        Language Language { get; set; }

        ICollection<TVersion> Versions { get; set; }

        TVersion PublishedVersion { get; }

        TVersion LatestVersion { get; }

        TVersion Version(int version);

        TVersion Latest(Func<TVersion, bool> filter);
    }
}
