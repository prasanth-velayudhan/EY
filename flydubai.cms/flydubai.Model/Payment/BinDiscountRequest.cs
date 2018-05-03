using flydubai.Model.Payment.PNRPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flydubai.Model.Payment
{
    public class BinDiscount
    {
        public List<CarrierCode> CarrierCodes { get; set; }

        public class RemovePaymentFeeRQ
        {
            public string SecurityGUID { get; set; }
            public CarrierCode[] CarrierCodes { get; set; }
            public string ClientIPAddress { get; set; }
            public string HistoricUserName { get; set; }
            public bool rejectPayment { get; set; }
        }
        public class RejectProcessedPaymetRQ
        {
            public string SecurityGUID { get; set; }
            public CarrierCode[] CarrierCodes { get; set; }
            public string ClientIPAddress { get; set; }
            public string HistoricUserName { get; set; }
            public string ActionType { get; set; }
            public ReservationInfo ReservationInfo { get; set; }
            public string ResponseFrom3DSecure { get; set; }
        }
        public class CpRQ
        {
            public bool CheckPNRStatus { get; set; }
            public ReservationInfo ReservationInfo { get; set; }
            public TransactionInfo TransactionInfo { get; set; }
            public List<flydubai.Model.BookingMW.PNRPayment> PNRPayments { get; set; }
        }
        public class DiscountRequest
        {
            public string channel { get; set; }
            public string agent { get; set; }
            public string agency { get; set; }
            public string creationTime { get; set; }
            public string resCurrency { get; set; }
            public string requestType { get; set; }
            public List<Itinerary> itinerary { get; set; }
            public List<PaxDetail> paxDetails { get; set; }
            public List<Charge> charges { get; set; }
            public List<Payment> payments { get; set; }
        }

        public class PaxSegment
        {
            public string paxId { get; set; }
            public string resStatus { get; set; }
            public string cabinClass { get; set; }
            public string fareClass { get; set; }
            public string fareBasis { get; set; }
        }

        public class Itinerary
        {
            public string segmentId { get; set; }
            public string odId { get; set; }
            public string mrktCarrier { get; set; }
            public string mrktFlightNum { get; set; }
            public string operCarrier { get; set; }
            public string operFlightNum { get; set; }
            public string boardAirport { get; set; }
            public string offAirport { get; set; }
            public string depTime { get; set; }
            public string arrTime { get; set; }
            public string bookedTime { get; set; }
            public List<PaxSegment> paxSegment { get; set; }
        }

        public class PaxDetail
        {
            public string paxId { get; set; }
            public string ptcCode { get; set; }
        }

        public class Charge
        {
            public string chargeId { get; set; }
            public object segmentId { get; set; }
            public string paxId { get; set; }
            public string odId { get; set; }
            public string chargeType { get; set; }
            public double originalAmount { get; set; }
            public double appliedAmount { get; set; }
            public string currency { get; set; }
            public string status { get; set; }
            public string creationTime { get; set; }
        }

        public class Payment
        {
            public string paymentId { get; set; }
            public string bank { get; set; }
            public string fop { get; set; }
            public string fopSubType { get; set; }
            public string cardType { get; set; }
            public string tierLevel { get; set; }
            public string issuingCounty { get; set; }
            public string accNum { get; set; }
        }

        public class CarrierCode
        {
            public string AccessibleCarrierCode { get; set; }
        }

        public class ReservationInfo
        {
            public string SeriesNumber { get; set; }

            public string ConfirmationNumber { get; set; }
        }
    }
}
