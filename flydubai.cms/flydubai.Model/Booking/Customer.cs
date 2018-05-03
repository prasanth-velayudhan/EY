using System;

namespace flydubai.Model.Booking
{
    using System.Collections.Generic;

    /// <summary>
    /// Customer
    /// </summary>
    [Serializable]
    public class Customer
    {
        public string Key { get; set; }

        public List<AirlinePerson> AirlinePersons { get; set; }
    }
}