namespace flydubai.Model.OptionalExtras.SSR
{
    using flydubai.Common;
    using System;

    /// <summary>
    /// TA SSR Allowance Passenger FlightLeg
    /// </summary>
    public class TASSRAllowancePassengerFlightLeg
    {
        public DateTime DepartureDate { get; set; }

        public string FlightNum { get; set; }

        public string OperatingCarrier { get; set; }

        public string OperatingCarrierName { get; set; }

        public string MarketingCarrier { get; set; }

        public string SellingCarrier { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public int PhysicalFlightId { get; set; }

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
