using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.BookingMiddleware.ModifyPNR
{
    public class ModifyPNRRQ
    {
        public string ActionType { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public int FareInformationID { get; set; }
        public string ClientIPAddress { get; set; }
        public string LogicalFlightKeyToReplace { get; set; }
        public object HistoricUserName { get; set; }
        public string LogicalFlightKeyToRemove { get; set; }
        public int PersonOrgIdentifierToRemove { get; set; }
        public List<Passenger> PassengersToAdd { get; set; }
        public List<UpdatePassenger> PassengersToUpdate { get; set; }
        public List<SpecialService> SpecialServices { get; set; }
        public List<SpecialServiceToCancel> SpecialServicesToCancel { get; set; }
        public object ContactInformationToAdd { get; set; }
        public object ContactInformationToUpdate { get; set; }
        public object CommentToAdd { get; set; }
        public object EmergencyContactsToAddToSegments { get; set; }
        public object PassengerSegmentsToUpdateRecordLocator { get; set; }
    }

    public class Person
    {
        public int PersonOrgID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public System.DateTime DOB { get; set; }
        public Enums.EnumerationsGenderTypes Gender { get; set; }
        public string Title { get; set; }
        public int NationalityLaguageID { get; set; }
        public Enums.EnumerationsRelationshipTypes RelationType { get; set; }
        public int WBCID { get; set; }
        public int PTCID { get; set; }
        public string PTC { get; set; }
        public bool UseInventory { get; set; }
        public Address Address { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }
        public string Passport { get; set; }
        public string Nationality { get; set; }
        public long ProfileId { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }
    }

    public class ReservationInfo
    {
        public string SeriesNumber { get; set; }
        public string ConfirmationNumber { get; set; }
    }

    public class FlightInformation
    {
        public int LogicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public int FareInformationID { get; set; }
    }

    public class Passenger : Person
    {
        public int DropOffID { get; set; }
        public int PickUpID { get; set; }
        public int LapChildID { get; set; }
        public string FrequentFlyerNumber { get; set; }
        public int SelecteeStatus { get; set; }
        public string StoreFrontID { get; set; }
        public int TravelsWithPersonOrgID { get; set; }
        public string RedressNumber { get; set; }
        public string KnownTravelerNumber { get; set; }
        public string RecordLocator { get; set; }
        public int TierID { get; set; }
        public string TierName { get; set; }
        public List<FlightInformation> FlightInformations { get; set; }
    }

    public class UpdatePassenger : Person
    {
        public string RedressNumber { get; set; }
        public string KnownTravelerNumber { get; set; }
        public string FFNum { get; set; }
        public int TierID { get; set; }
        public string TierName { get; set; }
    }

    public class SpecialService
    {
        public string CodeType;
        public int ServiceID;
        public int SSRCategory;
        public int LogicalFlightID;
        public DateTime DepartureDate;
        public decimal Amount;
        public bool OverrideAmount;
        public Enums.EnumerationsCurrencyCodeTypes CurrencyCode;
        public bool Commissionable;
        public bool Refundable;
        public string ChargeComment;
        public int PersonOrgID;
        public Nullable<int> PhysicalFlightID;
        public string OverrideAmtReason;
        public string ExtPenaltyRule;
        public string ExtIsRePriceFixed;
        public string ExtRePriceSourceName;
        public string ExtRePriceValue;
        public string ExtRePriceValueReason;
    }

    public class SpecialServiceToCancel
    {
        public string AirlineKey;
        public string LogicalFlightKey;
        public string PhysicalFlightKey;
        public string CustomerKey;
        public string AirlinePersonKey;
        public string ChargeKey;
        public string Comment;
    }

    public enum ActionTypes : int
    {
        AddFlightToReservation = 0,
        RemoveFlightFromReservation = 1,
        ReplaceFlightOnReservation = 2,
        AddPassengerToReservation = 3,
        RemovePassengerFromReservation = 4,
        UpdatePassengerInformationNoFee = 5,
        UpdatePassengerInformationAssessFee = 6,
        AddSpecialServiceToReservation = 7,
        RemoveSpecialServiceFromReservation = 8,
        AddContactInformation = 9,
        UpdateContactInformation = 10,
        AddCommentToReservation = 11,
        AddEmergencyContact = 12,
        UpdatePassengerSegmentRecordLocator = 13,
    }


}
