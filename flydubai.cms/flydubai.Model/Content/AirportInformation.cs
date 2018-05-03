using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Airport Information
    /// </summary>
    public class AirportInformation : EntityBase<AirportInformation, AirportInformationVersion>
    {
        [Key]
        public int AirportInformationId { get; set; }

        public override int Id
        {
            get { return this.AirportInformationId; }
            set { this.AirportInformationId = value; }
        }

        [ForeignKey("Airport")]
        public string AirportCode { get; set; }

        [ForeignKey("AirportCode")]
        public virtual Airport Airport { get; set; }

        public virtual ICollection<DestinationGuideVersion> DestinationGuideVersions { get; set; }

        public virtual ICollection<EventVersion> EventVersions { get; set; }

        public virtual ICollection<SpecialOfferVersion> SpecialOfferVersions { get; set; }
    }
}
