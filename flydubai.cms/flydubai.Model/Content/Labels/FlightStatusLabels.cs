using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Flight Status Labels
    /// </summary>
    [DisplayName("Flight Status labels")]
    public class FlightStatusLabels : LabelsBase
    {
        [Key]
        public int FlightStatusLabelsId { get; set; }

        [DefaultValue("Flight Status")]
        [DisplayName("Module title")]
        public string ModuleTitle { get; set; }

        [DefaultValue("Check Flight Status")]
        [DisplayName("Module title")]
        public string SidebarModuleTitle { get; set; }

        [DefaultValue(
            "Please note, it is only possible to search single leg journeys at a time and not those that include connecting flights."
            )]
        [DisplayName("Select Date Information Text")]
        public string SelectDateInformationText { get; set; }

        [DefaultValue("Select when flight is due to arrive")]
        [DisplayName("Select Arrival Label")]
        public string SelectDateArrivalLabel { get; set; }

        [DefaultValue("When is the flight due?")]
        [DisplayName("Short Select Arrival Label")]
        public string ShortSelectDateArrivalLabel { get; set; }

        [DefaultValue("How do you want to search for the flight?")]
        [DisplayName("Choose Search Method Question")]
        public string SearchMethodQuestion { get; set; }

        [DefaultValue("Select route")]
        [DisplayName("Select Route Option Label")]
        public string SelectByRouteOptionLabel { get; set; }

        [DefaultValue("Enter flight number")]
        [DisplayName("Enter Flight Number Option Label")]
        public string EnterFlightNumberOptionLabel { get; set; }

        [DefaultValue("Or")]
        [DisplayName("Choose search method divider text")]
        public string ChooseSearchMethodDividerText { get; set; }

        [DefaultValue("Flying from")]
        [DisplayName("Flying From Default Text")]
        public string FlyingFromDefaultText { get; set; }

        [DefaultValue("Flying to")]
        [DisplayName("Flying To Default Text")]
        public string FlyingToDefaultText { get; set; }

        [DefaultValue("e.g FX78934")]
        [DisplayName("Flight Number Example Text")]
        public string FlightNumberExampleText { get; set; }

        [DefaultValue("Flight Results")]
        [DisplayName("Flight Results")]
        public string FlightResultsHeader { get; set; }

        [DefaultValue("to")]
        [DisplayName(
            "Flight Results Route Separator Text (example: 'Departure airport' to 'Arrival airport') where 'to' is the separator value."
            )]
        public string FlightResultsHeaderRouteSeparatorText { get; set; }

        [DefaultValue("Based on 24 hour clock. All times shown are local.")]
        [DisplayName("Timezone information text")]
        public string TimeZoneInformationText { get; set; }

        [DefaultValue("Outbound")]
        [DisplayName("Outbound Flight Label Text")]
        public string OutboundFlightLabelText { get; set; }

        [DefaultValue("Arrival")]
        [DisplayName("Arrival Flight Label Text")]
        public string ArrivalFlightLabelText { get; set; }

        [DefaultValue("Scheduled")]
        [DisplayName("Scheduled Arrival/Departure Time Label Text")]
        public string ScheduledFlightTimeLabelText { get; set; }

        [DefaultValue("Actual")]
        [DisplayName("Actual Arrival/Departure Time Label Text")]
        public string AcutalFlightTimeLabelText { get; set; }

        [DefaultValue("Status")]
        [DisplayName("Flight Status Label Text")]
        public string FlightStatusLabelText { get; set; }

        [DefaultValue("Get Flight Info")]
        [DisplayName("Get Flight Info Button Label")]
        public string GetFlightInfoButtonLabel { get; set; }

        [DefaultValue("Submit")]
        [DisplayName("Sumbit Flight Status Notification Request Button Label")]
        public string SubmitNotificationRequestButtonLabel { get; set; }

        [DefaultValue("No Flight Results Found")]
        [DisplayName("No Results Found Message")]
        public string NoResultsFound { get; set; }

        [DefaultValue("Not Yet Departed")]
        [DisplayName("Flight Status - Not Yet Departed")]
        public string FlightStatusNotYetDeparted { get; set; }

        [DefaultValue("Arrived")]
        [DisplayName("Flight Status - Arrived")]
        public string FlightStatusArrived { get; set; }

        [DefaultValue("In Flight")]
        [DisplayName("Flight Status - In Flight")]
        public string FlightStatusDeparted { get; set; }

        [DefaultValue("Cancelled")]
        [DisplayName("Flight Status - Cancelled")]
        public string FlightStatusCancelled { get; set; }

        [DefaultValue("Diverted")]
        [DisplayName("Flight Status - Diverted")]
        public string FlightStatusDiverted { get; set; }

        [DefaultValue("Re-Routed")]
        [DisplayName("Flight Status - Rerouted")]
        public string FlightStatusReRouted { get; set; }

        [DefaultValue("Forced Return(RAMP)")]
        [DisplayName("Flight Status - Forced Return(RAMP)")]
        public string FlightStatusForcedReturnRAMP { get; set; }

        [DefaultValue("Forced Return(AIR)")]
        [DisplayName("Flight Status - Forced Return(AIR)")]
        public string FlightStatusForcedReturnAIR { get; set; }

        [DefaultValue("Estimated")]
        [DisplayName("Estimated Label Test")]
        public string EstimatedLabelText { get; set; }

        [DefaultValue("")]
        [DisplayName("Flight Status - Unknown (leave blank to display nothing)")]
        public string FlightStatusUnknown { get; set; }

        [DefaultValue("Let us notify you of flight status updates")]
        [DisplayName("Flight Status Notification Header Text")]
        public string FlightStatusNotificationHeader { get; set; }

        [DefaultValue("Send flight notification by (select either or both)")]
        [DisplayName("Flight Status Notification Method Instructions Text")]
        public string FlightStatusNotificationMethodInstructions { get; set; }

        [DefaultValue("SMS")]
        [DisplayName("SMS Label Text")]
        public string FlightStatusNotificationSMSLabel { get; set; }

        [DefaultValue("Email")]
        [DisplayName("Email Method Label Text")]
        public string FlightStatusNotificationEmailLabel { get; set; }

        [DefaultValue("Pease enter your phone number, including country dialling code.")]
        [DisplayName("SMS input instructions")]
        public string FlightStatusNotificationSMSInstructions { get; set; }

        [DefaultValue("e.g. 44")]
        [DisplayName("SMS Area Code Example Text")]
        public string FlightStatusNotificationSMSAreaCodeExample { get; set; }

        [DefaultValue("Checking...")]
        [DisplayName("Message to display while waiting for results")]
        public string WaitingForResultsText { get; set; }

        [DefaultValue("Please enter your email address")]
        [DisplayName("Email input instructions")]
        public string FlightStatusNotificationEmailInstructions { get; set; }

        [DefaultValue("example@domain.com")]
        [DisplayName("Email Example Text")]
        public string FlightStatusNotificationEmailExample { get; set; }


        //FR 11 A-5583//
        public string ArrivalNextDayTooltip { get; set; }

        public string ArrivalNextDay { get; set; }

        public string Day { get; set; }
        //FR11 A-5583//
    }
}
