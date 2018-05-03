﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.PricingMW
{
    public class MultiCityAvailabilityRQ
    {
        public AvailRequest availRequest { get; set; }
    }

    public class PointOfSale
    {
        public string country { get; set; }
    }

    public class RequestorDetails
    {
        public string channel { get; set; }
        public PointOfSale pointOfSale { get; set; }
    }

    public class Pax
    {
        public string type { get; set; }
        public int count { get; set; }
    }

    public class PassengerDetails
    {
        public List<Pax> pax { get; set; }
    }

    public class DepartureDateRange
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }

    public class OriginDestination
    {
        public string ID { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string originAirport { get; set; }
        public string destinationAirport { get; set; }
        public DepartureDateRange departureDateRange { get; set; }
        public List<string> carriers { get; set; }
    }

    public class JourneyData
    {
        public List<OriginDestination> originDestination { get; set; }
    }

    public class AvailRequest
    {
        public RequestorDetails requestorDetails { get; set; }
        public PassengerDetails passengerDetails { get; set; }
        public JourneyData journeyData { get; set; }
    }
}
