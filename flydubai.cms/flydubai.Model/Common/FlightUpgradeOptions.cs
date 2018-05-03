namespace flydubai.Model.Common
{
    using System;

    /// <summary>
    /// Flight Upgrade Options
    /// </summary>
    [Serializable]
    public class FlightUpgradeOptions
    {
        public int FareTypeId { get; set; }

        public string FareTypeLabel { get; set; }

        public decimal TotalExtra { get; set; }

        public string Label
        {
            get { return string.Format("{0} (Total {1} Extra)", this.FareTypeLabel, this.TotalExtra); }
        }
    }
}