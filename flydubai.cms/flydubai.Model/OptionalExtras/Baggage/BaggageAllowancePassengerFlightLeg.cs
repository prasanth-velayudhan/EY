namespace flydubai.Model.OptionalExtras.Baggage
{
    using flydubai.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Baggage Allowance Passenger Flight Leg
    /// </summary>
    public class BaggageAllowancePassengerFlightLeg
    {
        public DateTime DepartureDate { get; set; }

        public string FlightNum { get; set; }

        public string OperatingCarrier { get; set; }

        public string OperatingCarrierName { get; set; }

        public string MarketingCarrier { get; set; }

        public string SellingCarrier { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        //Interline changes
        public bool IsOtherAirline
        {
            get
            {
                return OperatingCarrier.Trim().ToUpper() != Constants.FlydubaiCarrierCode;
            }
        }

        //code share
        public bool IsCodeshare
        {
            get
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
                return false;

                //return OperatingCarrier.Trim().ToUpper() != Constants.FlydubaiCarrierCode && MarketingCarrier.Trim().ToUpper() == Constants.FlydubaiCarrierCode;
            }
        }

    }
}