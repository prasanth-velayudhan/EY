using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Account Labels
    /// </summary>
    public class MobileAccountLabels : BaseLabels
    {
        public string LogInToYourAccount { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ForgotPassword { get; set; }

        public string LogIn { get; set; }

        public string ResetPassword { get; set; }
        public string YourNewPasswordHasBeenSentToYourEmail { get; set; }

        public string YouHaveLoggedOut { get; set; }
        public string Home { get; set; }

        //duplicate
        public string BackToTop { get; set; }


        public string FrequentFlyerID { get; set; }
        public string RewardsLink { get; set; }
        public string ProfileLink { get; set; }
        public string BookingsLink { get; set; }
        //public string VouchersLink { get; set; }
        public string PointsLink { get; set; }
        public string AboutFrequentFlyer { get; set; }
        public string Invalidcredentials { get; set; }
        public string RememberMe { get; set; }
        public string PointsLabel { get; set; }
        public string RegisterBtn { get; set; }
    }
}
