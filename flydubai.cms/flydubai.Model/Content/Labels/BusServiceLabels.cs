using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Bus Service Labels
    /// </summary>
    public class BusServiceLabels : LabelsBase
    {
        [Key]
        public int BusServiceLabelsId { get; set; }

        [DefaultValue("Search for a bus")]
        [DisplayName("Main search title")]
        public string SearchForABus { get; set; }

        [DefaultValue("Round Trip")]
        [DisplayName("Round trip radio label")]
        public string RoundTrip { get; set; }

        [DefaultValue("One way")]
        [DisplayName("One way radio label")]
        public string OneWay { get; set; }

        [DefaultValue("From")]
        [DisplayName("From field label")]
        public string From { get; set; }

        [DefaultValue("To")]
        [DisplayName("To field label")]
        public string To { get; set; }

        [DefaultValue("Outbound date")]
        [DisplayName("Outbound date field label")]
        public string OutboundDate { get; set; }

        [DefaultValue("Return date")]
        [DisplayName("Return date field label")]
        public string ReturnDate { get; set; }

        [DefaultValue("Passengers")]
        [DisplayName("Passengers heading label")]
        public string Passengers { get; set; }

        [DefaultValue("Adults")]
        [DisplayName("Adults dropdown label")]
        public string Adults { get; set; }

        [DefaultValue("Twelve Plus")]
        [DisplayName("Adults age boundary label")]
        public string TwelvePlus { get; set; }

        [DefaultValue("Children")]
        [DisplayName("Children dropdown label")]
        public string Children { get; set; }

        [DefaultValue("2 to 12")]
        [DisplayName("Children age boundary label")]
        public string TwotoTwelve { get; set; }

        [DefaultValue("Infants")]
        [DisplayName("Infants dropdown label")]
        public string Infants { get; set; }

        [DefaultValue("Under 2")]
        [DisplayName("Infants age limit label")]
        public string UnderTwo { get; set; }

        [DefaultValue("Book here")]
        [DisplayName("Book here button label")]
        public string BookHere { get; set; }

        [DefaultValue("Leaving from")]
        [DisplayName("Leaving from hint text")]
        public string LeavingFromHintText { get; set; }

        [DefaultValue("Going to")]
        [DisplayName("Going to hint text")]
        public string GoingToHintText { get; set; }

        [DefaultValue("Infant passengers")]
        [DisplayName("Infants tooltip heading")]
        public string InfantsTooltipHeading { get; set; }

        [DefaultValue("Under 2 tooltip")]
        [DisplayName("Infants tooltip text")]
        public string InfantsTooltipText { get; set; }
    }
}
