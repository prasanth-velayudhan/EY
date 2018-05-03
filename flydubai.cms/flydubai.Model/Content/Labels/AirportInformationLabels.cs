using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Airport Information Labels
    /// </summary>
    public class AirportInformationLabels : LabelsBase
    {
        [Key]
        public int AirportInformationLabelsId { get; set; }

        [DefaultValue("Search")]
        public string SearchModuleTitle { get; set; }

        [DefaultValue("Country")]
        public string SearchModuleCountryLabel { get; set; }

        [DefaultValue("City")]
        public string SearchModuleCityLabel { get; set; }

        [DefaultValue("Search")]
        public string SearchModuleSearchButton { get; set; }

        [DefaultValue("- Select Country -")]
        public string SearchModuleSelectCountry { get; set; }

        [DefaultValue("- Select City -")]
        public string SearchModuleSelectCity { get; set; }

        [DefaultValue("Location")]
        public string AirportLocationTitle { get; set; }
        
        [DefaultValue("See Map")]
        public string AirportLocationSeeMapLink { get; set; }

        [DefaultValue("Time")]
        public string AirportTimeZoneTitle { get; set; }

        [DefaultValue("Contacts")]
        public string AirportContactsTitle { get; set; }

        [DefaultValue("Transfer city")]
        public string AirportTransferCityTitle { get; set; }

        [DefaultValue("Car rental")]
        public string AirportCarRentalTitle { get; set; }

        [DefaultValue("Car parking")]
        public string AirportCarParkingTitle { get; set; }

        [DefaultValue("Airport facilities")]
        public string AirportFacilitiesTitle { get; set; }

        [DefaultValue("Visa information")]
        public string AirportVisaInformationTitle { get; set; }

        [DefaultValue("Check-in information")]
        public string AirportCheckInTitle { get; set; }

        [DefaultValue("Airports")]
        public string AirportListTitle { get; set; }

        [DefaultValue("- Select -")]
        public string AirportListSelect { get; set; }

        [DefaultValue("Go")]
        public string AirportListGo { get; set; }
    }
}
