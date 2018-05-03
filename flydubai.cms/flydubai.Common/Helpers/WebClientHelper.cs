using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;


namespace flydubai.Common.Helpers
{
    public class WebClientHelper : WebClient
    {
        public int timeOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest request = base.GetWebRequest(uri);
            request.Timeout = timeOut;
            return request;
        }

        public string GetData(string url, int timeOut, string authorization = null)
        {
            WebClientHelper webClient = new WebClientHelper();
            webClient.Headers.Add("Content-Type", "application/json");
            if (!string.IsNullOrEmpty(authorization))
            {
                webClient.Headers.Add("Authorization", authorization);
            }
            webClient.Encoding = System.Text.Encoding.UTF8;
            webClient.timeOut = timeOut;
            byte[] responseBytes = webClient.DownloadData(new Uri(url));
            return Encoding.UTF8.GetString(responseBytes);
        }

        public string PostData(string url, int timeOut, Dictionary<string, string> headers)
        {
            WebClientHelper webClient = new WebClientHelper();
            webClient.Headers.Add("Content-Type", "application/json");
            if (headers != null && headers.Count > 0)
            {
                foreach (var header in headers)
                {
                    webClient.Headers.Add(header.Key, header.Value);
                }
            }
            webClient.Encoding = System.Text.Encoding.UTF8;
            webClient.timeOut = timeOut;
            return UploadData(webClient, url, null);
        }

        public string PostData(string url, string request, int timeOut, Dictionary<string, string> headers)
        {
            WebClientHelper webClient = new WebClientHelper();
            webClient.Headers.Add("Content-Type", "application/json");
            if (headers != null && headers.Count > 0)
            {
                foreach (var header in headers)
                {
                    webClient.Headers.Add(header.Key, header.Value);
                }
            }
            webClient.Encoding = System.Text.Encoding.UTF8;
            webClient.timeOut = timeOut;
            return UploadData(webClient, url, request);
        }

        private string UploadData(WebClientHelper webClient, string url, string request)
        {
            byte[] responseBytes = webClient.UploadData(new Uri(url), "POST", request != null ? Encoding.ASCII.GetBytes(request) : new byte[] { });
            return Encoding.UTF8.GetString(responseBytes);
        }
    }
}
