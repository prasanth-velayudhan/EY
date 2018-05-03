using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common
{
    public interface IAppSettingCache
    {
        bool GetWebSettingValue(string key);
        string GetWebSetting(string key);
    }
}
