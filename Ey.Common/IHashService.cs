using System.Threading.Tasks;

namespace Ey.Common
{
    interface IHashService
    {
        string GenerateHash(object obj);

        bool ValidateHash(object obj, string hashString);

        Task<string> GenerateHashAsync(object obj);

        Task<bool> ValidateHashAsync(object obj, string hashString);
    }
}
