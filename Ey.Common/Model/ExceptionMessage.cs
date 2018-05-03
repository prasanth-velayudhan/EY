using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ey.Common.Contracts.Model;

namespace Ey.Common.Model
{
    /// <summary>
    /// Exception Message
    /// </summary>
    public class ExceptionMessage : IExceptionMessage
    {
        public int ExceptionMessageId { get; set; }

        public string Language { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Area { get; set; }
    }
}
