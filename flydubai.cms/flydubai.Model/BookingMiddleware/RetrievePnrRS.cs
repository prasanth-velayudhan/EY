using flydubai.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMiddleware
{
    public class RetrievePnrRS
    {
        public string Key { get; set; }
        public string SeriesNumber { get; set; }
        public string ConfirmationNumber { get; set; }
        public string BookingAgent { get; set; }
        public string CRSCode { get; set; }
        public int TravelGroupID { get; set; }
        public string IATANumber { get; set; }
        public string ExternalAppID { get; set; }
        public string WebBookingID { get; set; }
        public int PromotionalID { get; set; }
        public string PromotionalCode { get; set; }
        public int RecieptLanguageID { get; set; }
        public Enums.EnumerationsCurrencyCodeTypes ReservationCurrency { get; set; }
        public long ProfileID { get; set; }
        public long PNRPin { get; set; }
        public DateTime BookDate { get; set; }
        public string ReservationType { get; set; }
        public DateTime TodaysDate { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime ReservationExpirationDate { get; set; }
        public string CorporationID { get; set; }
        public string SecurityGuid { get; set; }
        public bool HasTickets { get; set; }
        public string ValuePackageData { get; set; }
        public string UserIPAddress { get; set; }
        public string ManageBookingAgent { get; set; }
        public string HistoricConfirmationNum { get; set; }
        public string Cabin { get; set; }
        public decimal ReservationBalance { get; set; }
        public decimal ChangeFee { get; set; }
        public int LogicalFlightCount { get; set; }
        public int ActivePassengerCount { get; set; }
        public bool BalancedReservation { get; set; }
        public DateTime ReservationFulfillmentRequiredByGMT { get; set; }
        public DateTime ReservationFulfillmentRequiredByODT { get; set; }
        public Airline[] Airlines { get; set; }
        public Payment1[] Payments { get; set; }
        public Comment1[] Comments { get; set; }
        public ReservationContact[] ReservationContacts { get; set; }
        public ContactInfo1[] ContactInfos { get; set; }
        public Voucher[] Vouchers { get; set; }
        public Car[] Cars { get; set; }
        public Hotel[] Hotels { get; set; }
        public Package[] Packages { get; set; }
        public ExceptionInformationExceptions Exceptions { get; set; }
    }

    public class Airline
    {
        public string Key { get; set; }
        public LogicalFlight[] LogicalFlight { get; set; }
        public OAFlight[] OAFlights { get; set; }
    }

    public class Payment1
    {
        public string Key { get; set; }
        public int ReservationPaymentID { get; set; }
        public string CardHolder { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CardNumber { get; set; }
        public string CVCode { get; set; }
        public string Authorizationcode { get; set; }
        public int TerminalID { get; set; }
        public string CurrencyPaid { get; set; }
        public int CheckNumber { get; set; }
        public string Reference { get; set; }
        public string Result { get; set; }
        public string TransactionID { get; set; }
        public string ValueCode { get; set; }
        public int TransactionIndicator { get; set; }
        public string SettlementBatch { get; set; }
        public decimal AuthorizedAmount { get; set; }
        public int VoucherNumber { get; set; }
        public string FFNumber { get; set; }
        public int Miles { get; set; }
        public string PaymentComment { get; set; }
        public string BaseCurrency { get; set; }
        public decimal BaseAmount { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public string DocumentReceivedBy { get; set; }
        public DateTime BatchProcessStart { get; set; }
        public int BatchProcessExtracted { get; set; }
        public string TicketCouponNumber { get; set; }
        public DateTime ATCANDateProcessed { get; set; }
        public string TicketType { get; set; }
        public string GcxID { get; set; }
        public string GcxOptOption { get; set; }
        public int GcxExported { get; set; }
        public DateTime GcxExportedDate { get; set; }
        public string OriginalCurrency { get; set; }
        public decimal OriginalAmount { get; set; }
        public string IATANum { get; set; }
        public string ProcessorID { get; set; }
        public string MerchantID { get; set; }
        public string ProcessorName { get; set; }
        public string OriginalPaymentMethod { get; set; }
        public int TransactionStatus { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseCode { get; set; }
        public int PersonOrgID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime DatePaid { get; set; }
        public string UserData { get; set; }
        public string CardVerification { get; set; }
        public decimal GrossAmtResCurrency { get; set; }
        public decimal GrossAmtPayCurrency { get; set; }
        public decimal NetAmtResCurrency { get; set; }
        public decimal CommissionDeductedResCurrency { get; set; }
        public decimal CommissionDeductedPayCurrency { get; set; }
        public decimal RptNetFrmResCurrency { get; set; }
        public decimal RptCommissionFromResCurrency { get; set; }
        public decimal RptCommissionFromPayCurrency { get; set; }
        public decimal TotalRefundResCurrency { get; set; }
        public decimal TotalRefundRptCurrency { get; set; }
        public decimal TotalRefundPayCurrency { get; set; }
        public decimal RedeemedVoucherAmount { get; set; }
        public string UserID { get; set; }
        public int OriginalPaymentID { get; set; }
        public int PaymentReservationChannelID { get; set; }
        public string AncillaryData01 { get; set; }
        public string AncillaryData02 { get; set; }
        public string AncillaryData03 { get; set; }
        public string AncillaryData04 { get; set; }
        public string AncillaryData05 { get; set; }
        public bool AuthenticationByPassed { get; set; }
    }

    public class Comment1
    {
        public int CommentID { get; set; }
        public string Key { get; set; }
        public DateTime CommentDate { get; set; }
        public string Comment { get; set; }
        public int CommentLength { get; set; }
        public string UserID { get; set; }
    }

    public class ReservationContact : Person1
    {
        public int VendorID { get; set; }
        public bool MarketingOptIn { get; set; }
        public string RedressNum { get; set; }
        public string KnownTravNum { get; set; }
        public ContactInfo1[] ContactInfos { get; set; }
    }

    public class ContactInfo1
    {
        public int ContactID { get; set; }
        public string Key { get; set; }
        public int PersonOrgID { get; set; }
        public string ContactField { get; set; }
        public int ContactType { get; set; }
        public string Extension { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Display { get; set; }
        public bool PreferredContactMethod { get; set; }
        public bool ValidatedContact { get; set; }
    }

    public class Voucher
    {
        public string Key { get; set; }
        public int VoucherNumber { get; set; }
        public string CurrencyCode { get; set; }
        public string ReasonCode { get; set; }
        public int PersonOrgID { get; set; }
        public string SeriesNum { get; set; }
        public string ConfirmationNumber { get; set; }
        public int RecordNumber { get; set; }
        public int ChargeNumber { get; set; }
        public string Sponsor { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public string UserId { get; set; }
        public int NonTransferable { get; set; }
        public DateTime BatchProcessStart { get; set; }
        public int BatchProcessExtracted { get; set; }
        public int VoucherType { get; set; }
        public int TripType { get; set; }
        public int IncludeTaxes { get; set; }
        public int IncludePenalty { get; set; }
        public int IncludeSSR { get; set; }
        public int IncludeAuto { get; set; }
        public int IncludeHotel { get; set; }
        public DateTime STimeRestrict { get; set; }
        public DateTime ETimeRestrict { get; set; }
        public int SundayRestrict { get; set; }
        public int MondayRestrict { get; set; }
        public int TuesdayRestrict { get; set; }
        public int WednesdayRestrict { get; set; }
        public int ThursdayRestrict { get; set; }
        public int FridayRestrict { get; set; }
        public int SaturdayRestrict { get; set; }
        public string VoucherNumFull { get; set; }
        public string VoucherPW { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime TravelEffectiveDate { get; set; }
        public DateTime TravelExpirationDate { get; set; }
        public string LogicalFlightsKey { get; set; }
    }

    public class Car
    {
        public string Classification { get; set; }
        public string CompanyID { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Description { get; set; }
        public string ReservationNumber { get; set; }
    }

    public class Hotel
    {
        public string CompanyID { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Description { get; set; }
        public string ReservationNumber { get; set; }
        public string Type { get; set; }
    }

    public class Package
    {
        public string CompanyID { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Description { get; set; }
        public string ReservationNumber { get; set; }
        public string Type { get; set; }
    }

    public class ExceptionInformationExceptions : List<ExceptionInformationException> { }

    public class ExceptionInformationException
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public ExceptionLevels ExceptionLevel { get; set; }
    }

    public enum ExceptionLevels : int
    { Success = 0, Warning = 1, Critical = 2, }

    public class LogicalFlight
    {
        public string Key { get; set; }
        public string FlightGroupId { get; set; }
        public int RecordNumber { get; set; }
        public int LogicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string OriginDefaultTerminal { get; set; }
        public string OriginName { get; set; }
        public string Destination { get; set; }
        public string DestinationDefaultTerminal { get; set; }
        public string DestinationName { get; set; }
        public string OriginMetroGroup { get; set; }
        public string DestinationMetroGroup { get; set; }
        public string SellingCarrier { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime Arrivaltime { get; set; }
        public int PackageItemID { get; set; }
        public string PackageItemName { get; set; }
        public string PackageItemDescription { get; set; }
        public DateTime PackageItemBookDate { get; set; }
        public DateTime PackageItemStartDate { get; set; }
        public DateTime PackageItemEndDate { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public bool Active { get; set; }
        public string VendorDescription { get; set; }
        public int UIDisplayValue { get; set; }
        public PhysicalFlight[] PhysicalFlights { get; set; }
    }

    public class OAFlight
    {
        public string Key { get; set; }
        public int OALogicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime Arrivaltime { get; set; }
        public OAFlightPerson[] OAFlightPersons { get; set; }
    }

    public class Person1
    {
        public string Key { get; set; }
        public int PersonOrgID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public int NationalityLaguageID { get; set; }
        public string RelationType { get; set; }
        public int WBCID { get; set; }
        public int PTCID { get; set; }
        public bool UseInventory { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }
        public string Passport { get; set; }
        public string Nationality { get; set; }
        public long ProfileId { get; set; }
    }

    public class PhysicalFlight
    {
        public string Key { get; set; }
        public int RecordNumber { get; set; }
        public string DestinationDefaultTerminal { get; set; }
        public int PhysicalFlightID { get; set; }
        public int LogicalFlightID { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierName { get; set; }
        public string FlightNumber { get; set; }
        public int FlightOrder { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string OriginDefaultTerminal { get; set; }
        public string OriginName { get; set; }
        public string Destination { get; set; }
        public string DestinationName { get; set; }
        public string OriginMetroGroup { get; set; }
        public string DestinationMetroGroup { get; set; }
        public string SellingCarrier { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime Arrivaltime { get; set; }
        public decimal FlightDuration { get; set; }
        public int Trip { get; set; }
        public string Gate { get; set; }
        public decimal TotalWeight { get; set; }
        public int UIDisplayValue { get; set; }
        public bool Active { get; set; }
        public Customer[] Customers { get; set; }
        public string FromTerminal { get; set; }
        public string ToTerminal { get; set; }
        public string AirCraftType { get; set; }
        public string AirCraftDescription { get; set; }
        public string FlightStatus { get; set; }
        public bool ReaccomChangeAlert { get; set; }
    }

    public class OAFlightPerson
    {
        public string Key { get; set; }
        public int RecordNumber { get; set; }
        public int PersonOrgID { get; set; }
    }

    public class Customer
    {
        public string Key { get; set; }
        public AirlinePerson[] AirlinePersons { get; set; }
    }

    public class AirlinePerson : Person1
    {
        public decimal Weight { get; set; }
        public string FFNum { get; set; }
        public bool PaxActive { get; set; }
        public int RecordNumber { get; set; }
        public string RecordLocator { get; set; }
        public int OriginalRecordNumber { get; set; }
        public string ContactInfo { get; set; }
        public int DropoffID { get; set; }
        public int PickupID { get; set; }
        public int LapChildID { get; set; }
        public string FareClassCode { get; set; }
        public string FareBasisCode { get; set; }
        public string WebFareType { get; set; }
        public string FareBasisSched { get; set; }
        public decimal FareAmount { get; set; }
        public int ResSegStatus { get; set; }
        public int SegSubStatus { get; set; }
        public int SelecteeStatus { get; set; }
        public bool CheckinStatus { get; set; }
        public string Cabin { get; set; }
        public string TicketNumber { get; set; }
        public bool HasTickets { get; set; }
        public int UIDisplayValue { get; set; }
        public int InterlinedSegment { get; set; }
        public string InterlinedCarrierCode { get; set; }
        public int ManualFare { get; set; }
        public int InventoryOverbooked { get; set; }
        public string TicketCouponNumber { get; set; }
        public int TicketControl { get; set; }
        public string TicketControlOwner { get; set; }
        public DateTime TicketControlModifiedDa { get; set; }
        public string MarketingCode { get; set; }
        public bool MarketingOptIn { get; set; }
        public int EmergencyContactID { get; set; }
        public int DisclosedEmergencyContact { get; set; }
        public int CappsStatus { get; set; }
        public int ToRecordNumber { get; set; }
        public int FromRecordNumber { get; set; }
        public string StoreFrontID { get; set; }
        public string InsuranceConfNum { get; set; }
        public string InsuranceTransID { get; set; }
        public string RedressNum { get; set; }
        public string KnownTravNum { get; set; }
        public bool PrimaryPassenger { get; set; }
        public int NameChangeCount { get; set; }
        public string CrsCode { get; set; }
        public SeatAssignment[] SeatAssignments { get; set; }
        public Charge[] Charges { get; set; }
        public Baggage[] Bags { get; set; }
        public int TierID { get; set; }
        public string TierName { get; set; }
        public string ChangeConsent { get; set; }    
    }

    public class SeatAssignment
    {
        public string Key { get; set; }
        public int PhysicalFlightID { get; set; }
        public DateTime ActualDepartureDate { get; set; }
        public string FlightNumber { get; set; }
        public DateTime ScheduledDeparturetime { get; set; }
        public DateTime ScheduledArrivaltime { get; set; }
        public int BoardingPassNumber { get; set; }
        public string Seat { get; set; }
        public int RowNumber { get; set; }
        public string Gate { get; set; }
        public string OldSeat { get; set; }
        public int OldRowNumber { get; set; }
        public bool Boarded { get; set; }
        public string CheckInAgent { get; set; }
        public DateTime CheckInDate { get; set; }
        public string CouponStatusIndicator { get; set; }
        public string BoardingSequence { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int BoardingPassPrinted { get; set; }
        public string FrequentFlyerCarrierCode { get; set; }
        public string FrequentFlyerNumber { get; set; }
        public string FrequentFlyerSSRCode { get; set; }
        public string FrequentFlyerMemberTierLevel { get; set; }
        public string FrequentFlyerMemberRating { get; set; }
        public int FrequentFlyerNumberActionTracker { get; set; }
        public int ReservationChannelID { get; set; }
        public int FrequentFlyerInfoReservationChannelID { get; set; }
        public DateTime FrequentFlyerNumberLAstModifiedDate { get; set; }
    }

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
        public DateTime ExchangeRateDate { get; set; }
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
        public ReservationPaymentMap[] ReservationPaymentMaps { get; set; }
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
    }

    public class Baggage
    {
        public int BagId { get; set; }
        public string Key { get; set; }
        public int BagNumber { get; set; }
        public decimal BagWeight { get; set; }
        public string BagCode { get; set; }
        public int BagChecked { get; set; }
        public int Pet { get; set; }
        public int BagActive { get; set; }
        public int BagTagPrinted { get; set; }
        public int RecordNumber { get; set; }
    }

    public class ReservationPaymentMap
    {
        public string Key { get; set; }
        public int ReservationPaymentID { get; set; }
        public decimal AmountApplied { get; set; }
        public int ReservationChargeID { get; set; }
        public DateTime DatePaid { get; set; }
        public int OriginalReferencePaymentID { get; set; }
        public decimal RefundAmount { get; set; }
        public int PaymentCurrencyAmount { get; set; }
        public string ApprovalCode { get; set; }
    }

    public class ViewPnrModify
    {
        public RetrievePnrRS viewPNR { get; set; }
    }
}