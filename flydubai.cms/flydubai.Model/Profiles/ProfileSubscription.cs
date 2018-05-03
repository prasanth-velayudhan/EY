using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Profiles
{
    /// <summary>
    /// Profile Subscription
    /// </summary>
    [Obsolete("Use SignUpPreferences")]
    [Serializable]
    public class ProfileSubscription
    {
        public int? SubscribePreferenceId { get; set; }

        public int? SmsPreferenceId { get; set; }

        public int? EmailPreferenceId { get; set; }

        public int? LanguagePreferenceId { get; set; }

        public int? Location1PreferenceId { get; set; }

        public int? Location2PreferenceId { get; set; }

        public int? Location3PreferenceId { get; set; }

        public int? PartnersPreferenceId { get; set; }

        public bool Subscribe { get; set; }

        public bool SubscribeViaSms { get; set; }

        public bool SubscribeViaEmail { get; set; }

        public string LanguageCode { get; set; }

        public int? Country1 { get; set; }

        public int? Country2 { get; set; }

        public int? Country3 { get; set; }

        public bool AllowPartners { get; set; }
    }
}
