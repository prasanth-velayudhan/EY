using System;
using System.Linq;

namespace flydubai.Model.OptionalExtras.IFE
{
    using System.Collections.Generic;
    using flydubai.Common;

    /// <summary>
    /// IFE Passenger Flight
    /// </summary>
    public class IFEPassengerFlight
    {
        public IFEPassengerFlight()
        {
            this.IFEPrices = new List<IFEPrice>();
            this.FlightLegs = new List<IFEPassengerFlightLeg>();
        }

        public int LFID { get; set; }

        public DateTime DepartureDate { get; set; }

        public int FareTypeId { get; set; }

        public string Cabin { get; set; }

        public List<IFEPrice> IFEPrices { get; set; }

        public List<IFEPassengerFlightLeg> FlightLegs { get; set; }

        public bool IsReturnFlight { get; set; }

        public int Stops
        {
            get
            {
                return this.FlightLegs.Count - 1;
            }
        }

        public bool IsConnectionFlight { get; set; }

        public bool IFEPossible { get; set; }

        public bool IFEQuantityAvailable { get; set; }  //A-5469: WR2 : FR:020

        public bool WasIfeAssingedFlight { get; set; }

        //Interline changes
        public bool IsInterline
        {
            get
            {
                return FlightLegs.Any(a => a.IsOtherAirline);
            }
        }
    }
}