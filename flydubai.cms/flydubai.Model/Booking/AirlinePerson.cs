using System.Linq;

namespace flydubai.Model.Booking
{
    using System;
    using System.Collections.Generic;

    using flydubai.Common;
    using System.Configuration;

    /// <summary>
    /// Airline Person
    /// </summary>
    [Serializable]
    public class AirlinePerson
    {
        public AirlinePerson()
        {
            this.Charges = new List<Charge>();
        }

        public string Key { get; set; }

        public int PersonOrgId { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public Enums.PassengerTypes PassengerType { get; set; }

        public int PassengerTypeOrder
        {
            get
            {
                switch (this.PassengerType)
                {
                    case Enums.PassengerTypes.Adult:
                        return 1;
                        break;
                    case Enums.PassengerTypes.Child:
                        return 2;
                        break;
                    default:
                        return 3;
                        break;
                }
            }
        }

        public bool IsPrimaryPassenger { get; set; }

        public string FareBasisCode { get; set; }

        public string WebFareType { get; set; }

        public string FareClassCode { get; set; }
        //A-5616 Added PP
        public int FareTypeId
        {
            get;
            set;

            //old code
            //get
            //{
            //    string[] businessfarebasis = ConfigurationManager.AppSettings["BusinessFareBasis"].Split(',');
            //    if (businessfarebasis.Contains(this.FareBasisCode.Substring(0, 1)))
            //    {
            //        return Constants.BusinessPayToChange;
            //    }
            //    else
            //    {
            //        switch (this.WebFareType.Trim().ToLower())
            //        {
            //            case Constants.EconomyPayToChange:
            //                return Constants.PayToChange;
            //            case Constants.EconomyFreeToChange:
            //                return Constants.FreeToChange;
            //            case Constants.EconomySpecialOffer:
            //                return Constants.NoChange;
            //            case Constants.BusinessBasic:
            //                return Constants.BusinessPayToChange;
            //            default:
            //                switch (this.FareBasisCode.Substring(this.FareBasisCode.Length - 2))
            //                {
            //                    case "PC":
            //                        return 1;
            //                    case "FC":
            //                        return 2;
            //                    case "NC":
            //                        return 3;
            //                    case "PP":
            //                        return 4;
            //                    default:
            //                        switch (this.FareBasisCode.Substring(this.FareBasisCode.Length - 4, 1))
            //                        {
            //                            case "6":
            //                                return 1;
            //                            case "7":
            //                                return 2;
            //                            case "8":
            //                                return 3;
            //                            case "9":
            //                                return 4;
            //                        }
            //                        return 1;
            //                }
            //        }

            //    }
            //}

        }

        public List<Charge> Charges { get; set; }

        public List<Charge> ActiveCharges
        {
            get
            {
                return this.Charges.Where(c => c.ChargeStatus == 1).ToList();
            }
        }

        public List<Charge> NonCancelledNoneFeeCharges
        {
            get
            {
                return this.ActiveCharges.Where(c => c.Amount > 0 && c.CodeType.Trim() != "PMNT").ToList();
            }
        }

        public SeatAssignment SeatAssignment { get; set; }

        public SeatAssignment AssignnedSeat
        {
            get
            {
                if (this.SeatAssignment != null && !string.IsNullOrEmpty(this.SeatAssignment.Seat))
                {
                    return this.SeatAssignment;
                }
                else
                {
                    return null;
                }
            }
        }

        public string InsuranceConfNum { get; set; }

        public string InsuranceTransID { get; set; }

        public int InterlinedSegment { get; set; }

        public string Gender { get; set; }

        public DateTime DOB { get; set; }

        public string Passport { get; set; }

        public string Nationality { get; set; }

        public int LapChildID { get; set; }

        // 0 = Cancelled, 1 = Active
        public int ResSegStatus { get; set; }

        public int RecordNumber { get; set; }

        public bool IsActive
        {
            get
            {
                return this.ResSegStatus == 1;
            }
        }

        /// <summary>
        /// Used for sorting passengers
        /// </summary>
        public int SortKey
        {
            get
            {
                if (this.IsPrimaryPassenger)
                    return 1;

                else
                {
                    switch (this.PassengerType)
                    {
                        case Enums.PassengerTypes.Adult:
                            return 2;

                        case Enums.PassengerTypes.Child:
                            return 3;

                        case Enums.PassengerTypes.Infant:
                            return 4;

                        default:
                            return 99;
                    }
                }
            }
        }

        /// <summary>
        /// A-5616 added cabin property
        /// </summary>
        public string Cabin { get; set; }

        //Added for OFEE changes
        public bool isTFEEApplied
        {
            get
            {
                return this.Charges.Any(c => c.ChargeStatus == 1 && c.CodeType.Trim() == Constants.TFEECharge && c.Amount > 0);
            }
        }

        //FFP Changes
        public string FFNum { get; set; }

        public int TierID { get; set; }
        
        public string TierName { get; set; }

        public string ChangeConsent { get; set; }

        public int FromRecordNumber { get; set; }

        /// <summary>
        /// FareTypeId.
        /// </summary>
        /// <param name="charge">The charge.</param>
        /// <returns></returns>
        public int GetFareTypeID(string FareTypeName)
        {
            return Constants.EconomyFareTypeIds.Where(x => x.Value == FareTypeName).FirstOrDefault().Key == 0 ? (Constants.BusinessFareTypeIds.Where(x => x.Value == FareTypeName).FirstOrDefault().Key == 0 ? 0 : Constants.BusinessFareTypeIds.Where(x => x.Value == FareTypeName).FirstOrDefault().Key) : Constants.EconomyFareTypeIds.Where(x => x.Value == FareTypeName).FirstOrDefault().Key;
        }

        //Interline changes
        public string TicketNumber { get; set; }

        public string LastGDSStatus { get; set; }

        public string RecordLocator { get; set; }
    }
}
