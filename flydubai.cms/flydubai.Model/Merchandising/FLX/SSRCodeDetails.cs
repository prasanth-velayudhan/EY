using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Merchandising.FLX
{
    //Optimizing Classes A-5446
    public class SSRCodeDetails
    {
        public Enums.SeatSSRCode SeatSSRCode { get; set; }
        public string SSRCode { get; set; }
        public string CID { get; set; }
        public string CategoryId { get; set; }
        public int LogicalFlightID { get; set; }//LFID on which SSR was applied
        public int PaxID { get; set; }
        public string DescriptionOptionalOffer { get; set; }//Description of optional offer from flx
        public string DescriptionDetailsFromFlx { get; set; }//Description Details from flx
        public string AdditionalInfo { get; set; }
        public double AmountInRequestedCurrency { get; set; }
        public double FilledCurrencyInFlx { get; set; }
        public double AmountInFilledCurrency { get; set; }
        public double ExchangeRate { get; set; }
        public string ExchangeRateType { get; set; }
        public bool IsSeatSSR { get; set; }
        public DiagnosticDetals DiagnosticDetails { get; set; }
        public string PassengerType { get; set; }
        public DateTime DPD { get; set; }

        //Extra Seat Nodes
        public List<SeatSeatDetails> SeatSeatDetails { get; set; }
        public DateTime DepartureDate { get; set; }
        public int PhysicalFlightId { get; set; }
        public bool DFT { get; set; }
    }
}
