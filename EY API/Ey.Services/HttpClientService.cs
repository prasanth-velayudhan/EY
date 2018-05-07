using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Services
{
    public class HttpClientService : IHttpClientService
    {
        public async Task<T> PostDataAsync<T, U>(string path, string xRequestId, U value) where T : new()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-Request-ID", xRequestId);
                client.Timeout = TimeSpan.FromMilliseconds(Convert.ToInt32("120000"));
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync<U>(new Uri(path), value);

                    response.EnsureSuccessStatusCode();

                    return await response.Content.ReadAsAsync<T>();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public async Task<T> PostDataAsync<T, U>(string path, U value, Dictionary<string, string> parameters) where T : new()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (parameters != null && parameters.Count > 0)
                {
                    foreach (var arg in parameters)
                    {
                        client.DefaultRequestHeaders.Add(arg.Key, arg.Value);
                    }
                }
                client.Timeout = TimeSpan.FromMilliseconds(Convert.ToInt32("120000"));

                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync<U>(new Uri(path), value);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsAsync<T>();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task<T> GetAsync<T>(string path, string xRequestId) where T : new()
        {
            using (var client = new HttpClient())
            {
                // client.BaseAddress = uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-Request-ID", xRequestId);
                //client.Timeout = TimeSpan.FromMilliseconds(Convert.ToInt32(ConfigurationManager.AppSettings["1200000"]));
                HttpResponseMessage response = await client.GetAsync(new Uri(path));
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<T>();
            }
        }

    }
}
