namespace flydubai.Model
{
    using System;

    /// <summary>
    /// Country Localised
    /// </summary>
    [Serializable]
    public class CountryLocalised : ILocalisable
    {
        public int CountryLocalisedId { get; set; }

        public string Language { get; set; }

        public string Name { get; set; }

        public Country Country { get; set; }
    }
}