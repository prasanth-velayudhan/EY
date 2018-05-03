using System;
using System.Collections.Generic;

using flydubai.Common;

namespace flydubai.Model
{
    /// <summary>
    /// Price
    /// </summary>
    [Serializable]
    public class Price
    {
        public Price()
        {
            
        }

        public Price(decimal total, string currency)
        {
            this.Currency = currency;
            this.Total = total;
        }

        public string Currency { get; set; }

        public decimal Total { get; set; }
    }
}
