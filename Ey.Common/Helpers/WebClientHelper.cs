using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Ey.Common.Helpers
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


    }
}
