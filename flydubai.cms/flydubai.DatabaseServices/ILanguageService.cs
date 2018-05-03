namespace flydubai.Business
{
    using System.Collections.Generic;

    using flydubai.Model.Common;

    /// <summary>
    /// Interface for LanguageService
    /// </summary>
    /// <remarks></remarks>
    public interface ILanguageService
    {
        IEnumerable<Language> GetAll();

        Language Get(int id);
    }
}
