using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model.Search
{
    [Serializable]
    public class SearchCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCriteria"/> class.
        /// </summary>
        public SearchCriteria()
        {
            this.Flights = new List<FlightCriteria>();
        }

        public List<FlightCriteria> Flights { get; set; }

        public bool IsFlexible { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public int Infants { get; set; }

        public string PromoCode { get; set; }

        public string Variant { get; set; }

        public string CurrencyCode { get; set; }

        //public bool IsOriginMetro { get; set; }

        //public bool IsDestMetro { get; set; }        

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public SearchCriteria Clone()
        {
            //SearchCriteria newCriteria = new SearchCriteria() { Adults = this.Adults, Children = this.Children, Infants = this.Infants, IsFlexible = this.IsFlexible, PromoCode = this.PromoCode, IsDestMetro = this.IsDestMetro, IsOriginMetro = this.IsOriginMetro };
            SearchCriteria newCriteria = new SearchCriteria() { Adults = this.Adults, Children = this.Children, Infants = this.Infants, IsFlexible = this.IsFlexible, PromoCode = this.PromoCode };
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
                    //IsOriginMetroCode = f.IsOriginMetroCode,
                    //IsDestinationMetroCode = f.IsDestinationMetroCode,
                    //OriginAirportsUnderMetro = f.OriginAirportsUnderMetro,
                    //DestinationAirportsUnderMetro = f.DestinationAirportsUnderMetro
                }).ToList();
            }

            return newCriteria;
        }

        public int NumberOfSeatsRequired
        {
            get { return this.Adults + this.Children; }
        }
        
        public string CabinType { get; set; }
    }

    public class FlightCriteria
    {

        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDate { get; set; }

        public string OriginCity { get; set; }

        public string DestinationCity { get; set; }

        public string OriginShortLabel { get; set; }

        public string DestinationShortLabel { get; set; }

        public int SegmentId { get; set; }

        public bool SearchedNextAvailableDate { get; set; }
        //public bool? IsOriginMetroCode { get; set; }
        //public bool? IsDestinationMetroCode { get; set; }        
        //public List<string> OriginAirportsUnderMetro { get; set; }
        //public List<string> DestinationAirportsUnderMetro { get; set; }

        public string FlightDirection { get; set; }
    }

    public enum Direction
    {
        outBound, inBound
    }
}
