
namespace flydubai.Model.Journey
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using flydubai.Common;
    using flydubai.Model.Booking;
    
    

    /// <summary>
    /// Journey Passenger
    /// </summary>
    [Serializable]
    public class JourneyPassenger : Human, IEquatable<AirlinePerson>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyPassenger"/> class.
        /// </summary>
        public JourneyPassenger()
        {
            this.Telephones = new List<Telephone>();
            this.OptionalExtras = new List<JourneyOptionalExtra>();
            this.PassengerType = Enums.PassengerTypes.Adult;
        }

        public Enums.PassengerTypes PassengerType { get; set; }

        public string PaxId { get; set; }

        public int SortOrder
        {
            get
            {
                switch(PassengerType)
                {
                    case Enums.PassengerTypes.Adult:
                        return 1;
                    case Enums.PassengerTypes.Child:
                        return 2;
                    case Enums.PassengerTypes.Infant:
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException("PassengerType");
                }
            }
        }

        public int PassengerId { get; set; }

        public int NegativePassengerId 
        {
            get 
            {
                return (Math.Abs(this.PassengerId) * -1);
            }
        }

        public bool IsPrimaryPassenger { get; set; }

        public long? PrimaryPassengerProfileId { get; set; }

        public int? TravelsWithPassengerId { get; set; }

        public string FareBasisCode { get; set; }

        public int FareId { get; set; }

        public int? NegativeTravelsWithPassengerId
        {
            get
            {
                if (this.TravelsWithPassengerId.HasValue)
                    return (Math.Abs(this.TravelsWithPassengerId.Value) * -1);
                else
                    return null;
            }
        }

        public List<JourneyOptionalExtra> OptionalExtras { get; set; }

        public bool CanHaveAssignedOwnBaggage
        {
            get
            {
                return this.PassengerType != Enums.PassengerTypes.Infant;
            }
        }

        public bool CanHaveOwnIFE
        {
            get
            {
                return this.PassengerType != Enums.PassengerTypes.Infant;
            }
        }

        public bool CanHaveOwnTASSR
        {
            get
            {
                return this.PassengerType != Enums.PassengerTypes.Infant;
            }
        }

        public bool CanHaveAssignedOwnSeat
        {
            get
            {
                return this.PassengerType != Enums.PassengerTypes.Infant;
            }
        }

        public bool RequiresInsurance
        {
            get
            {
                return this.PassengerType != Enums.PassengerTypes.Infant;
            }
        }

        public bool HasBeenAssignedPersonOrgId
        {
            get
            {
                // Max number of passengers would be 9 adults and 9 infants
                return this.PassengerId > 18;
            }
        }

        /// <summary>
        /// Deeps the copy.
        /// </summary>
        /// <returns></returns>
        public JourneyPassenger DeepCopy()
        {
            var copy = (JourneyPassenger)this.MemberwiseClone();

            copy.Telephones = this.Telephones.Select(t => t.ShallowCopy()).ToList();
            copy.OptionalExtras = this.OptionalExtras.Select(o => o.ShallowCopy()).ToList();

            return copy;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        public bool Equals(AirlinePerson other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.HasBeenAssignedPersonOrgId)
            {
                return this.PassengerId.Equals(other.PersonOrgId);
            }

            return this.FirstName.Equals(other.FirstName, StringComparison.CurrentCultureIgnoreCase)
                   && this.LastName.Equals(other.LastName, StringComparison.CurrentCultureIgnoreCase)
                   && this.PassengerType.Equals(other.PassengerType);
        }

        /// <summary>
        /// PassportNumber
        /// </summary>
        /// A-5484:WR2:FR028
        public string PassportNumber { get; set; }

        /// <summary>
        /// Nationality
        /// </summary>
        /// A-5484:WR2:FR028
        public string Nationality { get; set; }


        /// <summary>
        /// Passport Number
        /// </summary>
        /// A-5469:WR4:FR012
        public string ApiPassportNumber { get; set; }

        /// <summary>
        /// ApiExpiryDate
        /// </summary>
        /// A-5469:WR4:FR012
        public DateTime ApiExpiryDate { get; set; }

        /// <summary>
        /// Nationality
        /// </summary>
        /// A-5469:WR4:FR012
        public string ApiNationality { get; set; }
        /// <summary>
        /// Issuing Country
        /// </summary>
        /// A-5469:WR4:FR012
        public string ApiIssuingCountry { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        /// A-5469:WR4:FR012
        public string ApiGender { get; set; }

        // <summary>
        /// ApiDateOfBirth
        /// </summary>
        /// A-5469:WR4:FR012
        public DateTime ApiDateOfBirth { get; set; }

        /// <summary>
        /// DocumentType1
        /// </summary>
        /// A-5469:WR4:FR012
        public string ApiDocumentType1 { get; set; }

        /// <summary>
        /// DocumentType2
        /// </summary>
        /// A-5469:WR4:FR012
        public string ApiDocumentType2 { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// A-5469:Bug Fix FZWR-840
        public string Country { get; set; }

        public string FFNum { get; set; }

        public string Tier { get; set; }

    }
}
