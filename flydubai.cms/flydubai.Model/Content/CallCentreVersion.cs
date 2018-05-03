using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Call Centre Version
    /// </summary>
    public class CallCentreVersion : EntityVersionBase<CallCentre, CallCentreVersion>
    {
        [Key]
        public int CallCentreVersionId { get; set; }

        public override int Id
        {
            get { return this.CallCentreVersionId; }
            set { this.CallCentreVersionId = value; }
        }

        [Required]
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        [ForeignKey("Country")]
        public virtual int CountryId { get; set; }

        public string Telephone { get; set; }

    }
}
