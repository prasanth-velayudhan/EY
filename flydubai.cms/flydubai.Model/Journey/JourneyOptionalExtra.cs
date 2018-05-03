namespace flydubai.Model.Journey
{
    using System;

    /// <summary>
    /// abstract class Journey Optional Extra
    /// </summary>
    [Serializable]
    public abstract class JourneyOptionalExtra
    {
        public JourneyOptionalExtra()
        {
            
        }

        public int ServiceId { get; set; }

        public int CategoryId { get; set; }

        public string CodeType { get; set; }

        public decimal Total { get; set; }

        public string FLXDiagnosticID { get; set; }

        public int PhysicalFlightId { get; set; }

        public bool IsModified { get; set; }

        /// <summary>
        /// Shallows the copy.
        /// </summary>
        /// <returns></returns>
        public JourneyOptionalExtra ShallowCopy()
        {
            return (JourneyOptionalExtra)this.MemberwiseClone();
        }
    }
}