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
    public class TAUserProfile : AuthenticateTAUser
    {
        //public  Enums.ProfileType ProfileType
        //{
        //    get { return Enums.ProfileType.TravelAgent; }
        //}

        //public override DateTime AccountExpiration
        //{
        //    get { return this.AgencyUser.AccountExpiration; }
        //    set { this.AgencyUser.AccountExpiration = value; }
        //}

    }
}
