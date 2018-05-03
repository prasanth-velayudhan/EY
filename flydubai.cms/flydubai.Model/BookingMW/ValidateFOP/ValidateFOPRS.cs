using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.ValidateFOP
{
    public class ValidateFOPRS
    {
        public Viewvoucher viewvoucher { get; set; }
        public ViewPoints viewPoints { get; set; }
        public PNRPaymentDetails pnrPaymentDetails { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class Viewvoucher
    {
        public List<Voucher1> Vouchers { get; set; }
        public List<Exception> Exceptions { get; set; }
    }

    public class ViewPoints
    {
        public string AccountNumber { get; set; }
        public string ReservationCurrency { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal ReservationAmount { get; set; }
        public decimal BalanceAmountAfterDeduction { get; set; }
        public double ExchangeRate { get; set; }
        public List<OrderAccrual> orderAccruals { get; set; }
    }

    public class Voucher1
    {
        public string VoucherNumber { get; set; }
        public string VoucherFullNumber { get; set; }
        public string VoucherPassword { get; set; }
        public int PersonOrgID { get; set; }
        public string SeriesNumber { get; set; }
        public string ConfirmationNumber { get; set; }
        public int RecordNumber { get; set; }
        public string Sponsor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VoucherCurrency { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public int NonTransferable { get; set; }
        public int VoucherType { get; set; }
        public int TripType { get; set; }
        public int IncludeTaxes { get; set; }
        public int IncludeSSR { get; set; }
        public int IncludeAuto { get; set; }
        public int IncludePenalty { get; set; }
        public int SundayRestrict { get; set; }
        public int MondayRestrict { get; set; }
        public int TuesdayRestrict { get; set; }
        public int WednesdayRestrict { get; set; }
        public int ThursdayRestrict { get; set; }
        public int FridayRestrict { get; set; }
        public int SaturdayRestrict { get; set; }
        public DateTime StartTimeRestrict { get; set; }
        public DateTime EndTimeRestrict { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ReasonCode { get; set; }
        public bool NotFound { get; set; }
        public decimal BalanceAmountAfterDeduction { get; set; }
        public decimal ReservationBalance { get; set; }
    }

    public class OrderAccrual
    {
        public string chargeId { get; set; }
        public int BaseRewards { get; set; }
        public int BonusRewards { get; set; }
        public int BaseTier { get; set; }
        public int BonusTier { get; set; }
    }
}