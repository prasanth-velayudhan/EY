using flydubai.Common;

namespace flydubai.Model.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// flight leg
    /// </summary>
    [Serializable]
    public class Leg : ILocalTravelContext
    {
        public int PFID { get; set; }

        public DateTime DepartureDate
        {
            get;
            set;
        }

        public string DepartureTime
        {
            get
            {
                return this.DepartureDate.ToString("HH:mm");
            }
        }

        public DateTime ArrivalDate { get; set; }

        public string ArrivalTime
        {
            get
            {
                return this.ArrivalDate.ToString("HH:mm");
            }
        }

        public int FlightTime { get; set; }
        public string FlightNum { get; set; }

        private string operatingCarrier;

        public string OperatingCarrier
        {
            get
            {
                if (string.IsNullOrEmpty(this.operatingCarrier))
                {
                    return "FZ";
                }
                return this.operatingCarrier;
            }
            set
            {
                operatingCarrier = value;
            }
        }

        public string OperatingCarrierName
        {
            get
            {
                string operatingCarrierName;
                Constants.Carriers.TryGetValue(this.OperatingCarrier != null ? this.OperatingCarrier.Trim() : null, out operatingCarrierName);
                return operatingCarrierName;
            }
        }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public string FlightNumWithCarrier
        {
            get
            {
                return string.Format("{0}{1}", this.OperatingCarrier, this.FlightNum);
            }
        }

        public Leg ShallowCopy()
        {
            return (Leg)this.MemberwiseClone();
        }

        public string GetOperatingCarrierName(IEnumerable<AirlineCarrierLocalised> codes)
        {
            if (codes != null && codes.Any() && !string.IsNullOrEmpty(this.OperatingCarrier))
            {
                if (codes.Any(a => !string.IsNullOrEmpty(a.CarrierCode) && a.CarrierCode.Trim() == this.OperatingCarrier))
                    return codes.First(a => !string.IsNullOrEmpty(a.CarrierCode) && a.CarrierCode.Trim() == this.OperatingCarrier).CarrierName;
                else
                    return string.Empty;
            }
            return this.OperatingCarrierName;
        }

        //Interline changes
        public string OriginLabel { get; set; }

        public string DestinationLabel { get; set; }

        public TimeSpan Duration { get { return new TimeSpan(0, this.FlightTime, 0); } }

        public string Cabin;

        public string TempPFID;

        public bool IsOtherAirline
        {
            get
            {
                return OperatingCarrier.Trim().ToUpper() != Constants.FlydubaiCarrierCode;
            }
        }

        public bool IsCodeshare
        {
            get
            {
                return OperatingCarrier.Trim().ToUpper() != Constants.FlydubaiCarrierCode
                    && (string.IsNullOrEmpty(MarketingCarrier) || MarketingCarrier.Trim().ToUpper() == Constants.FlydubaiCarrierCode);
            }
        }

        public string FromTerminal { get; set; }

        public string ToTerminal { get; set; }

        public string MarketingCarrier { get; set; }

        public string SellingCarrier { get; set; }

        public string MarketingFlightNum { get; set; }

        public BookingCode BookingCodes { get; set; }

        public string TailImageURL { get; set; }
    }

    [Serializable]
    public class BookingCode
    {
        public string cabin { get; set; }
        public string fareClass { get; set; }
        public List<string> paxID { get; set; }
    }
}