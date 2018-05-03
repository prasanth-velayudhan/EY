using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Profiles
{
    [Serializable]
    public class TAProfile : ProfileBase
    {
        public override Enums.ProfileType ProfileType
        {
            get { return Enums.ProfileType.TravelAgent; }
        }

        public override string LoginUsername
        {
            get { return this.Username; }
            set { this.Username = value; }
        }

        public string Username { get; set; }

        public string IataNum { get; set; }
    }
}
