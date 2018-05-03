using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Survey
{
    /// <summary>
    /// Survey Light Box
    /// </summary>
    public class SurveyLightBox
    {
        [Key]
        public string Language { get; set; }

        [DefaultValue("Would you like to take part in a survey?")]
        [DisplayName("Survey Light box greating label")]
        public string LightBoxLabel { get; set; }

        [DefaultValue("")]
        [DisplayName("Survey Light box content text")]
        public string ContentText { get; set; }

        [DefaultValue("Yes")]
        [DisplayName("Accept survey button text")]
        public string YesButtonText { get; set; }

        [DefaultValue("No")]
        [DisplayName("Do not accept survey button text")]
        public string NoButtonText { get; set; }

        [DisplayName("Locatoin of survey")]
        public string YesButtonUrl { get; set; }

        //[DisplayName("")]
        //public string NoButtonUrl { get; set; }

        public bool IsSurveyActive { get; set; }
    }
}
