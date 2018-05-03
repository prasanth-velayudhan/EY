using System;

namespace flydubai.Model.OptionalExtras.Seating
{
    using System.Collections.Generic;
    using System.Linq;

    using MS.Internal.Xml.XPath;

    using flydubai.Model.Common;
    using flydubai.Common;

    /// <summary>
    /// Seat Map Flight
    /// </summary>
    public class SeatMapFlight : ILocalTravelContext
    {
        public SeatMapFlight()
        {
            this.Surcharges = new decimal[6];
            this.Seats = new List<SeatInfo>();
        }

        public int LogicalFlightId { get; set; }

        //Added By A-5476

        //public bool IsEconomy { get; set; }

        //public bool IsBusiness { get; set; }

        //public bool IsBusinessEconomy { get; set; }

        public flydubai.Common.Enums.SeatMapTypes SeatMapType { get; set; }

        //Finish Changes - A-5476

        public DateTime DepartureDate { get; set; }

        public int PhisicalFlightId { get; set; }

        public string CurrencyCode { get; set; }

        public decimal[] Surcharges { get; set; }

        public List<SeatInfo> Seats { get; set; }

        public string OriginAirportCode { get; set; }

        public string DestinationAirportCode { get; set; }

        public bool IsReturnFlight { get; set; }

        public bool IsCircularFlight { get; set; }

        public int FlightTypeIndex { get; set; }

        public bool Unavailable
        {
            get
            {
                return this.Seats.Count(s => s.IsAvailable) == 0;
            }
        }

        public string Origin
        {
            get
            {
                return this.OriginAirportCode;
            }
        }

        public string Destination
        {
            get
            {
                return this.DestinationAirportCode;
            }
        }

        public DateTime ArrivalDate
        {
            get
            {
                // added here to satisfy ILocalTravelContext
                throw new NotSupportedException("Arrival date is not required for seat maps.");
            }
        }

        public DateTime LegDepartureDate { get; set; }

        public string FlightTailNum { get; set; }

        public string CarrierCodeFlightNumber { get; set; }

        public string FlightNum { get; set; }

        public string OperatingCarrier { get; set; }

        public string OperatingCarrierName { get; set; }

        public string MarketingCarrier { get; set; }

        public string SellingCarrier { get; set; }

        public bool isOtherAirline { get; set; }

        //code share
        public bool IsCodeshare
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(OperatingCarrier))
                {
                    if (OperatingCarrier.Trim().ToUpper() != Constants.FlydubaiCarrierCode)
                    {
                        if (!String.IsNullOrWhiteSpace(MarketingCarrier))
                        {
                            return MarketingCarrier.Trim().ToUpper() == Constants.FlydubaiCarrierCode;
                        }
                        if (!String.IsNullOrWhiteSpace(SellingCarrier))
                        {
                            return SellingCarrier.Trim().ToUpper() == Constants.FlydubaiCarrierCode;
                        }
                    }
                }
                return false;
            }
        }

        public bool IsEKStar { get; set; }
    }
}
