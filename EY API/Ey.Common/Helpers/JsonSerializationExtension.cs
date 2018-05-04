using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Ey.Common.Redis;

namespace Ey.Common.Helpers
{
  public static class JsonSerializationExtension
    {
        public static T DeserializeJson<T>(this string jsonString, IEnumerable<Type> knownTypes = null)
        {
            if (string.IsNullOrEmpty(jsonString))
                return default(T);
         
            return JsonConvert.DeserializeObject<T>(jsonString,
                                                    new JsonSerializerSettings
                                                    {
                                                        MissingMemberHandling = MissingMemberHandling.Ignore,
                                                        TypeNameHandling = TypeNameHandling.Auto,
                                                        Converters = new List<JsonConverter>(
                                                                new JsonConverter[]
                                                                {
                                                           new JsonKnownTypeConverter(knownTypes)
                                                                })

                                                    });
        }

        public static string SerializeJson(this object objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize, Formatting.Indented,
                                               new JsonSerializerSettings
                                               {
                                                   TypeNameHandling = TypeNameHandling.Auto,
                                                 
                                               
                                               });
        }
    }
}
