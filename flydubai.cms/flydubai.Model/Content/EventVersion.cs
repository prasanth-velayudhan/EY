using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Event Version
    /// </summary>
    public class EventVersion : EntityVersionBase<Event, EventVersion>
    {
        [Key]
        public int EventVersionId { get; set; }

        public override int Id
        {
            get { return this.EventVersionId; }
            set { this.EventVersionId = value; }
        }

        public string EventHeader { get; set; }

        public string EventDescription { get; set; }

        public int? Image { get; set; }

        public bool DisplayButton { get; set; }

        public string TravellingFrom { get; set; }

        public string TravellingTo { get; set; }

        public string ThirdPartyUrl { get; set; }

        public virtual ICollection<Airport> Airports { get; set; }
    }
}
