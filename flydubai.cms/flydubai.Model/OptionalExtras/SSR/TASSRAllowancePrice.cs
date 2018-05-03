namespace flydubai.Model.OptionalExtras.SSR
{
    using System.Globalization;

    using flydubai.Common;

    /// <summary>
    /// SSR Allowance Price
    /// </summary>
    public class TASSRAllowancePrice
    {
        public string CodeType { get; set; }

        //public int TotalWeight { get; set; }

        //public int CheckedWeight { get; set; }

        public bool IsIncluded { get; set; }

        public string CurrencyCode { get; set; }

        public decimal Price { get; set; }

        public int QuantityAvailable { get; set; }

        /// <summary>
        /// Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns></returns>
        //public bool Equals(TASSRAllowancePrice other)
        //{
        //    if (ReferenceEquals(null, other))
        //    {
        //        return false;
        //    }
        //    if (ReferenceEquals(this, other))
        //    {
        //        return true;
        //    }
        //    return Equals(other.CodeType, this.CodeType) && other.TotalWeight == this.TotalWeight && other.CheckedWeight == this.CheckedWeight && other.IsIncluded.Equals(this.IsIncluded) && Equals(other.CurrencyCode, this.CurrencyCode) && other.Price == this.Price;
        //}

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
            if (obj.GetType() != typeof(TASSRAllowancePrice))
            {
                return false;
            }
            return Equals((TASSRAllowancePrice)obj);
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
                //result = (result * 397) ^ this.TotalWeight;
                //result = (result * 397) ^ this.CheckedWeight;
                result = (result * 397) ^ this.IsIncluded.GetHashCode();
                result = (result * 397) ^ (this.CurrencyCode != null ? this.CurrencyCode.GetHashCode() : 0);
                result = (result * 397) ^ this.Price.GetHashCode();
                return result;
            }
        }
    }
}