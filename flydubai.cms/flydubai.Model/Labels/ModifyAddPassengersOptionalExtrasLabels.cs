using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Add Passengers Optional Extras Labels
    /// </summary>
    public class ModifyAddPassengersOptionalExtrasLabels : BaseLabels
    {
        [DefaultValue("Continue")]
        public string ContinueButton { get; set; }
    }
}
