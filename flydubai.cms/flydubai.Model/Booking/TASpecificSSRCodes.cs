using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Booking
{
    /// <summary>
    /// TASSRCode
    /// </summary>
    [Serializable]
    public class TASpecificSSRCode
    {
        [Key]
        public int TASSRCodeId { get; set; }

        public string TASSRCode { get; set; }
    }

    [Serializable]
    public class TASSRLabel
    {
        [Key]
        public int RowID { get; set; }

        public string Language { get; set; }

        public string SSRCodeType { get; set; }

        public string Heading { get; set; }

        public string Content { get; set; }

        public string NotSelected { get; set; }

        public string TotalFare { get; set; }

        public string FareFormat { get; set; }
    }
}
