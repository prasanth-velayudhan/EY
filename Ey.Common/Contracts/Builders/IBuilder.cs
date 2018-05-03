
namespace Ey.Common.Contracts.Builders
{
    /// <summary>
    /// Generic Builder Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBuilder<T>
    {
        T Build();
    }
}
