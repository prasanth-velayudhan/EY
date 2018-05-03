namespace flydubai.Model.Common
{
    using System;

    /// <summary>
    /// Surcharge
    /// </summary>
    [Serializable]
    public class Surcharge
    {
        public string Label { get; set; }

        public decimal Total { get; set; }

        public bool IsDiscount
        {
            get
            {
                return this.Total < 0;
            }
        }
    }
}