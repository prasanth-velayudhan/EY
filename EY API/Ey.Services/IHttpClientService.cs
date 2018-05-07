using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Services
{
    public interface IHttpClientService
    {
        Task<T> PostDataAsync<T, U>(string path, string xRequestId, U value) where T : new();

        Task<T> PostDataAsync<T, U>(string path, U value, Dictionary<string, string> parameters) where T : new();

        Task<T> GetAsync<T>(string path, string xRequestId) where T : new();
    }
}
