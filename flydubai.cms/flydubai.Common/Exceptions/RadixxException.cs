using System;

namespace flydubai.Common.Exceptions
{
    /// <summary>
    /// Radixx Exception.
    /// </summary>
    public class RadixxException : ApplicationException
    {
        public readonly Type Type;

        public RadixxException(Type type, Exception innerException)
            : this("Radixx Service Fault", type, innerException)
        {
        }

        public RadixxException(string message, Type type, Exception innerException)
            : base(message, innerException)
        {
            this.Type = type;
        }

        public RadixxException(
            string message, 
            Type type, 
            int radixxExceptionCode, 
            string radixxExceptionSource,
            string flydubaiOperation, 
            string securityGuid,
            string request,
            string responseMessage)
            : base(message)
        {
            this.RadixxExceptionCode = radixxExceptionCode;
            this.RadixxExceptionSource = radixxExceptionSource;
            this.Type = type;
            this.FlyDubaiOperation = flydubaiOperation;
            this.SecurityGuid = securityGuid;
            this.RequestMessage = request;
            this.ResponseMessage = responseMessage;
        }

        public string FlyDubaiOperation { get; set; }

        public int RadixxExceptionCode { get; set; }

        public string RadixxExceptionFormattedCode
        {
            get
            {
                // pad numbers less than 4 chars with leading zeros.
                return "ERR" + (this.RadixxExceptionCode < 10000 ? string.Format("{0:D4}", this.RadixxExceptionCode) : this.RadixxExceptionCode.ToString());
            }
        }

        public string RadixxExceptionSource { get; set; }

        public string SecurityGuid { get; set; }

        public string ProfileId { get; set; }

        public string RequestMessage { get; set; }

        public string ResponseMessage { get; set; }
    }
}
