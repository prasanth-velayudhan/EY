using System;
using System.Xml.Serialization;

namespace flydubai.Model.Payment
{
    using flydubai.Model.Journey;

    /// <summary>
    /// Payment Details
    /// </summary>
    [Serializable]
    public class PaymentDetails
    {
        public string CardHolderName { get; set; }

        [XmlIgnore]
        public string CardNumber { get; set; }

        public string CardType { get; set; }

        public string SecurityNumber { get; set; }

        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }

        public Price Amount { get; set; }

        public JourneyPassenger Payor { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        public string CountryCode { get; set; }

        public string CountryCodeIsoNumeric { get; set; }

        public string FrequentFlyerNumber { get; set; }

        public string Suffix { get; set; }

        public string PaymentMethod { get; set; }
    }
}
