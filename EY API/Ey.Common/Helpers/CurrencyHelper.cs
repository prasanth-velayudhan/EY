using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ey.Common.Helpers
{
    /// <summary>
    /// Currency Helper
    /// </summary>
    public static class CurrencyHelper
    {
        /// <summary>
        /// Is 3 decimal currency.
        /// </summary>
        /// <param name="currency">The currency.</param>
        /// <returns>boolean</returns>
        public static bool Is3DecimalCurrency(string currency)
        {
            switch (currency)
            {
                case "JOD":
                case "BHD":
                case "KWD":
                case "OMR":
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <param name="currency">The currency.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public static string ToString(string currency, decimal amount)
        {
            if (Is3DecimalCurrency(currency))
            {
                return Math.Round(amount, 3).ToString("N3", Thread.CurrentThread.CurrentCulture);
            }

            return Math.Round(amount, 2).ToString("N2", Thread.CurrentThread.CurrentCulture);            
        }

        public static string ToStringInvariant(string currency, decimal amount)
        {
            if (Is3DecimalCurrency(currency))
            {
                return Math.Round(amount, 3).ToString("N3", System.Globalization.CultureInfo.InvariantCulture);
            }

            return Math.Round(amount, 2).ToString("N2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
