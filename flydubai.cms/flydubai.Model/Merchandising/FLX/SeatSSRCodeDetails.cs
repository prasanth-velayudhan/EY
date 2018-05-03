using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Merchandising.FLX
{
    public class SeatSSRCodeDetails
    {
        public Enums.SeatSSRCode SeatSSRCode { get; set; }
        public string SSRCode { get; set; }
        public string CID { get; set; }
        public string CategoryId { get; set; }
        public int PhysicalFlightId { get; set; }
        public int LogicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string PaxID { get; set; }
        public string DescriptionOptionalOffer { get; set; }
        public string DescriptionDetailsFromFlx { get; set; }
        public string AdditionalInfo { get; set; }
        public double AmountInRequestedCurrency { get; set; }
        public double FilledCurrencyInFlx { get; set; }
        public double AmountInFilledCurrency { get; set; }
        public double ExchangeRate { get; set; }
        public double ExchangeRateType { get; set; }
        public string IsSeatSSR { get; set; }
        public List<SeatSeatDetails> SeatSeatDetails { get; set; }

    }
}
