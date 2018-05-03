using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Time table Labels
    /// </summary>
    public class TimetableLabels : LabelsBase
    {
        [Key]
        public int TimetableLabelsId { get; set; }

        [DefaultValue("Timetable")]
        [DisplayName("Main timetable title")]
        public string Timetable { get; set; }

        [DefaultValue("Lorem ipsum")]
        [DisplayName("Main timetable instructions")]
        public string TimetableCopy { get; set; }

        [DefaultValue("Search for a timetable")]
        [DisplayName("Main timetable heading")]
        public string SearchForATimetable { get; set; }

        [DefaultValue("Round trip")]
        [DisplayName("Round trip radio label")]
        public string RoundTrip { get; set; }

        [DefaultValue("One way")]
        [DisplayName("One way radio label")]
        public string OneWay { get; set; }

        [DefaultValue("Flying from")]
        [DisplayName("Flying from field label")]
        public string FlyingFrom { get; set; }

        [DefaultValue("Flying to")]
        [DisplayName("Flying to field label")]
        public string FlyingTo { get; set; }

        [DefaultValue("Outbound")]
        [DisplayName("Outbound date field label")]
        public string Outbound { get; set; }

        [DefaultValue("Return")]
        [DisplayName("Return date field label")]
        public string Return { get; set; }

        [DefaultValue("Based on 24 hour clock. All times shown are local.")]
        [DisplayName("24 hour copy")]
        public string BasedOn24HourClock { get; set; }

        [DefaultValue("Show timetable")]
        [DisplayName("Show timetable button label")]
        public string ShowTimetable { get; set; }

        [DefaultValue("Flight Number")]
        [DisplayName("Flight Number result label")]
        public string FlightNumber { get; set; }

        [DefaultValue("Airline")]
        [DisplayName("Airline result label")]
        public string Airline { get; set; }

        [DefaultValue("Effective between")]
        [DisplayName("Effective between result label")]
        public string EffectiveBetween { get; set; }

        [DefaultValue("Departs")]
        [DisplayName("Departs result label")]
        public string Departs { get; set; }

        [DefaultValue("Arrives")]
        [DisplayName("Arrives result label")]
        public string Arrives { get; set; }

        [DefaultValue("Stops")]
        [DisplayName("Stops result label")]
        public string Stops { get; set; }

        [DefaultValue("Duration")]
        [DisplayName("Duration result label")]
        public string Duration { get; set; }

        [DefaultValue("Monday")]
        [DisplayName("Monday result label")]
        public string Monday { get; set; }

        [DefaultValue("Tuesday")]
        [DisplayName("Tuesday result label")]
        public string Tuesday { get; set; }

        [DefaultValue("Wednesday")]
        [DisplayName("Wednesday result label")]
        public string Wednesday { get; set; }

        [DefaultValue("Thursday")]
        [DisplayName("Thursday result label")]
        public string Thursday { get; set; }

        [DefaultValue("Friday")]
        [DisplayName("Friday result label")]
        public string Friday { get; set; }

        [DefaultValue("Saturday")]
        [DisplayName("Saturday result label")]
        public string Saturday { get; set; }

        [DefaultValue("Sunday")]
        [DisplayName("Sunday result label")]
        public string Sunday { get; set; }

        [DefaultValue("No timetable for date selected")]
        [DisplayName("No timetable result")]
        public string NoTimetable { get; set; }

        [DefaultValue("Download this timetable as a PDF")]
        [DisplayName("Download PDF copy")]
        public string DownloadPDF { get; set; }

        [DefaultValue("Download")]
        [DisplayName("Download button label")]
        public string Download { get; set; }

        [DefaultValue("Want to see available flights? Tell us who's traveling.")]
        [DisplayName("Search copy")]
        public string SeeAvailableFlights { get; set; }

        [DefaultValue("Passengers")]
        [DisplayName("Passengers subheading copy")]
        public string Passengers { get; set; }

        [DefaultValue("Adults")]
        [DisplayName("Adults droplist label")]
        public string Adults { get; set; }

        [DefaultValue("12+ years")]
        [DisplayName("Adults age boundary label")]
        public string TwelvePlus { get; set; }

        [DefaultValue("Children")]
        [DisplayName("Children droplist label")]
        public string Children { get; set; }

        [DefaultValue("2-12 years")]
        [DisplayName("Children age boundary label")]
        public string TwoToTwelve { get; set; }

        [DefaultValue("Infants")]
        [DisplayName("Infants droplist label")]
        public string Infants { get; set; }

        [DefaultValue("Under 2 years")]
        [DisplayName("Infants age boundary label")]
        public string UnderTwoYears { get; set; }

        [DefaultValue("Show flights")]
        [DisplayName("Show flights button label")]
        public string ShowFlights { get; set; }

        [DefaultValue("Timetable")]
        public string SidebarModuleTitleText { get; set; }

        [DefaultValue("Round trip or one way selector")]
        public string SidebarModuleRoundTripOneWayAccessibilityText { get; set; }

        [DefaultValue("Round trip")]
        public string SidebarModuleRoundTripRadioButtonText { get; set; }

        [DefaultValue("One way")]
        public string SidebarModuleOneWayRadioButtonText { get; set; }

        [DefaultValue("Flying from")]
        public string SidebarModuleFlyingFromAccessibilityText { get; set; }

        [DefaultValue("I am flying from")]
        public string SidebarModuleFlyingFromLabelText { get; set; }

        [DefaultValue("I am flying out on")]
        public string SidebarModuleFlyingOutOnLabelText { get; set; }

        [DefaultValue("Flying to")]
        public string SidebarModuleFlyingToAccessibilityText { get; set; }

        [DefaultValue("I am flying to")]
        public string SidebarModuleFlyingToLabelText { get; set; }

        [DefaultValue("I am flying back on")]
        public string SidebarModuleFlyingBackOnLabelText { get; set; }

        [DefaultValue("Submit details")]
        public string SidebarModuleSubmitDetailsAccessibilityText { get; set; }

        [DefaultValue("Show timetable")]
        public string SidebarModuleShowTimetableButton { get; set; }
    }
}
