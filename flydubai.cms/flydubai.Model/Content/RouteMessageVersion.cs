namespace flydubai.Model.Content
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Abstracts the diferrnt versions for a route message
    /// </summary>
    public class RouteMessageVersion : EntityVersionBase<RouteMessage, RouteMessageVersion>
    {
        /// <summary>
        /// Gets or sets the route message version id.
        /// </summary>
        /// <value>
        /// The route message version id.
        /// </value>
        [Key]
        public int RouteMessageVersionId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public override int Id
        {
            get { return this.RouteMessageVersionId; }
            set { this.RouteMessageVersionId = value; }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the origin airport code.
        /// </summary>
        /// <value>
        /// The origin airport code.
        /// </value>
        public string OriginAirportCode { get; set; }

        /// <summary>
        /// Gets or sets the destination airport code.
        /// </summary>
        /// <value>
        /// The destination airport code.
        /// </value>
        public string DestinationAirportCode { get; set; }

        /// <summary>
        /// Gets or sets the active period start date.
        /// </summary>
        /// <value>
        /// The active period start date.
        /// </value>
        public DateTime PublishPeriodStartDate { get; set; }

        /// <summary>
        /// Gets or sets the active period end date.
        /// </summary>
        /// <value>
        /// The active period end date.
        /// </value>
        public DateTime PublishPeriodEndDate { get; set; }

        /// <summary>
        /// Gets or sets the route date range from.
        /// </summary>
        /// <value>
        /// The route date range from.
        /// </value>
        public DateTime? RouteDateRangeFrom { get; set; }

        /// <summary>
        /// Gets or sets the route date range to.
        /// </summary>
        /// <value>
        /// The route date range to.
        /// </value>
        public DateTime? RouteDateRangeTo { get; set; }

        /// <summary>
        /// Gets or sets the affected dates.
        /// </summary>
        /// <value>
        /// The affected dates.
        /// </value>
        public string AffectedDates { get; set; }

        /// <summary>
        /// Gets or sets the flight number start range.
        /// </summary>
        /// <value>
        /// The flight number start range.
        /// </value>
        public int? FlightNumberStartRange { get; set; }

        /// <summary>
        /// Gets or sets the flight number end range.
        /// </summary>
        /// <value>
        /// The flight number end range.
        /// </value>
        public int? FlightNumberEndRange { get; set; }

        /// <summary>
        /// Gets or sets the affected flight numbers.
        /// </summary>
        /// <value>
        /// The affected flight numbers.
        /// </value>
        public string AffectedFlightNumbers { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on monday].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on monday]; otherwise, <c>false</c>.
        /// </value>
        public bool OnMonday { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on tuesday].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on tuesday]; otherwise, <c>false</c>.
        /// </value>
        public bool OnTuesday { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on wednesday].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on wednesday]; otherwise, <c>false</c>.
        /// </value>
        public bool OnWednesday { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on thursday].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on thursday]; otherwise, <c>false</c>.
        /// </value>
        public bool OnThursday { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on friday].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on friday]; otherwise, <c>false</c>.
        /// </value>
        public bool OnFriday { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on saturday].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on saturday]; otherwise, <c>false</c>.
        /// </value>
        public bool OnSaturday { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on sunday].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on sunday]; otherwise, <c>false</c>.
        /// </value>
        public bool OnSunday { get; set; }

        public int? CountryOriginId { get; set; }

        public int? CountryDestinationId { get; set; }

        public bool IsAirportPreferredForOrigin { get; set; }

        public bool IsAirportPreferredForDestination { get; set; }
    }
}
