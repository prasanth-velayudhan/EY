using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class PhysicalFlight
    {
        public string Key { get; set; }
        public int RecordNumber { get; set; }
        public string DestinationDefaultTerminal { get; set; }
        public int PhysicalFlightID { get; set; }
        public int LogicalFlightID { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierName { get; set; }
        public string FlightNumber { get; set; }
        public int FlightOrder { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string OriginDefaultTerminal { get; set; }
        public string OriginName { get; set; }
        public string Destination { get; set; }
        public string DestinationName { get; set; }
        public string OriginMetroGroup { get; set; }
        public string DestinationMetroGroup { get; set; }
        public string SellingCarrier { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal FlightDuration { get; set; }
        public int Trip { get; set; }
        public string Gate { get; set; }
        public decimal TotalWeight { get; set; }
        public int UIDisplayValue { get; set; }
        public bool Active { get; set; }
        public List<Customer> Customers { get; set; }
        public string FromTerminal { get; set; }
        public string ToTerminal { get; set; }
        public string AirCraftType { get; set; }
        public string AirCraftDescription { get; set; }
        public DateTime Arrivaltime { get; set; }
        public string FlightStatus { get; set; }
        public bool ReaccomChangeAlert { get; set; } 
        public string MarketingCarrier { get; set; }
        public string MarketingFlightNum { get; set; } 
    }
}
