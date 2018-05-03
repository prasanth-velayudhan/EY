using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Booking
{
    /// <summary>
    /// Seat Mapping
    /// </summary>
    [Serializable]
    public class SeatMapping
    {
        [Key]
        public string FlightNo { get; set; }
        public string FlightType { get; set; }
        public string Cabin { get; set; }
    }
}
