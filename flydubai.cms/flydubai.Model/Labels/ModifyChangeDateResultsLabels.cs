using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Modify Change Date Results Labels
    /// </summary>
    public class ModifyChangeDateResultsLabels : BaseLabels
    {
        [DefaultValue("Current sector")]
        public string CurrentSectorTitleText { get; set; }

        [DefaultValue("Choose sector and continue")]
        public string ChooseSectorAndContinueButton { get; set; }
    }
}
