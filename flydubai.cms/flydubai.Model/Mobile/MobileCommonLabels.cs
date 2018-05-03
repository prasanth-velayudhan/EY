using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Common Labels
    /// </summary>
    public class MobileCommonLabels : BaseLabels
    {
        public string Hi { get; set; }
        public string LogIn { get; set; }
        public string LogOut { get; set; }

        public string Flight { get; set; }
        public string Departing { get; set; }
        public string Returning { get; set; }
        public string Outbound { get; set; }
        public string Return { get; set; }
        public string To { get; set; }
        public string Total { get; set; }
        public string InclusiveOfAllTaxes { get; set; }

        public string Adult { get; set; }
        public string Adults { get; set; }
        public string Child { get; set; }
        public string Children { get; set; }
        public string Infant { get; set; }
        public string Infants { get; set; }

        public string NoChange { get; set; }
        public string PayToChange { get; set; }
        public string FreeToChange { get; set; }
       
        public string Fare { get; set; }
        public string FareLower { get; set; }

        public string Arrives { get; set; }
        public string Departs { get; set; }
        public string DirectFlight { get; set; }
        public string Duration { get; set; }
        public string Dur { get; set; }
        public string Stop { get; set; }

        public string Continue { get; set; }
        public string Back { get; set; }

        public string SelectAlternativeFlights { get; set; }
        public string StartAgain { get; set; }
        public string ContactUs { get; set; }

        public string PrimaryPassenger { get; set; }
        public string Day { get; set; }
        public string On { get; set; }

        public string Edit { get; set; }

        public string BackToTop { get; set; }

        //A-5616
        public string BusinessBasic { get; set; }
        public string Cabin { get; set; }
        public string Includes { get; set; }

        //FZWR-1279
        public string MetroStatusSearchError { get; set; }
    }
}
