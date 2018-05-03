using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.ReAccommodation
{
    [Serializable]
    public class ReaccommodationFlightRS
    {
        [Serializable]
        public class ReaccommodationAvailRS
        {
            public AvailResponse availResponse { get; set; }
        }

        [Serializable]
        public class AvailResponse
        {
            public List<OriginDestination> originDestination { get; set; }
        }

        [Serializable]
        public class OriginDestination
        {
            public int ID { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public List<FlightGroup> flightGroups { get; set; }
        }

        [Serializable]
        public class FlightGroup
        {
            public int ID { get; set; }
            public string flightTime { get; set; }
            public bool economyAvailable { get; set; }
            public bool businessAvailable { get; set; }
            public List<Flight> flights { get; set; }
        }

        [Serializable]
        public class Flight
        {
            public int ID { get; set; }
            public MrktFlight mrktFlight { get; set; }
            public OperFlight operFlight { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public DateTime depDateTime { get; set; }
            public DateTime arrDateTime { get; set; }
            public List<Inventory> inventory { get; set; }
        }

        [Serializable]
        public class Inventory
        {
            public string A { get; set; }
        }

        [Serializable]
        public class OperFlight
        {
            public string carrier { get; set; }
            public string flightNum { get; set; }
        }

        [Serializable]
        public class MrktFlight
        {
            public string carrier { get; set; }
            public string flightNum { get; set; }
        }
    }
}
