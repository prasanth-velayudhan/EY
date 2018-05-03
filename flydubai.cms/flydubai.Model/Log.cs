namespace flydubai.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Log
    /// </summary>
    [Serializable]
    [Table("Log")]
    public class Log
    {
        public int Id { get; set; }

        public string ExceptionKey { get; set; }

        public DateTime Date { get; set; }

        public string Level { get; set; }

        public string URL { get; set; }

        public string Operation { get; set; }

        public string RadixxExceptionCode { get; set; }

        public string RadixxExceptionSource { get; set; }

        public string Request { get; set; }

        public string SecurityGuid { get; set; }

        public string Message { get; set; }

        public string Exception { get; set; }

        public string ProfileType { get; set; }

        public string ProfileId { get; set; }

        public string Email { get; set; }

        public string ServerName { get; set; }

        public string PNR { get; set; }

        public string WcfServiceName { get; set; }

        public string WcfServiceTotalSeconds { get; set; }

        public string PageName { get; set; }

        public string Response { get; set; }

        public string ClientIPAddress { get; set; }

        public string ErrorCode { get; set; }

        public string IATA { get; set; }
    }
}
