using flydubai.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMiddleware.SummaryPnr
{
    public class SummaryPnrRQ : TransactionInfo
    {
        public ActionTypes ActionType { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public string SecurityToken { get; set; }
        public Enums.EnumerationsCurrencyCodeTypes CarrierCurrency { get; set; }
        public Enums.EnumerationsCurrencyCodeTypes DisplayCurrency { get; set; }
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
    }

    public class Person
    {
        public int PersonOrgID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public Enums.EnumerationsGenderTypes Gender { get; set; }
        public string Title { get; set; }
        public int NationalityLaguageID { get; set; }
        public Enums.EnumerationsRelationshipTypes RelationType { get; set; }
        public int WBCID { get; set; }
        public int PTCID { get; set; }
        public string PTC { get; set; }
        public int TravelsWithPersonOrgID { get; set; }
        public string RedressNumber { get; set; }
        public string KnownTravelerNumber { get; set; }
        public bool MarketingOptIn { get; set; }
        public bool UseInventory { get; set; }
        public Address Address { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }
        public string Passport { get; set; }
        public string Nationality { get; set; }
        public long ProfileId { get; set; }
        public bool IsPrimaryPassenger { get; set; }
        public List<DocumentInfo> DocumentInfos { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }
        public string FrequentFlyerNumber { get; set; }
        public string Suffix { get; set; }
        public string TierName { get; set; }
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

    public class Payment
    {
        public int ReservationPaymentID { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardType { get; set; }
        public string CardHolder { get; set; }
        public Enums.EnumerationsCurrencyCodeTypes PaymentCurrency { get; set; }
        public int ISOCurrency { get; set; }
        public decimal PaymentAmount { get; set; }
        public EnumerationsPaymentMethodTypes PaymentMethod { get; set; }
        public string CardNum { get; set; }
        public string CVCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsTACreditCard { get; set; }
        public long VoucherNum { get; set; }
        public string GcxID { get; set; }
        public string GcxOpt { get; set; }
        public string OriginalCurrency { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public string PaymentComment { get; set; }
        public string BillingCountry { get; set; }
    }

    public class SpecialService
    { public string CodeType; public int ServiceID; public int SSRCategory; public int LogicalFlightID; public DateTime DepartureDate; public decimal Amount; public bool OverrideAmount; public Enums.EnumerationsCurrencyCodeTypes CurrencyCode; public bool Commissionable; public bool Refundable; public string ChargeComment; public int PersonOrgID; public Nullable<int> PhysicalFlightID; public string OverrideAmtReason; public string ExtPenaltyRule; public string ExtIsRePriceFixed; public string ExtRePriceSourceName; public string ExtRePriceValue; public string ExtRePriceValueReason;}

    public class Seat
    {
        public int PersonOrgID { get; set; }
        public int LogicalFlightID { get; set; }
        public int PhysicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string SeatSelected { get; set; }
        public string RowNumber { get; set; }
    }

    public class TransactionInfo
    {
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string HistoricUserName { get; set; }
    }

    public class DocumentInfo
    {
        public string DocType { get; set; }
        public string DocNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string IssuingCountry { get; set; }
    }

    public enum ActionTypes : int
    { GetSummary = 0, }

    public enum EnumerationsPaymentMethodTypes : int
    { AMEX = 0, DCLB = 1, DSCV = 2, MSCD = 3, UATP = 4, VISA = 5, INVC = 6, SAPI = 7, TKNE = 8, CASH = 9, CHCK = 10, TCHK = 11, TCKT = 12, VCHR = 13, PL8R = 14, EFT = 15, PNTS = 16, }
}