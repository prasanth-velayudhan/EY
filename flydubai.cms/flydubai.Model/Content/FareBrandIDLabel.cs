using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// FareBrandID Label
    /// </summary>
    [Serializable]
    public class FareBrandIDLabel
    {
        [Key]
        public int FareBrandIDLabelId { get; set; }

        public int FareTypeID { get; set; }

        public string FareTypeName { get; set; }

        public string CabinClass { get; set; }

        public int LanguageId { get; set; }

        public int Order { get; set; }

        public bool ShowInEconomy { get; set; }

        public bool ShowInBusiness { get; set; }

        public string WebFareType { get; set; }

        public bool ShowInConsumerEconomy { get; set; }

        public bool ShowInConsumerBusiness { get; set; }

        public bool ShowInMobileEconomy { get; set; }

        public bool ShowInMobileBusiness { get; set; }

        public string PrimaryCabinClass { get; set; }

        public string SecondaryCabinClass { get; set; }
    }
}
