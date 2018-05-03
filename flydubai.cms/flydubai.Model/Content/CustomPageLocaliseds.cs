using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Custom Page Localised
    /// </summary>
    public class CustomPageLocalised
    {
        [Key, Column(Order = 1)]
        public int CustomPageId { get; set; }

        public string PageName { get; set; }

        [Key, Column(Order = 2)]
        public int LanguageId { get; set; }

        public string Status { get; set; }

        public bool IsRedirect { get; set; }

        public string RedirectUrl { get; set; }
    }
}
