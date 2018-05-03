using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flydubai.Model.ExternalPricing
{
   public class InterlineAgrementsRS
    {
        public List<InterlineAgreement> interlineAgreements { get; set; }
        public List<InterlineException> exceptions { get; set; }

    }
    public class InterlineException
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public int ExceptionLevel { get; set; }
    }
    public class AgreementParameter
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class InterlineAgreement
    {
        public string carrierCode { get; set; }
        public string agreementType { get; set; }
        public string agreementDate { get; set; }
        public string agreementEffectiveDate { get; set; }
        public List<AgreementParameter> agreementParameters { get; set; }
    }




}
