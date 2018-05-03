using System;

namespace flydubai.Model
{
    [Serializable]
    public class UsableAmount
    {
        public Price Price { get; set; }
        public decimal UsableTotal { get; set; }
    }
}
