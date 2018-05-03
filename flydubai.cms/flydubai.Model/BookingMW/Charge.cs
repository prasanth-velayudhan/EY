using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class Charge
    {
        public string Key { get; set; }
        public int OriginalChargeID { get; set; }
        public string CodeType { get; set; }
        public string RefundType { get; set; }
        public string CurrencyCode { get; set; }
        public string OriginalCurrency { get; set; }
        public int RecordNumber { get; set; }
        public int VoucherNumber { get; set; }
        public DateTime BillDate { get; set; }
        public int TaxID { get; set; }
        public string ChargeComment { get; set; }
        public decimal Amount { get; set; }
        public int ChargeStatus { get; set; }
        public int IsRefundable { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal OriginalAmount { get; set; }
        public string Description { get; set; }
        public int StatusReasonID { get; set; }
        public bool IsSSR { get; set; }
        public int PaymentNumber { get; set; }
        public int TaxChargeID { get; set; }
        public decimal Commission { get; set; }
        public int ResChannelId { get; set; }
        public bool Bundled { get; set; }
        public bool TaxIsRefundable { get; set; }
        public bool TaxIsCommissionable { get; set; }
        public bool ServiceIsRefundable { get; set; }
        public bool ServiceIsCommissionable { get; set; }
        public List<ReservationPaymentMap> ReservationPaymentMaps { get; set; }
        public int PenaltyChargeID { get; set; }
        public int PenaltyTypeID { get; set; }
        public int BoardingPassSsrOrder { get; set; }
        public Nullable<int> PhysicalFlightID { get; set; }
        public string ExtPenaltyRule { get; set; }
        public string Discount { get; set; }
        public string TaxCode { get; set; }
        public int BasePoints { get; set; }
        public int TierPoints { get; set; }
        public int BonusPoints { get; set; }
        public int BonusTierPoints { get; set; }
        public int MilesActive { get; set; }
        public DateTime ExchangeRateDate { get; set; }        
    }
}
