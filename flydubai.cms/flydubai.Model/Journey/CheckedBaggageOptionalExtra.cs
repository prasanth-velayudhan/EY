namespace flydubai.Model.Journey
{
    using System;

    /// <summary>
    /// Checked Baggage Optional Extra
    /// </summary>
    [Serializable]
    public class CheckedBaggageOptionalExtra : JourneyOptionalExtra
    {
        public int Weight { get; set; }
    }
}