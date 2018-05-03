using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Change Date Optional Extras Labels
    /// </summary>
    public class ModifyChangeDateOptionalExtrasLabels : BaseLabels
    {
        [DefaultValue("New sector")]
        public string NewSectorTableHeading { get; set; }

        [DefaultValue("Continue")]
        public string ContinueButton { get; set; }
    }
}
