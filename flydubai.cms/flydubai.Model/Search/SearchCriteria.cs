namespace flydubai.Model.Search
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Search Criteria
    /// </summary>
    [Serializable]
    public class SearchCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCriteria"/> class.
        /// </summary>
        public SearchCriteria()
        {
            this.Flights = new List<FlightCriteria>();
            this.DepartureDate = new List<DateTime>();
        }

        public List<FlightCriteria> Flights { get; set; }

        public bool IsFlexible { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public int Infants { get; set; }

        public string PromoCode { get; set; }

        public bool IsOriginMetro { get; set; }//a-5477 FR-019

        public bool IsDestMetro { get; set; }//a-5477 FR-019

        public bool IsOnedayOrReturn { get; set; }

        public int BaseSegmentId { get; set; }

        public int SelectedSegmentId { get; set; }


        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public SearchCriteria Clone()
        {
            SearchCriteria newCriteria = new SearchCriteria() { Adults = this.Adults, Children = this.Children, Infants = this.Infants, IsFlexible = this.IsFlexible, PromoCode = this.PromoCode, IsDestMetro = this.IsDestMetro, IsOriginMetro = this.IsOriginMetro };//a-5477 FR-019
            newCriteria.Flights = new List<FlightCriteria>();

            if (this.Flights != null)
            {
                newCriteria.Flights = this.Flights.Select(f => new FlightCriteria()
                {
                    DepartureDate = f.DepartureDate,
                    Destination = f.Destination,
                    DestinationCity = f.DestinationCity,
                    DestinationShortLabel = f.DestinationShortLabel,
                    Origin = f.Origin,
                    OriginCity = f.OriginCity,
                    OriginShortLabel = f.OriginShortLabel,
                    SegmentId = f.SegmentId,
                    IsOriginMetroCode = f.IsOriginMetroCode,
                    IsDestinationMetroCode = f.IsDestinationMetroCode,
                    OriginAirportsUnderMetro = f.OriginAirportsUnderMetro,
                    DestinationAirportsUnderMetro = f.DestinationAirportsUnderMetro
                }).ToList();
            }

            return newCriteria;
        }

        public int NumberOfSeatsRequired
        {
            get { return this.Adults + this.Children; }
        }

        //Added by a-5616 - Platinum Mobile changes
        public string CabinType { get; set; }

        public List<DateTime> DepartureDate { get; set; }

        public bool IsMultiCity
        {
            get
            {
                return this.Flights.Count() > 2 || (this.Flights.Count() > 1
                    &&( (this.Flights[0].Origin != this.Flights[1].Destination)
                    || (this.Flights[0].Destination != this.Flights[1].Origin)));
            }
        }

    }
}
