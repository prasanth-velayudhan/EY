using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.BookingMW
{
    public class Customer
    {
        public string Key { get; set; }
        public List<AirlinePerson> AirlinePersons { get; set; }
    }
}
