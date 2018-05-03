using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flydubai.Model.Content
{
    public class PaymentTypes
    {
        [Key]
        //[System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public long TypeId { get; set; }

        [Required]
        [DisplayName("Payment Type")]
        public string Type { get; set; }
        [Required]
        [DisplayName("Payment Type Description")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Active")]
        public bool IsActive { get; set; }
    }
}
