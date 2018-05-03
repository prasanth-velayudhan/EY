namespace flydubai.Model.OptionalExtras.IFE
{
    using System.Globalization;

    using flydubai.Common;

    /// <summary>
    /// IFE Allowance Price
    /// </summary>
    public class IFEPrice
    {
        public string CodeType { get; set; }

        public bool IsIncluded { get; set; }

        public string CurrencyCode { get; set; }

        public decimal Price { get; set; }

        public int PFID { get; set; }

        /// <summary>
        /// Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns></returns>
        public bool Equals(IFEPrice other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Equals(other.CodeType, this.CodeType)  && other.IsIncluded.Equals(this.IsIncluded) && Equals(other.CurrencyCode, this.CurrencyCode) && other.Price == this.Price;
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
            if (obj.GetType() != typeof(IFEPrice))
            {
                return false;
            }
            return Equals((IFEPrice)obj);
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
                int result = (this.CodeType != null ? this.CodeType.GetHashCode() : 0);
                result = (result * 397) ^ this.IsIncluded.GetHashCode();
                result = (result * 397) ^ (this.CurrencyCode != null ? this.CurrencyCode.GetHashCode() : 0);
                result = (result * 397) ^ this.Price.GetHashCode();
                return result;
            }
        }

        //Fare Branding changes
        public bool IsIFEIncludedFare { get; set; }
    }
}