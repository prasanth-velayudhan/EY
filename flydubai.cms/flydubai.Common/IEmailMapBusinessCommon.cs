using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common
{
    public interface IEmailMapBusinessCommon
    {
        bool Send(string ServerName, string ServerDate, string StackTrace, string GUID, string PrevPage, string path);
    }
}
