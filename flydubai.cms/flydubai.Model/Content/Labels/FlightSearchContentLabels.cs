using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Flight Search Content Labels
    /// </summary>
    public class FlightSearchContentLabels : LabelsBase
    {
        [Key]
        public int FlightSearchContentLabelsId { get; set; }

        public string FlightSearch { get; set; }

        public string ManageBooking { get; set; }

        public string PleaseSelectOriginAirport { get; set; }

        public string PleaseWaitWhileWeCheckForLowest { get; set; }

        public string LoadingResults { get; set; }

        public string NoAirportsFound { get; set; }

        public string Loading { get; set; }

        public string PleaseWait { get; set; }

        public string PleaseTrySearchAgain { get; set; }
    }
}
