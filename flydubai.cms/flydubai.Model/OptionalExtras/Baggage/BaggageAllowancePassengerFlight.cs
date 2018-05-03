using System;
using System.Linq;

namespace flydubai.Model.OptionalExtras.Baggage
{
    using flydubai.Common;
    using System.Collections.Generic;

    /// <summary>
    /// Baggage Allowance Passenger Flight
    /// </summary>
    public class BaggageAllowancePassengerFlight
    {
        public BaggageAllowancePassengerFlight()
        {
            this.BaggageAllowancePrices = new List<BaggageAllowancePrice>();
            this.FlightLegs = new List<BaggageAllowancePassengerFlightLeg>();
        }

        public int LFID { get; set; }

        public DateTime DepartureDate { get; set; }

        public int FareTypeId { get; set; }

        public string Cabin { get; set; }

        public List<BaggageAllowancePrice> BaggageAllowancePrices { get; set; }

        public List<BaggageAllowancePassengerFlightLeg> FlightLegs { get; set; }

        public bool IsReturnFlight { get; set; }

        public int Stops
        {
            get
            {
                return this.FlightLegs.Count - 1;
            }
        }

        public bool IsConnectionFlight { get; set; }

        //Interline changes
        public bool IsInterline
        {
            get
            {
                return FlightLegs.Any(a => a.IsOtherAirline);
            }
        }

        public int NoOfPieces { get; set; }

        //Multicity changes
        public bool IsMulticityStopoverParent { get; set; }//is the segment parent of a stopover
        public bool IsMulticityStopover { get; set; }


    }
}