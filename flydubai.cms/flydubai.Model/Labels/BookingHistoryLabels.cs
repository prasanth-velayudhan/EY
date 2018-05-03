using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Booking History Labels
    /// </summary>
    public class BookingHistoryLabels : BaseLabels
    {
        [DefaultValue("Your active bookings")]
        public string ActiveBookingsModuleTitle { get; set; }

        [DefaultValue("Please note")]
        public string ActiveBookingsPleaseNote { get; set; }

        [DefaultValue("{0} is due to expire on {1} at {2} ({3}) if no payment is received.")]
        [DisplayName("Active booking due to expire message (use {0} for booking reference, {1} for expiry date, {2} for expiry time, {3} for departure airport code) (e.g. {0} is due to expire on {1} at {2} ({3}) if no payment is received.)")]
        public string ActiveBookingsDueToExpire { get; set; }

        [DefaultValue("Booking reference")]
        public string Reference { get; set; }

        [DefaultValue("Primary passenger last name")]
        public string PrimaryPassengerLastName { get; set; }

        [DefaultValue("No. of passengers")]
        public string NumberOfPassengers { get; set; }

        [DefaultValue("Route")]
        public string Route { get; set; }

        [DefaultValue("Booking date")]
        public string BookingDate { get; set; }

        [DefaultValue("Departure date")]
        public string DepartureDate { get; set; }

        [DefaultValue("Type")]
        public string Type { get; set; }

        [DefaultValue("View full booking history")]
        public string ViewFullHistory { get; set; }

        [DefaultValue("Booking history")]
        public string BookingHistoryModuleTitle { get; set; }

        [DefaultValue("Only show me")]
        public string BookingHistoryOnlyShowMe { get; set; }

        [DefaultValue("Update")]
        public string BookingHistoryUpdateFilter { get; set; }

        [DefaultValue("Sort by")]
        public string BookingHistorySortBy { get; set; }

        [DefaultValue("Viewing {0}-{1} of {2} results")]
        [DisplayName("Pagination text (use {0} for start of current page, {1} for end of current page, {2} for total results) (e.g. Viewing {0}-{1} of {2} results)")]
        public string BookingHistoryResultsDisplayed { get; set; }

        [DefaultValue("View booking")]
        public string ViewBookingModuleTitle { get; set; }

        [DefaultValue("Primary passenger last name:")]
        public string ViewBookingPrimaryPassengerLastName { get; set; }

        [DefaultValue("Booking reference:")]
        public string ViewBookingReference { get; set; }

        [DefaultValue("Get booking")]
        public string ViewBookingSubmit { get; set; }

        [DefaultValue("No bookings")]
        public string NoBookings { get; set; }

        [DefaultValue("Next")]
        public string PaginationNext { get; set; }

        [DefaultValue("Previous")]
        public string PaginationPrevious { get; set; }

        [DefaultValue("All bookings")]
        public string FilterAll { get; set; }

        [DefaultValue("Confirmed")]
        public string FilterConfirmed { get; set; }

        [DefaultValue("Payment outstanding")]
        public string FilterPaymentOutstanding { get; set; }

        [DefaultValue("Expired/cancelled")]
        public string FilterExpiredCancelled { get; set; }

        [DefaultValue("Journey completed")]
        public string FilterCompleted { get; set; }

        [DefaultValue("Booking ref")]
        public string SortBookingRef { get; set; }

        [DefaultValue("Booking date")]
        public string SortBookingDate { get; set; }

        [DefaultValue("Departure date")]
        public string SortDepartureDate { get; set; }
    }
}
