namespace flydubai.DatabaseServices
{
    using System.Collections.Generic;

    using flydubai.Model;

    /// <summary>
    /// Interface for LabelsService
    /// </summary>
    /// <remarks></remarks>
    public interface ILabelsService
    {
        IEnumerable<T> GetAll<T>() where T : BaseLabels;

        T Get<T>(string languageCode) where T : BaseLabels;

        void Save<T>(T labels) where T : BaseLabels;
    }
}
