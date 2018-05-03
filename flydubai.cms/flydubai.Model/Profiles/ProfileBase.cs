using System;

using flydubai.Common;
using flydubai.Model.Profiles;

namespace flydubai.Model.Profiles
{
    /// <summary>
    /// Abstract class Profile Base
    /// </summary>
    [Serializable]
    public abstract class ProfileBase : Human
    {
        public long? ProfileId { get; set; }

        public DateTime CreateDate { get; set; }

        public abstract Enums.ProfileType ProfileType { get; }

        public abstract string LoginUsername { get; set; }

        public string Password { get; set; }

        public int NationalityId { get; set; }
    }
}
