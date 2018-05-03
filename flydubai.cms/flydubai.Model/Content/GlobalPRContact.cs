using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Global PR Contact
    /// </summary>
    public class GlobalPRContact : EntityBase<GlobalPRContact, GlobalPRContactVersion>
    {
        public int GlobalPRContactId { get; set; }

        public override int Id
        {
            get { return GlobalPRContactId; }
            set { GlobalPRContactId = value; }
        }
    }
}
