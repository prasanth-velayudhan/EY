using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Beta
{

    public class UniquePageTitle
    {
        [Key]
        public string Language { get; set; }

        
        [DisplayName("Flight search result page-One day view")]
        public string FlightSearchResultOneDayView { get; set; }

        [DisplayName("Flight search result page-Three day view")]
        public string FlightSearchResultThreeDayView { get; set; }

        [DisplayName("Flight search result page-Month view")]
        public string FlightSearchResultMonthView { get; set; }

        [DisplayName("Optional extra page")]
        public string OPtionalExtraPage { get; set; }

        [DisplayName("Passenger Information Page")]
        public string PassngerInformationPage { get; set; }

        [DisplayName("Payment Page")]
        public string PaymentPage { get; set; }

        [DisplayName("Confirmaion Page")]
        public string ConfirmaionPage { get; set; }

        //WR-34 A-5453

        [DisplayName("Confirmaion Page")]
        public string AccountForgottenPassword { get; set; }

        [DisplayName("Confirmaion Page")]
        public string AccountLogin { get; set; }

        [DisplayName("Confirmaion Page")]
        public string AccountLogOut { get; set; }

        [DisplayName("Confirmaion Page")]
        public string ContactUsResults { get; set; }

        [DisplayName("Confirmaion Page")]
        public string ContactUsSearch { get; set; }

        [DisplayName("Confirmaion Page")]
        public string ResultsForChangeLogicalFlightDates { get; set; }

        [DisplayName("Confirmaion Page")]
        public string UpgradeToBusiness { get; set; }

        [DisplayName("Confirmaion Page")]
        public string ErrorFileNotFound { get; set; }

        [DisplayName("Confirmaion Page")]
        public string AdditionalPassengerDetails { get; set; }

        [DisplayName("Confirmaion Page")]
        public string AdditionalPassengerOptionalExtras { get; set; }

        [DisplayName("Confirmaion Page")]
        public string ShowAmendments { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileFind { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileList { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileViewTicket { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileSearchSearch { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileResults { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileStatusSearch { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileIndex { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileSessionTimeout { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileTimetableResults { get; set; }

        [DisplayName("Confirmaion Page")]
        public string MobileTimetableSearch { get; set; }

        [DisplayName("Confirmaion Page")]
        public string TASignin { get; set; }

        //WR-34 A-5453


    }
}
