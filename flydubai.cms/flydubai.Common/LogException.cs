using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Common.Model;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common
{
    public class LogException
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IRepository repository;
        public LogException(IRepository repository)
        {
            this.repository = repository;
        }

        public static void LogError(Exception ex)
        {
            if (GetCMSLoggingKey())
                Log.Fatal(ex.Message, ex);
        }

        private static bool GetCMSLoggingKey()
        {
            return ObjectFactory.GetInstance<IAppSettingCache>().GetWebSettingValue("SendExceptionMail");
        }
    }
}
