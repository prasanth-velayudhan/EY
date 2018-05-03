using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    public class GeolocatedBanner : EntityBase<GeolocatedBanner, GeolocatedBannerVersion>
    {
        /// <summary>
        /// Gets or sets the Geolocated Banner id.
        /// </summary>
        /// <value>
        /// The route message id.
        /// </value>
        [Key]
        public int GeolocatedBannerId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public override int Id
        {
            get { return this.GeolocatedBannerId; }
            set { this.GeolocatedBannerId = value; }
        }
    }
}
