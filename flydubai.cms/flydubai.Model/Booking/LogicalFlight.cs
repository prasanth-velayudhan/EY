using flydubai.Common;
using flydubai.Model.Common;
using flydubai.Model.Journey;

namespace flydubai.Model.Booking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Configuration;

    /// <summary>
    /// Logical Flight
    /// </summary>
    [Serializable]
    public class LogicalFlight : ILocalTravelContext
    {
        public LogicalFlight()
        { 
            this.PhysicalFlights = new List<PhysicalFlight>();
            IFEPossible = true;
            IFEQuantityAvail = 0;
        }

        public string Key { get; set; }

        public int LogicalFlightId { get; set; }

        public bool MealPossible { get; set; }

        public bool MealsIncluded { get; set; }

        public bool IFEPossible { get; set; }

        public int IFEQuantityAvail { get; set; }

        private List<PhysicalFlight> _physicalFlights;

        public string OperatingCarrier { get; set; }

        public string SellingCarrier { get; set; }

        public List<PhysicalFlight> PhysicalFlights
        { 
            get { return _physicalFlights; }
            set { _physicalFlights = (value == null ? null : value.OrderBy(p => p.DepartureTime).ToList()); }
        }

        public bool IsActive
        {
            get
            {
                if (this.PhysicalFlights.Any(pf => pf.IsOtherAirline))
                {
                    return this.PhysicalFlights.All(pf => pf.Customers.First().AirlinePersons.Any(ap => ap.IsActive));
                }
                else
                {
                    return this.PhysicalFlights.Any(pf => pf.Customers.First().AirlinePersons.Any(ap => ap.IsActive));
                }
            }
        }

        public string Origin
        {
            get
            {
                return this.PhysicalFlights.OrderBy(p => p.DepartureDate).First().Origin;
            }
        }

        public DateTime DepartureDate
        {
            get
            {
                return this.PhysicalFlights.OrderBy(p => p.DepartureDate).First().DepartureTime;
            }
        }

        public DateTime FZDepartureDate
        {
            get
            {
                return this.PhysicalFlights.Any(x => !x.IsOtherAirline) ? this.PhysicalFlights.OrderBy(p => p.DepartureDate).FirstOrDefault(x => !x.IsOtherAirline).DepartureTime : this.PhysicalFlights.OrderBy(p => p.DepartureDate).FirstOrDefault().DepartureTime;
            }
        }

        public string Destination
        {
            get
            {
                return this.PhysicalFlights.OrderBy(p => p.DepartureDate).Last().Destination;
            }
        }

        public DateTime ArrivalDate
        {
            get
            {
                return this.PhysicalFlights.OrderBy(p => p.DepartureDate).Last().ArrivalTime;
            }
        }

        public IEnumerable<string> FareBasisCodes
        {
            get
            {
                return this.PhysicalFlights.SelectMany(x => x.FareBasisCodes).Distinct();
            }    
        }

        public bool IsCancelled
        {
            get
            {
                var airlinePersons = (from p in this.PhysicalFlights from c in p.Customers from a in c.AirlinePersons select a).ToList();

                return airlinePersons.All(x => x.ResSegStatus == 0);
            }
        }

        /// <summary>
        /// Toes the journey flight.
        /// </summary>
        /// <param name="segmentId">The segment id.</param>
        /// <returns></returns>
        public JourneyFlight ToJourneyFlight(int segmentId)
        {
            return new JourneyFlight(segmentId)
                {
                   LFID = this.LogicalFlightId,
                   Legs = this.PhysicalFlights.Select(pf => new Leg
                       {
                           ArrivalDate = pf.ArrivalTime,
                           DepartureDate = pf.DepartureTime,
                           Origin = pf.Origin,
                           Destination = pf.Destination,
                           FlightNum = pf.FlightNumber,
                           FlightTime = (int)(pf.FlightDurationInSeconds * 60),
                           OperatingCarrier = pf.OperatingCarrier,
                           PFID = pf.PhysicalFlightId
                       }).ToList(),
                   LogicalFlightKey = this.Key
                };
        }

        public int NumberOfActiveAdultPassengers
        {
            get
            {
                return this.PhysicalFlights.OrderBy(p => p.DepartureDate).First().Customers.First().AirlinePersons
                            .Where(ap => ap.IsActive && ap.PassengerType == Enums.PassengerTypes.Adult)
                            .Count();
            }
        }

        public bool ContainsCircularFlight
        {
            get
            {
                var uniqueFlightNumbers = this.PhysicalFlights.Select(x => x.FlightNumber).Distinct();

                return this.PhysicalFlights.Count() > 1 && this.PhysicalFlights.Count() > uniqueFlightNumbers.Count();
            }
        }

        public bool IsConnectingFlight
        {
            get
            {
                var firstLeg = this.PhysicalFlights.First();

                return this.PhysicalFlights.Count() > 1 && !this.PhysicalFlights.All(x => x.FlightNumber == firstLeg.FlightNumber);
            }
        }

        //GDS
        public bool IsBusinessClass
        {
            get
            {
                var airlinepersons = this.PhysicalFlights.Any(x => !x.IsOtherAirline) ? this.PhysicalFlights.First(x => !x.IsOtherAirline).Customers.First().AirlinePersons.Where(y => y.IsActive) : this.PhysicalFlights.First().Customers.First().AirlinePersons.Where(y => y.IsActive);
                return airlinepersons.Any(x => x.Cabin.Trim().ToUpper()==Constants.BusinessCabin);
                //string[] businessfarebasis = ConfigurationManager.AppSettings["BusinessFareBasis"].Split(',');
                //return airlinepersons.Any(x => businessfarebasis.Contains(x.FareBasisCode.Substring(0, 1)));
            }
        }

        //Interline changes
        public bool IsInterline
        {
            get
            {
                return this.PhysicalFlights.Any(pf => pf.MarketingCarrier != Constants.FlydubaiCarrierCode);
            }
        }

        public string FlightGroupId { get; set; }
    }
}
