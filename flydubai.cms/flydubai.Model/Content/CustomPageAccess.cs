using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Custom Page Access
    /// </summary>
    public class CustomPageAccess
    {
        public CustomPageAccess(CustomPageAccessData Data)
        {
            this.CustomPageID = CustomPageID;
            this.AccessLevel = AccessLevel;
            this.UserID = Data.UserID;
            this.CustomPageName = Data.CustomPageName;
        }
        public int CustomPageID { get; set; }

        public int UserID { get; set; }

        public int AccessLevel { get; set; }

        public string CustomPageName { get; set; }

        public List<CustomPageAccess> PageMapping { get; set; }
    }
}
