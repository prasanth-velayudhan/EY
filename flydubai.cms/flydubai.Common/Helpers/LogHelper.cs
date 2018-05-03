using flydubai.Common.Contracts.Business;
using Serilog.Context;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace flydubai.Common.Helpers
{
    public class LogHelper
    {
        public static bool isLoggingEnabled
        {
            get
            {
                if (string.IsNullOrEmpty(EnableSerilog))
                {
                    EnableSerilog = ConfigurationSettings.AppSettings["enableSerilog"];
                }
                return (string.IsNullOrEmpty(EnableSerilog) || bool.Parse(EnableSerilog) == false) ? false : true;                
            }
        }
        static string EnableSerilog;
        
        private static List<string> keyList = new List<String>() { "RadixxSessionToken", "Channel", "PNR", "IsInModify", "NumDebitCreditCardFailedPayments" };
       
        public static void LogInformation(LogProperties properties, string message, params object[] prams)
        {
            LogUsingSerilog(false, properties, message, prams);
        }

        public static void LogException(LogProperties properties, string message, params object[] prams)
        {
            LogUsingSerilog(true, properties, message, prams);
        }

        private static void LogUsingSerilog(bool isError, LogProperties properties, string message, object[] prams)
        {
            if (!isLoggingEnabled)
                return;

            try
            {
                if (properties != null && properties.propertyList != null && properties.propertyList.Count > 0)
                {
                    var list = properties.propertyList.Concat(GetLogProperties().propertyList.Where(a => !properties.propertyList.Keys.Contains(a.Key)));
                    properties.propertyList = list.ToDictionary(a => a.Key, a => a.Value);
                }
                else
                {
                    properties = GetLogProperties();
                }

                using (var ppt = properties ?? new LogProperties())
                {
                    if (ppt != null && ppt.propertyList != null && ppt.propertyList.Any())
                        foreach (var item in ppt.propertyList.Distinct())
                        {
                            LogContext.PushProperty(item.Key, item.Value);
                        }

                    if (isError)
                    {
                        Serilog.Log.Error(message, prams);
                    }
                    else
                    {
                        Serilog.Log.Information(message, prams);
                    }
                }
            }
            catch
            {
            }
        }

        private static LogProperties GetLogProperties()
        {
            IUserSessionTasksCommon userSessionTasks = null;
            try
            {
                userSessionTasks = ObjectFactory.GetInstance<IUserSessionTasksCommon>();
            }
            catch { }

            return (userSessionTasks == null) ? new LogProperties() : new LogProperties() { propertyList = userSessionTasks.GetUserSessionValue(keyList) };
        }
    }

    public class LogProperties : IDisposable
    {
        public Dictionary<string, object> propertyList { get; set; }

        public void Dispose()
        {
            this.propertyList = null;
        }
    }
}
