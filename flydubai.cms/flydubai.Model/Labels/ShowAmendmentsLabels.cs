using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Show Amendments Labels
    /// </summary>
    public class ShowAmendmentsLabels : BaseLabels
    {
        [DefaultValue("Submits amendments and possible change in insurance")]
        public string ApplyAmendmentsAccessibilityTitleText { get; set; }

        [DefaultValue("Booking Ref")]
        public string BookingReferenceLabelText { get; set; }

        [DefaultValue("Changes are highlighted below and are not guaranteed until applied.")]
        public string ChangesAreHighlightedBelowText { get; set; }

        [DefaultValue("Fare")]
        public string FareLabelText { get; set; }

        [DefaultValue("Taxes")]
        public string TaxesLabelText { get; set; }

        [DefaultValue("Services")]
        public string ServicesSectionLabelText { get; set; }

        [DefaultValue("Baggage")]
        public string BaggageLabelText { get; set; }

        [DefaultValue("Seating total")]
        public string SeatingTotalLabelText { get; set; }

        [DefaultValue("Non-refundable")]
        public string NonRefundableLabelText { get; set; }

        [DefaultValue("Insurance")]
        public string InsuranceLabelText { get; set; }

        [DefaultValue("Penalty")]
        public string PenaltyLabelText { get; set; }

        [DefaultValue("Total")]
        public string TotalLabelText { get; set; }

        [DefaultValue("Excluding credit/debit fee")]
        public string ExcludingCreditDebitFeeLabelText { get; set; }

        [DefaultValue("Additional payment")]
        public string AdditionalPaymentLabelText { get; set; }

        [DefaultValue("Total refund")]
        public string TotalRefundLabelText { get; set; }

        [DefaultValue("Apply Amendments")]
        public string ApplyAmendmentsButton { get; set; }

        [DefaultValue("Cancel Amendments")]
        public string CancelAmendmentsButton { get; set; }

        [DefaultValue("Journey {0} {1} to {2}")]
        [DisplayName("Journey origin to destination heading text (use {0} for journey number, {1} for origin, {2} for destination) (e.g. Journey {0} {1} to {2})")]
        public string JourneyOriginDestinationHeadingText { get; set; }

        [DefaultValue("Depart")]
        public string DepartureDateLabelText { get; set; }

        [DefaultValue("Previous Flight")]
        public string PreviousFlightLabelText { get; set; }

        [DefaultValue("Changed to")]
        public string FlightChangedToLabelText { get; set; }

        [DefaultValue("Flight No.")]
        public string FlightNumberColumnHeading { get; set; }

        [DefaultValue("Departing")]
        public string DepartingColumnHeading { get; set; }

        [DefaultValue("Arrival")]
        public string ArrivalColumnHeading { get; set; }

        [DefaultValue("Duration")]
        public string DurationColumnHeading { get; set; }

        [DefaultValue("Passengers")]
        public string PassengersColumnHeading { get; set; }

        [DefaultValue("Fare type")]
        public string FareTypeColumnHeading { get; set; }

        [DefaultValue("Baggage")]
        public string BaggageColumnHeading { get; set; }

        [DefaultValue("Seat")]
        public string SeatColumnHeading { get; set; }

        [DefaultValue("Extra")]
        public string ExtraColumnHeading { get; set; }

        [DefaultValue("Taxes")]
        public string TaxesColumnHeading { get; set; }

        [DefaultValue("Sub total")]
        public string SubTotalColumnHeading { get; set; }

        [DefaultValue("kg hand baggage")]
        public string KgHandBaggageSuffix { get; set; }

        [DefaultValue("kg checked baggage")]
        public string KgCheckedBaggageSuffix { get; set; }

        [DefaultValue("Ref")]
        public string InsuranceRefLabelText { get; set; }

        [DefaultValue("Based on 24 hour clock. All times shown are local.")]
        public string BasedOn24HourClockText { get; set; }

        [DefaultValue("Journey total")]
        public string JourneyTotalLabelText { get; set; }

        [DefaultValue("Inclusive of all taxes")]
        public string InclusiveOfTaxesText { get; set; }

        public string InFlightEntertainmentLabelText { get; set; }

        public string OptionalExtras { get; set; }
        //Pre-sell meals a-5466
        public string Meals { get; set; }
        public string Insurance { get; set; }

        // A-5446 WR7 - GDS Booking
        [DefaultValue("Cabin Class")]
        public string CabinClass { get; set; }

        public string AdditionalPaymentNotification { get; set; }

        public string Flight { get; set; }

    }
}
