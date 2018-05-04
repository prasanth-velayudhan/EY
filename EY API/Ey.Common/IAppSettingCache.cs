using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ey.Common
{
    public interface IAppSettingCache
    {
        bool GetWebSettingValue(string key);
    }
}
