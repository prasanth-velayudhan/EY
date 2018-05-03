namespace flydubai.Model.Booking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
   
    
    /// <summary>
    /// Payment
    /// </summary>
    [Serializable]
    public class Payment
    {
       
       
        public int TransactionStatus { get; set; }

        public string Reference { get; set; }

        public string Key { get; set; }

        public string PaymentMethod { get; set; }

        public decimal PaymentAmount { get; set; }

        public decimal BaseAmount { get; set; }

        public string CurrencyPaid { get; set; }

        public string CardNumber { get; set; }

        public string CardHolder { get; set; }

        public string Address { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Postal { get; set; }

        public string VoucherNumber { get; set; }

        public DateTime DatePaid { get; set; }

        //Start A-5469 WR:2 FR:024
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        //End A-5469 WR:2 FR:024
        public string FFNumber { get; set; }
        public string BaseCurrency { get; set; }        
    }
}
