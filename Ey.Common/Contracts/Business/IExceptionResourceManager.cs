using System.Globalization;

namespace Ey.Common.Contracts.Business
{
    /// <summary>
    /// ExceptionResourceManager Interface
    /// </summary>
    public interface IExceptionResourceManager:IRefreshable
    {
        object GetObject(string name);
        string GetString(string name);
        string GetString(string name, CultureInfo culture);
        object GetObject(string name, CultureInfo culture);
    }
}