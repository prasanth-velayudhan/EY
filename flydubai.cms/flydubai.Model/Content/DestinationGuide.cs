using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Destination Guide
    /// </summary>
    public class DestinationGuide : EntityBase<DestinationGuide, DestinationGuideVersion>
    {
        [Key]
        public int DestinationGuideId { get; set; }

        public override int Id
        {
            get { return this.DestinationGuideId; }
            set { this.DestinationGuideId = value; }
        }

        public virtual ICollection<AirportLocalised> AirportLocaliseds { get; set; }

        [NotMapped]
        public ICollection<Airport> Airports
        {
            get { return this.AirportLocaliseds.Select(x => x.Airport).ToList(); }
        }
    }
}
