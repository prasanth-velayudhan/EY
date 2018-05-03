using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model.Booking;
namespace flydubai.Model.ReAccommodation
{
    [Serializable]
    public class ReaccFlight
    {
        public string Key { get; set; }

        public string Currency { get; set; }

        public string PNR { get; set; }

        public string IATANum { get; set; }

        public int LogicalFlightId { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }

        public List<ReaccFlightLeg> ReaccFlightLeg { get; set; }

        public List<LogicalFlight> logicalFlight { get; set; }
    }

    public class ReaccFlightLeg
    {
        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string FlightNumber { get; set; }

        public string SegmentID { get; set; }

        //public string OdID { get; set; }

        public string MarketingCarrier { get; set; }

        public string MarketingFlightNumber { get; set; }

        public string OperatingCarrier { get; set; }

        public string OperatingFlightNumber { get; set; }
    }

    [Serializable]
    public class ReaccModifyFlight
    {
        public string Key { get; set; }

        public string PNR { get; set; }

        public string IATANum { get; set; }

        public string Currency { get; set; }

        public string OperatingCarrier { get; set; }

        public List<flydubai.Model.Journey.JourneyPassenger> JourneyPassengers { get; set; }
    }

}
