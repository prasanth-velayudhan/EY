using System;

namespace flydubai.Model.OptionalExtras.SSR
{
    using System.Collections.Generic;

    /// <summary>
    /// Baggage Allowance Passenger Flight
    /// </summary>
    public class TASSRPassengerFlight
    {
        public TASSRPassengerFlight()
        {
            this.TASSRAllowancePrices = new TASSRAllowancePrice();
            this.FlightLegs = new List<TASSRAllowancePassengerFlightLeg>();
        }

        public int LFID { get; set; }

        public DateTime DepartureDate { get; set; }

        public int FareTypeId { get; set; }

        public TASSRAllowancePrice TASSRAllowancePrices { get; set; }

        public List<TASSRAllowancePassengerFlightLeg> FlightLegs { get; set; }

        public bool IsReturnFlight { get; set; }

        public int Stops
        {
            get
            {
                return this.FlightLegs.Count - 1;
            }
        }

        public bool IsConnectionFlight { get; set; }

    }
}