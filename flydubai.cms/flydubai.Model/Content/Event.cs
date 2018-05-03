using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Event
    /// </summary>
    public class Event : EntityBase<Event, EventVersion>
    {
        [Key]
        public int EventId { get; set; }

        public override int Id
        {
            get { return this.EventId; }
            set { this.EventId = value; }
        }
    }
}
