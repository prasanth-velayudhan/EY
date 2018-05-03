namespace flydubai.Model.Mobile
{
    using System.ComponentModel;

    /// <summary>
    /// Mobile Contact Us Labels
    /// </summary>
    public class MobileContactUsLabels : BaseLabels
    {
        public string IAmCallingFrom { get; set; }

        public string SelectCountry { get; set; }

        public string SelectCity { get; set; }

        public string SelectService { get; set; }

        public string GetContactNumber { get; set; }

        public string FilterCities { get; set; }

        public string ServiceRequired { get; set; }
        
        public string CallingFromCity { get; set; }

        public string FlyDubaiCallCentre { get; set; }

        public string FlyDubaiContactNumber { get; set; }

        public string NoCallCentresFoundForThisCountry { get; set; }

        public string NoTravelPartnersFoundForThisCity { get; set; }

        public string NoPaymentPartnersFoundInThisCity { get; set; }

        public string PaymentPartners { get; set; }

        //WR8 WR-109 
        public string NoCallCentresFoundForUAE { get; set; }
    }
}
