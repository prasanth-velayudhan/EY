namespace flydubai.Model.Fares
{
    using System;

    /// <summary>
    /// Fare Basis Details
    /// </summary>
    [Serializable]
    public class FareBasisDetails
    {
        public string FareBasisCode { get; set; }

        public double HoursAfterBook { get; set; }

        public double HoursBeforeFlight { get; set; }
    }
}
