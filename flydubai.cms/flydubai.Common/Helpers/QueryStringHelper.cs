namespace flydubai.Common.Helpers
{
    using System.Collections.Specialized;

    public static class QueryStringHelper
    {
        /// <summary>
        /// Converts a querystring (e.g PAXNAME=PARDO&PNR=123ABC) to a NameValueCollection
        /// </summary>
        /// <param name="querystring">Contains pairs of name value in quesrystring format (e.g PAXNAME=PARDO&PNR=123ABC)</param>
        /// <returns>QueryString values</returns>
        public static NameValueCollection ExtractValues(string querystring)
        {
            var result = new NameValueCollection();

            foreach (var pair in querystring.Split('&'))
            {
                var parts = pair.Split('=');

                result.Add(parts[0], parts[1]);
            }

            return result;
        }
    }
}
