using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Site Search Category Labels
    /// </summary>
    public class SiteSearchCategoryLabels : LabelsBase
    {
        [Key]
        public int SiteSearchCategoryLabelsId { get; set; }

        [DefaultValue("Plan")]
        public string Plan { get; set; }

        [DefaultValue("Travel")]
        public string Travel { get; set; }

        [DefaultValue("Special Offers")]
        public string SpecialOffers { get; set; }

        [DefaultValue("About Us")]
        public string AboutUs { get; set; }

        [DefaultValue("News")]
        public string News { get; set; }

        [DefaultValue("Contact Us")]
        public string ContactUs { get; set; }
    }
}
