using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Profiles
{
    /// <summary>
    /// Staff Profile
    /// </summary>
    [Serializable]
    public class StaffProfile : ProfileBase
    {
        public override Enums.ProfileType ProfileType
        {
            get { return Enums.ProfileType.Staff; }
        }

        public override string LoginUsername
        {
            get { return this.StaffId; }
            set { this.StaffId = value; }
        }

        public string StaffId { get; set; }
    }
}
