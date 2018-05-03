using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Travel Agent Version
    /// </summary>
    public class TravelAgentVersion : EntityVersionBase<TravelAgent, TravelAgentVersion>
    {
        [Key]
        public int TravelAgentVersionId { get; set; }

        public override int Id
        {
            get { return this.TravelAgentVersionId; }
            set { this.TravelAgentVersionId = value; }
        }

        public string Name { get; set; }

        //[ForeignKey("Country")]
        //public virtual int CountryId { get; set; }

        //[ForeignKey("CountryId")]
        //public virtual CountryLocalised Country { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        [ForeignKey("City")]
        public virtual int? CityId { get; set; }

        public string Address { get; set; }

        public string Telephone { get; set; }

        public string TelephoneHours { get; set; }

        public double? Longitude { get; set; }

        public double? Latitude { get; set; }
    }
}
