using System.Globalization;

namespace flydubai.Common.Contracts.Business
{
    /// <summary>
    /// ExceptionResourceManager Interface
    /// </summary>
    public interface IExceptionResourceManager
    {
        object GetObject(string name);
        string GetString(string name);
        string GetString(string name, CultureInfo culture);
        object GetObject(string name, CultureInfo culture);
    }
}