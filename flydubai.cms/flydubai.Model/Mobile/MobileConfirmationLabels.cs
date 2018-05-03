using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Confirmation Labels
    /// </summary>
    public class MobileConfirmationLabels : BaseLabels
    {
        public string YourBookingRef { get; set; }
        public string YourPaymentRef { get; set; }

        public string AnEmailHasBeenSent { get; set; }

        public string TotalCost { get; set; }
        public string Fligts { get; set; }
        public string BaggageTotal { get; set; }
        public string SeatingTotal { get; set; }
        public string Insurance { get; set; }
        public string CCFee { get; set; }
        public string Taxes { get; set; }
        public string PromoDiscount { get; set; }
        public string TotalPayment { get; set; }

        public string YourJourney { get; set; }

        public string YourBookingIsHeld { get; set; }
        public string ToCompleteTheBooking { get; set; }
        public string LocateNearsetPaymentPoint { get; set; }

        public string BackToTop { get; set; }

        public string BookingHeldFor48Hours { get; set; }
        public string PleaseArriveAtLeast { get; set; }
        public string ThreeHours { get; set; }
        public string BeforeYourFlightToAllowForCheckIn { get; set; }
        public string PaymentDue { get; set; }
        public string HandBaggage { get; set; }
        public string CheckedBaggage { get; set; }
        public string kg { get; set; }
        public string Seat { get; set; }
        public string Home { get; set; }

        public string SorryUnableToMakeBooking { get; set; }
        public string ContactUs { get; set; }
        public string SeatsNoLongerAvailable { get; set; }
        public string SelectDifferentSeats { get; set; }
        public string OrYouCanContinueBookingWithout { get; set; }
        public string ChoosingToPayLaterRequires { get; set; }
        public string FortyEightHours { get; set; }
        public string AtAPaymentPoint { get; set; }

        public string FlightNoLongerAvailable { get; set; }
        public string SorryButWhileYouWereSelecting { get; set; }
        public string ThisCanHappen { get; set; }
        public string SelectAlternativeFlight { get; set; }
        public string StartAgain { get; set; }

        //A-5616
        public string SelectDifferentMeals { get; set; }
        public string OrYouCanContinueBookingWithoutMeals { get; set; }

        //public string FfpNumber { get; set; }
        //public string TierName { get; set; }
        public string AwardPoints { get; set; }
        public string TierPoints { get; set; }
        public string ReservationExpiryMpesa { get; set; }

        public string MobileReviewQueueMessage { get; set; }
        public string MobileReviewQueueDetailedMessage { get; set; }
        public string AdministrationFee { get; set; }

         public string MpesaStepsToPayWithMpesa { get; set; }
         public string MpesaDialAndSelectOption { get; set; }
         public string MpesaEnterOptionFourPay { get; set; }
         public string MpesaEnterOptionFourBusiness { get; set; }
         public string MpesaEnterBusinessNumber { get; set; }
         public string MpesaEnterFlightBookingNumber { get; set; }
         public string MpesaEnterAmount { get; set; }
         public string MpesaEnterPersonalPin { get; set; }
         public string MpesaReconfirmDetails { get; set; }
         public string MpesaReceiveConfirmation { get; set; }


        //public string BinDiscountedAmount { get; set; }
    }
}
