using System;
using System.Linq;
using System.Reflection;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Web Video Helper
    /// </summary>
    public static class WebVideoHelper
    {
        public static bool TryParse(string url, out WebVideoSource source)
        {
            if (!string.IsNullOrEmpty(url))
            {
                foreach (var webSource in
                    Assembly.GetAssembly(typeof(WebVideoSource)).GetTypes().Where(
                        x => x.IsClass && !x.IsAbstract && x.IsSubclassOf(typeof(WebVideoSource))))
                {
                    var webVideoSource = (WebVideoSource)Activator.CreateInstance(webSource);

                    if (webVideoSource.TryCreate(url))
                    {
                        source = webVideoSource;
                        return true;
                    }
                }
            }

            source = null;
            return false;
        }
    }
}
