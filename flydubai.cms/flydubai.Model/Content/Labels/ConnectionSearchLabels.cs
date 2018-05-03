using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Connection Search Labels
    /// </summary>
    public class ConnectionSearchLabels : LabelsBase
    {
        [Key]
        public int ConnectionSearchLabelsId { get; set; }

        [DefaultValue("Connection search")]
        public string ModuleTitle { get; set; }

        [DefaultValue("flydubai has partnered with dohop to help you find the lowest fare when connecting to and from a flydubai flight. So if you want to fly to London, New York or Mumbai, flydubai can help.")]
        public string IntroductionText { get; set; }

        [DefaultValue("Round trip or one way selector")]
        public string RoundTripOneWayAccessibilityText { get; set; }

        [DefaultValue("Round trip")]
        public string RoundTripRadioButtonLabel { get; set; }

        [DefaultValue("One way")]
        public string OneWayRadioButtonLabel { get; set; }

        [DefaultValue("Flying from / flying to")]
        public string FlyingFromToAccessibilityText { get; set; }

        [DefaultValue("I am flying from")]
        public string FlyingFromLabelText { get; set; }

        [DefaultValue("")]
        public string FlyingFromPlaceholderText { get; set; }

        [DefaultValue("I am flying to")]
        public string FlyingToLabelText { get; set; }

        [DefaultValue("")]
        public string FlyingToPlaceholderText { get; set; }

        [DefaultValue("Departure date / return date")]
        public string DepartureReturnDateAccessibilityText { get; set; }

        [DefaultValue("Departure date")]
        public string DepartureDateLabelText { get; set; }

        [DefaultValue("Return date")]
        public string ReturnDateLabelText { get; set; }

        [DefaultValue("Submit details")]
        public string ShowConnectionsAccessibilityText { get; set; }

        [DefaultValue("Show connections")]
        public string ShowConnectionsButton { get; set; }

        [DefaultValue("Find out more")]
        public string FindOutMoreLinkText { get; set; }

        [DefaultValue("")]
        public string FindOutMoreLinkUrl { get; set; }

        [DefaultValue("dohop")]
        public string DohopLinkText { get; set; }

        [DefaultValue("")]
        public string DohopLinkUrl { get; set; }
    }
}
