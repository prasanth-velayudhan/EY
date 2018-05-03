using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Payment Point
    /// </summary>
    public class PaymentPoint : EntityBase<PaymentPoint, PaymentPointVersion>
    {
        [Key]
        public int PaymentPointId { get; set; }

        public override int Id
        {
            get { return PaymentPointId;  }
            set { PaymentPointId = value; }
        }
    }
}
