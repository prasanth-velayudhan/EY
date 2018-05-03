namespace flydubai.Model.Booking
{
    using System;

    /// <summary>
    /// HandBaggage
    /// </summary>
    [Serializable]
    public class HandBaggage
    {
        public int HandBaggageId { get; set; }

        public int Weight { get; set; }
    }
}
