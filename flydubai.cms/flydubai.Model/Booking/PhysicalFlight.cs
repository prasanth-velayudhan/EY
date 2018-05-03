namespace flydubai.Model.Booking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using flydubai.Common;
    using flydubai.Model.Common;

    /// <summary>
    /// PhysicalFlight
    /// </summary>
    [Serializable]
    public class PhysicalFlight : ILocalTravelContext
    {
        public PhysicalFlight()
        {
            this.Customers = new List<Customer>();
        }

        public string Key { get; set; }

        public int PhysicalFlightId { get; set; }

        public string CarrierCode { get; set; }

        public string OperatingCarrier { get; set; }

        public string SellingCarrier { get; set; }

        public string FlightNumber { get; set; }

        public decimal FlightDurationInSeconds { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public IEnumerable<string> FareBasisCodes
        { 
            get
            {
                return from c in this.Customers
                       from ap in c.AirlinePersons
                       where c != null && ap != null && !string.IsNullOrWhiteSpace(ap.FareBasisCode) && ap.IsActive
                       select ap.FareBasisCode;
            }
        }

        public DateTime DepartureDate
        {
            get
            {
                return this.DepartureTime;
            }
        }

        public DateTime ArrivalDate
        {
            get
            {
                return this.ArrivalTime;
            }
        }

        public List<Customer> Customers { get; set; }

        public string OperatingCarrierName
        {
            get
            { 
                string operatingCarrierName;
                if (string.IsNullOrEmpty(this.OperatingCarrier))
                {
                    Constants.Carriers.TryGetValue(this.CarrierCode.Trim(), out operatingCarrierName);
                }
                else
                {
                    Constants.Carriers.TryGetValue(this.OperatingCarrier.Trim(), out operatingCarrierName);
                }
                
                return operatingCarrierName;
            }
        }

        public string CarrierCodeFlightNumber
        {
            get
            {
                return string.Format("{0}-{1}", this.CarrierCode.Trim(), this.FlightNumber);
            }
        }

        //Leg level SSR changes
        public bool IFEPossible { get; set; }
        public bool MealsIncluded { get; set; }
        public bool BusinessMealsIncluded { get; set; } 

        public bool Active { get; set; }
        public string FlightStatus { get; set; }
        public bool ReaccomChangeAlert { get; set; }  


        public string GetOperatingCarrierName(IEnumerable<AirlineCarrierLocalised> codes)
        {
            if (codes != null && codes.Any() && !string.IsNullOrEmpty(this.OperatingCarrier))
            {
                if (codes.Any(a => !string.IsNullOrEmpty(a.CarrierCode) && a.CarrierCode.Trim() == this.OperatingCarrier.Trim()))
                    return codes.First(a => !string.IsNullOrEmpty(a.CarrierCode) && a.CarrierCode.Trim() == this.OperatingCarrier.Trim()).CarrierName;
                else
                    return string.Empty;
            }
            return this.OperatingCarrierName;
        }

        //Interline changes

        public string MarketingCarrier { get; set; }

        public string MarketingFlightNum { get; set; } 

        public bool IsOtherAirline
        {
            get
            {
                return OperatingCarrier.Trim().ToUpper() != Constants.FlydubaiCarrierCode;
            }
        }
    }
}