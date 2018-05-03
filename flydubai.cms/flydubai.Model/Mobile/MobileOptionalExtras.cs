using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Optional Extras Labels
    /// </summary>
    public class MobileOptionalExtrasLabels : BaseLabels
    {
        public string OptionalExtras { get; set; }
        public string FlightAndExtras { get; set; }

        public string PrimaryPassenger { get; set; }

        public string NeedExtraBaggageAllowance { get; set; }
        public string EachMemberOfYourParty { get; set; }

        public string kg { get; set; }
        public string CheckedBaggage { get; set; }

        public string ChildrenYoungerThan2YearsNoBaggage { get; set; }

        public string TotalIncHandBaggage { get; set; }

        public string WhereDoYouWantToSitGoingOut { get; set; }
        public string WhereDoYouWantToSitReturn { get; set; }

        public string AllocationAtCheckIn { get; set; }
        public string SeatMap { get; set; }
        public string Surcharge { get; set; }
        public string Exit { get; set; }

        public string YesInsuranceRequired { get; set; }
        public string ForEachPassengerCancellationMedicalEtc { get; set; }
        public string NoBaggage { get; set; }

        public string BackToTop { get; set; }

        public string SkipSeats { get; set; }
        public string Aisle { get; set; }
        public string Window { get; set; }
        public string Seat { get; set; }
        public string Row { get; set; }
        public string ChildrenYoungerThan2YearsNoSeats { get; set; }

        public string SkipBaggage { get; set; }

        public string UseTheMenusAboveToSelect { get; set; }

        public string NoInsurance { get; set; }

        public string ViewTheSeatingDiagramBelow { get; set; }

        public string Only { get; set; }

        public string BagsLeftAt { get; set; }

        public string ResetAllSeats { get; set; }

        [DefaultValue("No thanks {0}kg hand baggage is fine")]
        [DisplayName("No extra baggage drop down option (use {0} for the hand baggage weight) (e.g. No thanks {0}kg hand baggage is fine)")]
        public string NoExtraBaggageDropDownOption { get; set; }

        [DefaultValue("{0}kg hand baggage plus {1}kg included checked baggage allowance")]
        [DisplayName("Included extra baggage drop down option (use {0} for the hand baggage weight, {1} for checked baggage weight) (e.g. {0}kg hand baggage plus {1}kg included checked baggage allowance)")]
        public string IncludedExtraBaggageDropDownOption { get; set; }

        [DefaultValue("Add {0}kg checked baggage ({1}kg) total {2}")]
        [DisplayName("Add extra baggage drop down option (use {0} for the additional weight, {1} for the total weight, {2} for the total cost) (e.g. Add {0}kg checked baggage ({1}kg) total {2})")]
        public string AddExtraBaggageDropDownOption { get; set; }

        //A-4639
        public string SeatSelection { get; set; }
        public string BaggageAllowance { get; set; }
        public string BusinessHeadingOverSeatImage { get; set; }
        public string HandBaggage { get; set; }
        public string Free { get; set; }

        //A-5616
        public string SkipMeal { get; set; }
        public string MealSubHdrTxt { get; set; }
        public string ChildrenYoungerThan2YearsNoMeal { get; set; }
        public string NoDietary { get; set; }
        public string BuyMealForTheJourney { get; set; }
        public string NoMealRequired { get; set; }
        public string BuyMealOnBoard { get; set; }
        public string IncludedMeals { get; set; } 
        //WR9:A-4740: Pre-select insurance: Start
        public string ProtectYourselfOnYourTrip { get; set; }
        public string PreselectInsuranceMessageMobile { get; set; }
        //WR9:A-4740: Pre-select insurance: End
    }
}
