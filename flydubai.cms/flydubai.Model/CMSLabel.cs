using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;

namespace flydubai.Model
{
    /// <summary>
    /// Booking Label
    /// </summary>
    [Serializable]
    public class BookingLabel
    {
        [Key, Column(Order = 0)]
        public string Key { get; set; }

        [Key, Column(Order = 1)]
        public int WFKey { get; set; }

        [Key, Column(Order = 2)]
        public string Language { get; set; }

        public Wireframe WF
        {
            get
            {
                return (Wireframe)WFKey;
            }
            set
            {
                WFKey = (int)value;
            }
        }

        public string Value { get; set; }
    }

    public enum Wireframe
    {
        FlightSearch = 1,
        FlightResults = 3,
        PassengerDetails = 4,
        OptionalExtras = 5,
        Payment = 6,
        Confirmation = 7
    }
}
