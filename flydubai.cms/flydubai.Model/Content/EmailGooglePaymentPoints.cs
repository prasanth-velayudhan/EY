using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Email Google Payment Points
    /// </summary>
    public class EmailGooglePaymentPoints
    {
        public int Country { get; set; }
        public int City { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public int? PartnerType { get; set; }
        public double North { get; set; }
        public double East { get; set; }
        public double South { get; set; }
        public double West { get; set; }
        public int MaximumDisplayedPaymentPoints { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int MapHeight { get; set; }
        public int MapWidth { get; set; }
        public int Zoom { get; set; }
        public string WebsiteUrl { get; set; }
    }
}
