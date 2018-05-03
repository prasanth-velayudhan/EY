using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model
{
    [Serializable]
    public class AiportUpdatedDateTime
    {
        [Key]
        public int Id { get; set; }

        public DateTime UpdatedRefreshDateTime { get; set; }
    }
}
