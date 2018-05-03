using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using flydubai.Common;

namespace flydubai.Model
{
    /// <summary>
    /// Telephone
    /// </summary>
    [Serializable]
    public class Telephone
    {
        public int? TelephoneId { get; set; }

        public string CountryCode { get; set; }

        [Display(Prompt = "Area code")]
        // [Required, MaxLength(3, ErrorMessage = "Telephone.InvalidAreaCode")]
        public string AreaCode { get; set; }
         
        // For backwards compatability
        private string phone;

        [Display(Prompt = "Number")]
        [Required, MaxLength(11, ErrorMessage = "Telephone.InvalidPhone")]
        public string Phone
        {
            get
            {
                // For backwards compatability when area code was a required separate field
                if ((AreaCode == null) || (AreaCode == string.Empty))
                    return this.phone;
                else
                    return AreaCode + this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public bool IsPreferred { get; set; }

        public Enums.PhoneType PhoneType { get; set; }

        /// <summary>
        /// Shallows the copy.
        /// </summary>
        /// <returns></returns>
        public Telephone ShallowCopy()
        {
            return (Telephone)this.MemberwiseClone();
        }

        public string FullPhoneNumber
        {
            get
            {
                return string.Format("{0}{1}{2}", this.CountryCode, this.AreaCode, this.Phone).Replace("+","").Replace("-", "");
            }
        }
    }
}
