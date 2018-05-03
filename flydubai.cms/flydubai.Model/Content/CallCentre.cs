using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Call Centre
    /// </summary>
    public class CallCentre : EntityBase<CallCentre, CallCentreVersion>
    {
        [Key]
        public int CallCentreId { get; set; }

        public override int Id
        {
            get { return this.CallCentreId; }
            set { this.CallCentreId = value; }
        }

    }
}
