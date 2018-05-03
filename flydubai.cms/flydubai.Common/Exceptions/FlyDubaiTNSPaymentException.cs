using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common.Exceptions
{
    public class FlyDubaiTNSPaymentException : ApplicationException
    {
        public FlyDubaiTNSPaymentException(string code, flydubai.Common.Enums.TnsExceptionGroup group = flydubai.Common.Enums.TnsExceptionGroup.Generic)
            : base(code)
        {
            Group = group;
            tnsResponseCode = code;
        }

        public flydubai.Common.Enums.TnsExceptionGroup Group;

        public string tnsResponseCode;
    }
}
