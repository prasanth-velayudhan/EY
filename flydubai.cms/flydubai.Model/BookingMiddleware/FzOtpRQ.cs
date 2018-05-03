using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace flydubai.Model.BookingMiddleware
{
    public class FzOtpRQ
    {
        public ReservationInfo ReservationInfo { get; set; }
        public string SecurityGUID { get; set; }
        public List<CarrierCode> CarrierCodes { get; set; }
        public string ClientIPAddress { get; set; }
        public string ReservationChannelType { get; set; }
    }

    public class FzOtpRS
    {
        public bool OtpSendStat { get; set; }
        public List<OtpException> Exceptions { get; set; }
    }

    public class OtpException
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public OtpExceptionLevels ExceptionLevel { get; set; }
    }

    public enum OtpExceptionLevels : int
    { Success = 0, Warning = 1, Critical = 2, }
}
