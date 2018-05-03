using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.PricingMW
{
    public class MultiCityFareQuoteRQ
    {
        public FareQuoteRequest fareQuoteRequest { get; set; }
    }

    public class Passenger
    {
        public int passengerID { get; set; }
        public int PTCID { get; set; }
        public string DOB { get; set; }
    }

    public class Passengers
    {
        public List<Passenger> passenger { get; set; }
    }

    public class FlightInfo
    {
        public string carrierCode { get; set; }
        public string flightNum { get; set; }
    }

    public class LegDetail
    {
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime depDateTime { get; set; }
        public FlightInfo marketingFlt { get; set; }
        public FlightInfo operatingFlt { get; set; }
    }

    public class LegDetails
    {
        public List<LegDetail> legDetail { get; set; }
    }

    public class Fare
    {
        public List<int> pax { get; set; }
        public string cabin { get; set; }
    }

    public class PaxFareDetails
    {
        public List<Fare> fare { get; set; }
    }

    public class OrigDest
    {
        public int id { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime depDateTime { get; set; }
        public DateTime arrivalTime { get; set; }
        public LegDetails legDetails { get; set; }
        public PaxFareDetails paxFareDetails { get; set; }
    }

    public class OriginDestinations
    {
        public List<OrigDest> originDestination { get; set; }
    }

    public class FareQuoteRequest
    {
        public string GUID { get; set; }
        public string bookingIATA { get; set; }
        public string bookingCountryCode { get; set; }
        public string pointOfSale { get; set; }
        public string bookingCurrency { get; set; }
        public string channel { get; set; }
        public string subChannel { get; set; }
        public Passengers passengers { get; set; }
        public OriginDestinations originDestinations { get; set; }
        public string promoCode { get; set; }
    }    
}
