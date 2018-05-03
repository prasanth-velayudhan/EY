using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Custom Page
    /// </summary>
    public class CustomPage
    {
        [Key]
        public int CustomPageId { get; set; }

        public string MasterPage { get; set; }

        public string Template { get; set; }

        [Required(ErrorMessage = "Url is required")]
        public string Url { get; set; }

        public string WebsiteSection { get; set; }

        public string SecondarySection { get; set; }


    }
}
