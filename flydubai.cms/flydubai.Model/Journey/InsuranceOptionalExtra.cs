namespace flydubai.Model.Journey
{
    using System;

    /// <summary>
    /// Insurance Optional Extra
    /// </summary>
    [Serializable]
    public class InsuranceOptionalExtra : JourneyOptionalExtra
    {
        public string CurrencyCode { get; set; }
        public string TransactionId { get; set; }
    }
}