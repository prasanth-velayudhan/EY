using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Operational Update
    /// </summary>
    public class OperationalUpdate
    {
        [Key]
        public int OperationalUpdateId { get; set; }

        public string Language { get; set; }

        public string IconCssClass { get; set; }

        public string Message { get; set; }

        public bool VisibleOnContentWebsite { get; set; }

        public bool VisibleToRegisteredUsers { get; set; }

        public bool VisibleToTravelAgents { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateModified { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateDeleted { get; set; }

        public bool IsDeleted { get; set; }
    }
}
