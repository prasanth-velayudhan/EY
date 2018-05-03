using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    [Serializable]
    public class SessionMessage
    {
        [Key]
        public int SessionMessageID { get; set; }

        [Required]
        public string SessionOutMessage { get; set; }

        [Required]
        public int Language { get; set; }

        [Required]
        public int TA { get; set; }
    }
}
