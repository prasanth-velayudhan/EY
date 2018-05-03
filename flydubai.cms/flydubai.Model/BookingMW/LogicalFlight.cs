using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class LogicalFlight
    {
        public string Key { get; set; }
        public string FlightGroupId { get; set; }
        public int RecordNumber { get; set; }
        public int LogicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string OriginDefaultTerminal { get; set; }
        public string OriginName { get; set; }
        public string Destination { get; set; }
        public string DestinationDefaultTerminal { get; set; }
        public string DestinationName { get; set; }
        public string OriginMetroGroup { get; set; }
        public string DestinationMetroGroup { get; set; }
        public string SellingCarrier { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public int PackageItemID { get; set; }
        public string PackageItemName { get; set; }
        public string PackageItemDescription { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public bool Active { get; set; }
        public string VendorDescription { get; set; }
        public int UIDisplayValue { get; set; }
        public List<PhysicalFlight> PhysicalFlights { get; set; }
        public DateTime Arrivaltime { get; set; }
        public DateTime PackageItemBookDate { get; set; }
        public DateTime PackageItemStartDate { get; set; }
        public DateTime PackageItemEndDate { get; set; }
    }
}
