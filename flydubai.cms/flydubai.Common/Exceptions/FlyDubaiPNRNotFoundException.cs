
namespace flydubai.Common.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// FlyDubai PNR Not Found Exception
    /// </summary>
    public class FlyDubaiPNRNotFoundException : RadixxException
    {
        public FlyDubaiPNRNotFoundException()
            : base(typeof(FlyDubaiPNRNotFoundException), null)
        {
        }

    }
}
