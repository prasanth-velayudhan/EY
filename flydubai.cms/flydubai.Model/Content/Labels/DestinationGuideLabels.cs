using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Destination Guide Labels
    /// </summary>
    public class DestinationGuideLabels : LabelsBase
    {
        [Key]
        public int DestinationGuideLabelsId { get; set; }

        [DefaultValue("Destinations / Alternatively, let us inspire you...")]
        public string MapTitle { get; set; }

        [DefaultValue("Inspiration starting point")]
        public string FormLabel { get; set; }

        [DefaultValue("Select your starting point")]
        public string SelectYourStartingPoint { get; set; }

        [DefaultValue("- Select Country -")]
        public string SelectCountry { get; set; }

        [DefaultValue("- Select City -")]
        public string SelectCity { get; set; }

        [DefaultValue("Max flight time")]
        public string MaxFlightTime { get; set; }

        [DefaultValue("hours")]
        public string Hours { get; set; }

        [DefaultValue("Currently displaying {0} of {1} connections")]
        [DisplayName("Destinations map result count (use {0} for currently displayed, {1} for total) (e.g. Currently displaying {0} of {1} connections)")]
        public string CurrentlyDisplaying { get; set; }

        [DefaultValue("View destination guide")]
        public string ViewDestinationGuide { get; set; }

        [DefaultValue("Book now")]
        public string BookNow { get; set; }

        [DefaultValue("Airport")]
        public string Airport { get; set; }

        [DefaultValue("Country")]
        public string Country { get; set; }

        [DefaultValue("City")]
        public string City { get; set; }

        [DefaultValue("Flight time")]
        public string FlightTime { get; set; }

        [DefaultValue("Things to do")]
        public string ThingsToDo { get; set; }

        [DefaultValue("Beach")]
        public string Beach { get; set; }

        [DefaultValue("Nightlife")]
        public string Nightlife { get; set; }

        [DefaultValue("Family")]
        public string Family { get; set; }

        [DefaultValue("Romantic")]
        public string Romantic { get; set; }

        [DefaultValue("Culture")]
        public string Culture { get; set; }

        [DefaultValue("Sports")]
        public string Sports { get; set; }

        [DefaultValue("Go")]
        public string Go { get; set; }

        [DefaultValue("View map")]
        public string ViewMap { get; set; }

        [DefaultValue("Close map")]
        public string CloseMap { get; set; }

        [DefaultValue("Where are you flying from?")]
        public string TooltipHeading { get; set; }

        [DefaultValue("Select your departure country and city from here.")]
        public string TooltipText { get; set; }
    }
}
