using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Passenger Labels
    /// </summary>
    public class MobilePassengerLabels : BaseLabels
    {
        public string PassengerDetails { get; set; }
        public string FlightsAndExtras { get; set; }

        public string HaveAFlydubaiAccount { get; set; }
        public string YourDetailsWillBeFilledInAutomatically { get; set; }
        public string LoginAsFlydubaiMember { get; set; }

        public string AdultPassenger { get; set; }
        public string PrimaryPassenger { get; set; }
        public string ChildPassenger { get; set; }
        public string InfantPassenger { get; set; }
        public string Passenger { get; set; }

        public string YourDetails { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string PreferredContactNumber { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }

        public string DateOfBirth { get; set; }
        public string AssignInfantTo { get; set; }

        public string ContactNumber { get; set; }
        public string Edit { get; set; }

        public string BackToTop { get; set; }

        public string TitleDropDownDefaultText { get; set; }

        public string CountryCodeDefaultText { get; set; }

        // FFP
        //public string EnterFFPNum { get; set; }
        public string FFPNum { get; set; }
        //public string AddFFPNum { get; set; }
        //public string Add { get; set; }
        //public string Cancel { get; set; }

        public string IWouldLikeToSubscribeToFlydubaiOffers { get; set; }
    }
}
