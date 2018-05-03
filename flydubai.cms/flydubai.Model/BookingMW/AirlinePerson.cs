using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class AirlinePerson
    {
        public decimal Weight { get; set; }
        public string Key { get; set; }
        public int PersonOrgID { get; set; }
        public string FFNum { get; set; }
        public bool PaxActive { get; set; }
        public string FirstName { get; set; }
        public int RecordNumber { get; set; }
        public string LastName { get; set; }
        public string RecordLocator { get; set; }
        public string MiddleName { get; set; }
        public int OriginalRecordNumber { get; set; }
        public int Age { get; set; }
        public string ContactInfo { get; set; }
        public DateTime DOB { get; set; }
        public int DropoffID { get; set; }
        public string Gender { get; set; }
        public int PickupID { get; set; }
        public string Title { get; set; }
        public int LapChildID { get; set; }
        public int NationalityLaguageID { get; set; }
        public string FareClassCode { get; set; }
        public string RelationType { get; set; }
        public string FareBasisCode { get; set; }
        public int WBCID { get; set; }
        public string WebFareType { get; set; }
        public int PTCID { get; set; }
        public string FareBasisSched { get; set; }
        public bool UseInventory { get; set; }
        public decimal FareAmount { get; set; }
        public string Address { get; set; }
        public int ResSegStatus { get; set; }
        public string Address2 { get; set; }
        public int SegSubStatus { get; set; }
        public string City { get; set; }
        public int SelecteeStatus { get; set; }
        public string State { get; set; }
        public bool CheckinStatus { get; set; }
        public string Postal { get; set; }
        public string Cabin { get; set; }
        public string Country { get; set; }
        public string TicketNumber { get; set; }
        public string Company { get; set; }
        public bool HasTickets { get; set; }
        public string Comments { get; set; }
        public int UIDisplayValue { get; set; }
        public string Passport { get; set; }
        public int InterlinedSegment { get; set; }
        public string Nationality { get; set; }
        public string InterlinedCarrierCode { get; set; }
        public string PassportIssueCountry { get; set; }
        public string PassportExpiryDate { get; set; }
        public long ProfileId { get; set; }
        public int ManualFare { get; set; }
        public int InventoryOverbooked { get; set; }
        public string TicketCouponNumber { get; set; }
        public int TicketControl { get; set; }
        public string TicketControlOwner { get; set; }
        public string TicketControlModifiedDate { get; set; }
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
        public List<SeatAssignment> SeatAssignments { get; set; }
        public List<Charge> Charges { get; set; }
        public List<Baggage> Bags { get; set; }
        public int TierID { get; set; }
        public string TierName { get; set; }
        public string LastGDSStatus { get; set; }
        public string ChangeConsent { get; set; }       
    }
}
