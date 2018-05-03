using flydubai.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.SummaryPnr
{
    public class SummaryPnrRQ : TransactionInfo
    {
        public string ActionType { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public string SecurityToken { get; set; }
        public string CarrierCurrency { get; set; }
        public Enums.EnumerationsCurrencyCodeTypes CarrierCurrency_Enum { get; set; }
        public string DisplayCurrency { get; set; }
        public Enums.EnumerationsCurrencyCodeTypes DisplayCurrency_Enum { get; set; }
        public string IATANum { get; set; }
        public string User { get; set; }
        public string ReceiptLanguageID { get; set; }
        public string PromoCode { get; set; }
        public string ExternalBookingID { get; set; }
        public Address Address { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }
        public List<Person> Passengers { get; set; }
        public List<Segment> Segments { get; set; }
        public List<Payment> Payments { get; set; }
        public string Comment { get; set; }
        public string SeriesNumber { get; set; }
        public string ConfirmationNumber { get; set; }
    }  

    public class Segment
    {
        public int PersonOrgID { get; set; }
        public int FareInformationID { get; set; }
        public string MarketingCode { get; set; }
        public string StoreFrontID { get; set; }
        public string RecordLocator { get; set; }
        public List<SpecialService> SpecialServices { get; set; }
        public List<Seat> Seats { get; set; }
    }

    public class SpecialService
    {
        public int ServiceID { get; set; }
        public string CodeType { get; set; }
        public int SSRCategory { get; set; }
        public int LogicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime DepartureDate_DT
        { get { return Convert.ToDateTime(DepartureDate); } }
        public decimal Amount { get; set; }
        public bool OverrideAmount { get; set; }
        public string CurrencyCode { get; set; }
        //public Enums.EnumerationsCurrencyCodeTypes CurrencyCode_Enum
        //{
        //    get { return (Enums.EnumerationsCurrencyCodeTypes)Enum.Parse(typeof(Enums.EnumerationsCurrencyCodeTypes), CurrencyCode); }
        //}
        public bool Commissionable { get; set; }
        public bool Refundable { get; set; }
        public string ChargeComment { get; set; }
        public int PersonOrgID { get; set; }
        public bool AlreadyAdded { get; set; }
        public int? PhysicalFlightID { get; set; }
        public string OverrideAmtReason { get; set; }
        public string ExtPenaltyRule { get; set; }
        public string ExtIsRePriceFixed;
        public string ExtRePriceSourceName;
        public string ExtRePriceValue;
        public string ExtRePriceValueReason;
    }

    public enum ActionTypes : int
    { GetSummary = 0, }
}
