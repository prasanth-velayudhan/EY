namespace flydubai.Model.Profiles
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    /// <summary>
    /// Sign Up Preferences
    /// </summary>
    [Serializable]
    public class SignUpPreferences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignUpPreferences"/> class.
        /// </summary>
        public SignUpPreferences()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignUpPreferences"/> class.
        /// </summary>
        /// <param name="email">The email.</param>
        public SignUpPreferences(string email) : this()
        {
            this.Email = email;
            this.Reset();
        }

        [Key]
        public int SignUpPreferencesId { get; set; }

        /// <summary>
        /// Gets or sets the email address to receive email marketing.
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phonenumber to receive sms marketing.  Leave blank to not register with SMS.
        /// </summary>
        [DataType(DataType.PhoneNumber)]
        public string Sms { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [ForeignKey("Country")]
        public int? CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        public string PreferredLanguageCode { get; set; }

        public bool? SpecialOffers { get; set; }
        
        public bool? MonthlyNews { get; set; }
        
        public bool? PartnerPromotions { get; set; }

        public virtual string OffersDestination1 { get; set; }

        public virtual string OffersDestination2 { get; set; }

        public virtual string OffersDestination3 { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void Reset()
        {
            this.SpecialOffers = true;
            this.MonthlyNews = true;
            this.PreferredLanguageCode = null;
            this.PartnerPromotions = null;
            this.OffersDestination1 = null;
            this.OffersDestination2 = null;
            this.OffersDestination3 = null;
        }

        /// <summary>
        /// Sets the destinations.
        /// </summary>
        /// <param name="destinations">The destinations.</param>
        public void SetDestinations(params string[] destinations)
        {
            this.OffersDestination1 = destinations.Length >= 1 ? destinations.First() : null;
            this.OffersDestination2 = destinations.Length >= 2 ? destinations.Skip(1).First() : null;
            this.OffersDestination3 = destinations.Length >= 3 ? destinations.Skip(2).First() : null;    
        }

        public bool IsUnsubscribed
        {
            get
            {
                return !(this.SpecialOffers.HasValue && this.SpecialOffers.Value)
                       && !(this.MonthlyNews.HasValue && this.MonthlyNews.Value)
                       && !(this.PartnerPromotions.HasValue && this.PartnerPromotions.Value);
            }
        }

        /// <summary>
        /// Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns></returns>
        public bool Equals(SignUpPreferences other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Equals(other.Email, this.Email) && Equals(other.Sms, this.Sms) && Equals(other.Title, this.Title) && Equals(other.FirstName, this.FirstName) && Equals(other.LastName, this.LastName) && other.CountryId.Equals(this.CountryId) && Equals(other.Country, this.Country) && Equals(other.PreferredLanguageCode, this.PreferredLanguageCode) && other.SpecialOffers.Equals(this.SpecialOffers) && other.MonthlyNews.Equals(this.MonthlyNews) && other.PartnerPromotions.Equals(this.PartnerPromotions) && Equals(other.OffersDestination1, this.OffersDestination1) && Equals(other.OffersDestination2, this.OffersDestination2) && Equals(other.OffersDestination3, this.OffersDestination3);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != typeof(SignUpPreferences))
            {
                return false;
            }
            return Equals((SignUpPreferences)obj);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = (this.Email != null ? this.Email.GetHashCode() : 0);
                result = (result * 397) ^ (this.Sms != null ? this.Sms.GetHashCode() : 0);
                result = (result * 397) ^ (this.Title != null ? this.Title.GetHashCode() : 0);
                result = (result * 397) ^ (this.FirstName != null ? this.FirstName.GetHashCode() : 0);
                result = (result * 397) ^ (this.LastName != null ? this.LastName.GetHashCode() : 0);
                result = (result * 397) ^ (this.CountryId.HasValue ? this.CountryId.Value : 0);
                result = (result * 397) ^ (this.Country != null ? this.Country.GetHashCode() : 0);
                result = (result * 397) ^ (this.PreferredLanguageCode != null ? this.PreferredLanguageCode.GetHashCode() : 0);
                result = (result * 397) ^ (this.SpecialOffers.HasValue ? this.SpecialOffers.Value.GetHashCode() : 0);
                result = (result * 397) ^ (this.MonthlyNews.HasValue ? this.MonthlyNews.Value.GetHashCode() : 0);
                result = (result * 397) ^ (this.PartnerPromotions.HasValue ? this.PartnerPromotions.Value.GetHashCode() : 0);
                result = (result * 397) ^ (this.OffersDestination1 != null ? this.OffersDestination1.GetHashCode() : 0);
                result = (result * 397) ^ (this.OffersDestination2 != null ? this.OffersDestination2.GetHashCode() : 0);
                result = (result * 397) ^ (this.OffersDestination3 != null ? this.OffersDestination3.GetHashCode() : 0);
                return result;
            }
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(SignUpPreferences left, SignUpPreferences right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(SignUpPreferences left, SignUpPreferences right)
        {
            return !Equals(left, right);
        }
    }
}
