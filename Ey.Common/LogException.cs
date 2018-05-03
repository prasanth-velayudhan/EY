using Ey.Common.Contracts.DatabaseServices;
using Ey.Common.Model;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ey.Common.Logging;

namespace Ey.Common
{
    public class LogException
    {
       private static readonly ILog logger = LogProvider.For<LogException>();
        private readonly IRepository repository;
        public LogException(IRepository repository)
        {
            this.repository = repository;
        }

        public static void LogError(Exception ex)
        {
            if (GetCMSLoggingKey())
                logger.FatalException(ex.Message,ex);
        }

        private static bool GetCMSLoggingKey()
        {

            return StructureMapObjectFactory.Container.GetInstance<IAppSettingCache>().GetWebSettingValue("SendExceptionMail");
        }
    }
}
