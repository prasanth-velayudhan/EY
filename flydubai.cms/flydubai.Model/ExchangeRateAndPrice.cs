using System;


namespace flydubai.Model
{
    [Serializable]
    public class ExchangeRateAndPrice
    {
        public Price Price { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
