using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    public class GeolocatedBannerVersion : EntityVersionBase<GeolocatedBanner, GeolocatedBannerVersion>
    {
        /// <summary>
        /// Gets or sets the Geolocated Banner Version id.
        /// </summary>
        /// <value>
        /// The route message version id.
        /// </value>
        [Key]
        public int GeolocatedBannerVersionId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public override int Id
        {
            get { return this.GeolocatedBannerVersionId; }
            set { this.GeolocatedBannerVersionId = value; }
        }

        public string Url { get; set; }
        public string Url2 { get; set; }
        public string Url3 { get; set; }
        public string Url4 { get; set; }
        public string Url5 { get; set; }
        public string Url6 { get; set; }
        public string Url7 { get; set; }
        public string Url8 { get; set; }
        public string Url9 { get; set; }
        public string Url10 { get; set; }
        

        [ForeignKey("Country")]
        public virtual int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        [ForeignKey("City")]
        public virtual int? CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        public int? Image { get; set; }
        public int? Image2 { get; set; }
        public int? Image3 { get; set; }
        public int? Image4 { get; set; }
        public int? Image5 { get; set; }
        public int? Image6 { get; set; }
        public int? Image7 { get; set; }
        public int? Image8 { get; set; }
        public int? Image9 { get; set; }
        public int? Image10 { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsDefault { get; set; }

        public bool NewWindow { get; set; }
        public bool NewWindow2 { get; set; }
        public bool NewWindow3 { get; set; }
        public bool NewWindow4 { get; set; }
        public bool NewWindow5 { get; set; }
        public bool NewWindow6 { get; set; }
        public bool NewWindow7 { get; set; }
        public bool NewWindow8 { get; set; }
        public bool NewWindow9 { get; set; }
        public bool NewWindow10 { get; set; }


    }
}
