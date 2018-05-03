using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Beta
{
    /// <summary>
    /// Intercept Light Box Model
    /// </summary>
    public class InterceptLightBox
    {
        [Key]
        public string Language { get; set; }

        [DefaultValue("Would you like to try our new website?")]
        [DisplayName("Beta Light box greating label")]
        public string LightBoxLabel { get; set; }

        [DefaultValue("We’re trailing our new and improved booking process. It’s fast, secure and easy. We’d like you to try it out and give us a little feedback.")]
        [DisplayName("Beta Light box greating content")]
        public string ContentText { get; set; }

        [DefaultValue("Yes")]
        [DisplayName("Accept Trial button text")]
        public string YesButtonText { get; set; }

        [DefaultValue("No")]
        [DisplayName("Do not accept trial button text")]
        public string NoButtonText { get; set; }
    }
}
