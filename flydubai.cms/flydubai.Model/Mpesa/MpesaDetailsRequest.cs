using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flydubai.Model.Mpesa
{
    [Serializable]
    public class MpesaDetails
    {
        public class ReservationBalance
        {
            public string Amount { get; set; }
            public string Currency { get; set; }
        }

        public class PaymentInfo
        {
            public string PaymentType { get; set; }
            public string AccountNumber { get; set; }
        }

        public class PassengerTypeSummary
        {
            public string NumberOfAdults { get; set; }
            public string NumberOfChilds { get; set; }
            public string NumberOfInfants { get; set; }
        }

        public class OriginDestination
        {
            public string Origin { get; set; }
            public string Destination { get; set; }
            public string FltNum { get; set; }
            public string DepDate { get; set; }
        }

        public class ItineraryInfo
        {
            public List<OriginDestination> OriginDestination { get; set; }
        }

        public class PricePNRForPaymentRQ
        {
            public string GUID { get; set; }
            public string FormOfPayment { get; set; }
            public string PaymentCurrency { get; set; }
            public ReservationBalance ReservationBalance { get; set; }
            public PaymentInfo PaymentInfo { get; set; }
            public PassengerTypeSummary PassengerTypeSummary { get; set; }
            public string FfpNumber { get; set; }
            public List<OriginDestination> ItineraryInfo { get; set; }
        }
    }
}
