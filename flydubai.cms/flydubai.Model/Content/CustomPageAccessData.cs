using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    public class CustomPageAccessData
    {
        [Key]
        public int ID { get; set; }

        public int CustomPageID { get; set; }

        public int UserID { get; set; }

        public int AccessLevel { get; set; }

        public string CustomPageName { get; set; }

        public string Url { get; set; }
    }
}
