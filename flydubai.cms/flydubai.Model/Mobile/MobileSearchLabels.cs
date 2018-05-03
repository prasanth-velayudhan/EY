using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Search Labels
    /// </summary>
    public class MobileSearchLabels : BaseLabels
    {
        public string FlightSearch { get; set; }
        public string RoundTrip { get; set; }
        public string OneWay { get; set; }
        public string IAmFlyingFrom { get; set; }
        public string IAmFlyingTo { get; set; }
        public string IAmFlyingOutOn { get; set; }
        public string IAmFlyingBackOn { get; set; }

        public string TwoTo12 { get; set; }
        public string Under2Years { get; set; }
        public string AllInfantsMustTravelWithAnAdult { get; set; }

        public string DoYouHaveAPromoCode { get; set; }
        public string ShowFlights { get; set; }

        public string ReEnterPromoCode { get; set; }

        public string YourPromoCodeHasBeenAccepted { get; set; }
        public string ClickNextToContinue { get; set; }
        public string WeAreHavingTroubleWithYourSearch { get; set; }

        public string BackToTop { get; set; }

        //A-5616 added for dropdownlist
        public string FlightClass { get; set; }
        public string AllCabin { get; set; }
        public string Economy { get; set; }
        public string Business { get; set; }

        //FZWR-399 A-5851 WR6
        public string TroubleWithSummaryPNR { get; set; }
        //FZWR-399 A-5851 WR6
    }
}
