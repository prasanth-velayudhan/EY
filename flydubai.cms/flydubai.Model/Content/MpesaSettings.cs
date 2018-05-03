using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace flydubai.Model.Content
{
    public class MpesaSettings
    {
        [Key]
        //[System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public long SettingId { get; set; }

        [Required]
        [DisplayName("CountryID")]
        public int CountryID { get; set; }

        [Required]
        [DisplayName("Currency")]
        public string Currency { get; set; }

        [Required]
        [DisplayName("Form Of Payment")] //mpesa
        public string FOP { get; set; }

        [Required]
        [DisplayName("Payment Type")] //INVC
        public string PaymentType { get; set; }

        [Required]
        [DisplayName("FZ mPesa Account Number")] 
        public string AccountNo { get; set; }

        [Required]
        [DisplayName("Active")]
        public bool IsActive { get; set; }

        //public IEnumerable<SelectListItem> CountriesFrom { get; set; }

    }
}
