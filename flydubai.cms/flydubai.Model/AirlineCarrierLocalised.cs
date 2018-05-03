using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model
{
    [Serializable]
    [Table("AirlineCarrierLocalised")]
    public class AirlineCarrierLocalised : ILocalisable
    {
        [Key]
        public int CarrierLocalisedId { get; set; }

        public string Language { get; set; }

        public string CarrierCode { get; set; }

        public string CarrierName { get; set; }

        public int? TailImageId { get; set; }

        public string TailImageURL { get; set; }
    }
}
