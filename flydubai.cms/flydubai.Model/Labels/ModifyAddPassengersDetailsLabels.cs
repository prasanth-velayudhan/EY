using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Add Passengers Details Labels
    /// </summary>
    public class ModifyAddPassengersDetailsLabels : BaseLabels
    {
        [DefaultValue("Additional passenger details")]
        public string AdditionalPassengerDetailsTitleText { get; set; }

        [DefaultValue("Continue")]
        public string ContinueButton { get; set; }

        [DefaultValue("Head Member Notification")]
        public string HeadMemberNotification { get; set; }
    }
}
