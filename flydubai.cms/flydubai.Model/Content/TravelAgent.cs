using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Travel Agent
    /// </summary>
    public class TravelAgent : EntityBase<TravelAgent, TravelAgentVersion>
    {
        [Key]
        public int TravelAgentId { get; set; }

        public override int Id
        {
            get { return this.TravelAgentId; }
            set { this.TravelAgentId = value; }
        }
    }
}
