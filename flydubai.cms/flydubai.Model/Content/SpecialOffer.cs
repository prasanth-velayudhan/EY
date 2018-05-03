using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Special Offer
    /// </summary>
    public class SpecialOffer : EntityBase<SpecialOffer, SpecialOfferVersion>
    {
        [Key]
        public int SpecialOfferId { get; set; }

        public override int Id
        {
            get { return this.SpecialOfferId; }
            set { this.SpecialOfferId = value; }
        }
    }
}
