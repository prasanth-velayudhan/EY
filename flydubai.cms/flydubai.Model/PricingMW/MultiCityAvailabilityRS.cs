using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.PricingMW
{
    public class MultiCityAvailabilityRS
    {
        public AvailResponse availResponse { get; set; }
    }

    public class HiddenStops
    {
        public int count { get; set; }
        public List<object> stopDetails { get; set; }
        public List<string> location { get; set; }
    }

    public class Inventory
    {
        public string J { get; set; }
        public string C { get; set; }
        public string Z { get; set; }
        public string D { get; set; }
        public string Y { get; set; }
        public string A { get; set; }
        public string I { get; set; }
        public string E { get; set; }
        public string O { get; set; }
        public string W { get; set; }
        public string T { get; set; }
        public string M { get; set; }
        public string N { get; set; }
        public string R { get; set; }
        public string B { get; set; }
        public string U { get; set; }
        public string K { get; set; }
        public string Q { get; set; }
        public string L { get; set; }
        public string V { get; set; }
        public string G { get; set; }
        public string S { get; set; }
        public string X { get; set; }
    }

    public class FlightInformation
    {
        public string carrier { get; set; }
        public string flightNum { get; set; }
    }

    public class Flight
    {
        public int ID { get; set; }
        public FlightInformation mrktFlight { get; set; }
        public FlightInformation operFlight { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime depDateTime { get; set; }
        public string EQP { get; set; }
        public HiddenStops hiddenStops { get; set; }
        public DateTime arrDateTime { get; set; }
        public List<Inventory> inventory { get; set; }
        public int flightTime { get; set; }
    }

    public class FlightGroup
    {
        public int ID { get; set; }
        public int flightTime { get; set; }
        public bool economyAvailable { get; set; }
        public bool businessAvailable { get; set; }
        public List<Flight> flights { get; set; }
    }

    public class OD
    {
        public int ID { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public List<FlightGroup> flightGroups { get; set; }
    }

    public class AvailResponse
    {
        public List<OD> originDestination { get; set; }
    }
}
