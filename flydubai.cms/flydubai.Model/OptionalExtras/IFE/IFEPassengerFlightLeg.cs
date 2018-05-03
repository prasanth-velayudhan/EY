namespace flydubai.Model.OptionalExtras.IFE
{
    using flydubai.Common;
    using System;

    /// <summary>
    /// IFE Passenger Flight Leg
    /// </summary>
    public class IFEPassengerFlightLeg
    {
        public DateTime DepartureDate { get; set; }

        public string FlightNum { get; set; }

        public string OperatingCarrier { get; set; }

        public string OperatingCarrierName { get; set; }

        public string MarketingCarrier { get; set; }

        public string SellingCarrier { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public int PFID { get; set; }

        public bool IFEPossible { get; set; }

        public bool IFEQuantityAvailable { get; set; }

        public bool IsBusRoute { get; set; }

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
            }
        }
    }
}