using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Profiles
{
    /// <summary>
    /// User Profile
    /// </summary>
    [Serializable]
    public class UserProfile : ProfileBase
    {
        public override Enums.ProfileType ProfileType
        {
            get { return Enums.ProfileType.User; }
        }

        public override string LoginUsername
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
    }
}
