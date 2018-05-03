using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Content.Analytics
{
    /// <summary>
    /// Google Analytics
    /// </summary>
    [Serializable]
    public class GoogleAnalytics
    {
        [Key]
        public int VersionId { get; set; }

        
        [DisplayName("Google analytics For every page.")]
        public string RegularAnalytics { get; set; }

        
        [DisplayName("Google analytics only For confirmation page.")]
        public string ConfirmationAnalytics { get; set; }

        
        [DisplayName("Google analytics only For payment page.")]
        public string PaymentAnalytics { get; set; }

        
        [DisplayName("Google tag manager for every page.")]
        public string EverypageAnalytics { get; set; }
    }
}
