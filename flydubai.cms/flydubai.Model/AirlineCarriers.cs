using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model
{
    [Serializable]
    public class AirlineCarriers
    {
        public AirlineCarriers()
        {
            this.Localised = new List<AirlineCarrierLocalised>();
        }

        [Key]
        public string CarrierCode { get; set; }

        public string CarrierName { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<AirlineCarrierLocalised> Localised { get; set; }

        public AirlineCarrierLocalised GetLocalisedAirlineCarrier(string languageCode)
        {
            return this.Localised != null ? this.Localised.Where(l => l.Language == languageCode).FirstOrDefault() : null;
        }
    }
}
