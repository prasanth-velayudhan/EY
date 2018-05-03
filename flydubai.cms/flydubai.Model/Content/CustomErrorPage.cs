using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    using System.Net;

    /// <summary>
    /// Custom Error Page
    /// </summary>
    public class CustomErrorPage
    {
        [Key]
        public int CustomErrorPageId { get; set; }

        [Required]
        public int HttpStatusCode { get; set; }

        [Required]
        public string PageTitle { get; set; }

        [Required]
        public string PageHeading { get; set; }

        [Required]
        public string UserMessageHtml { get; set; }

        public bool LinkToExistingPages { get; set; }

        public DateTime LastUpdated { get; set; }

        public string NavigationTitleText { get; set; }

        [Required]
        public int LanguageId { get; set; }
    }
}
