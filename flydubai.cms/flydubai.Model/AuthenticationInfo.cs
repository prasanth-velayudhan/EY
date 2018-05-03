using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model
{
    /// <summary>
    /// Authentication Info
    /// </summary>
    public class AuthenticationInfo
    {
        public bool IsAuthenticated { get; set; }

        public string AuthenticatedUser { get; set; }

        public string AuthenticatedUserFullName { get; set; }

        public string AuthenticatedRole { get; set; }

        public long ProfileId { get; set; }
    }
}
