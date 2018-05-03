namespace flydubai.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;

    /// <summary>
    /// Code Type
    /// </summary>
    [Serializable]
    public class TierType
    {
        [Key]
        public string TierTypeCode { get; set; }

        public string Language { get; set; }

        public string Name { get; set; }

    }
}
