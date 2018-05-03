namespace flydubai.Model.Journey
{
    using System;

    /// <summary>
    /// Wheelchair Access Optional Extra
    /// </summary>
    [Serializable]
    public class MealsOptionalExtra : JourneyOptionalExtra
    {
        public string MealHeldCode { get; set; }

        public string FlightNumber { get; set; }
     
        public string CurrencyCode { get; set; }
    }
}
