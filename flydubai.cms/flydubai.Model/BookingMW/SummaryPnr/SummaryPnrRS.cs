using flydubai.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW.SummaryPnr
{
    public class SummaryPnrRS
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
        public DateTime? BookDate { get; set; }
        public string ReservationType { get; set; }
        public DateTime? TodaysDate { get; set; }
        public DateTime? LastModified { get; set; }
        public DateTime? ReservationExpirationDate { get; set; }
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
        public DateTime ReservationFulfillmentRequiredByGMT{ get; set; }
        public DateTime ReservationFulfillmentRequiredByODT { get; set; }
        public bool IsInterline { get; set; }
        public bool IsCodeShare { get; set; }
        public List<Airline> Airlines { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Comment> Comments { get; set; }
        public List<ReservationContact> ReservationContacts { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }
        public List<Voucher> Vouchers { get; set; }
        public List<Car> Cars { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<Package> Packages { get; set; }
        public List<Exception> Exceptions { get; set; }        
    }    

    public class OAFlight
    {
        public string Key { get; set; }
        public int OALogicalFlightID { get; set; }
        public string DepartureDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNumber { get; set; }
        public string DepartureTime { get; set; }
        public List<OAFlightPerson> OAFlightPersons { get; set; }
        public DateTime Arrivaltime { get; set; }
    }

    public class Airline
    {
        public string Key { get; set; }
        public List<LogicalFlight> LogicalFlight { get; set; }
        public List<OAFlight> OAFlights { get; set; }
    }

    public class Comment
    {
        public int CommentID { get; set; }
        public string Key { get; set; }
        public DateTime CommentDate { get; set; }
        public string Comments { get; set; }
        public int CommentLength { get; set; }
        public string UserID { get; set; }
    }

    public class ReservationContact
    {
        public int VendorID { get; set; }
        public string Key { get; set; }
        public int PersonOrgID { get; set; }
        public bool MarketingOptIn { get; set; }
        public string RedressNum { get; set; }
        public string FirstName { get; set; }
        public string KnownTravNum { get; set; }
        public string LastName { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
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
        public string PassportIssueCountry { get; set; }
        public long ProfileId { get; set; } 
    }

    public class Voucher
    {
        public string Key { get; set; }
        public string VoucherNumber { get; set; }
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
        public string ReservationNumber{ get; set; }
        public string Type { get; set; }       
    }

    public class Exception
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public ExceptionLevels ExceptionLevel { get; set; }
    }

    public class OAFlightPerson
    {
        public string Key { get; set; }
        public int RecordNumber { get; set; }
        public int PersonOrgID { get; set; }     
    }

    public enum ExceptionLevels : int
    { Success = 0, Warning = 1, Critical = 2, }
}
