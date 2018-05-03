using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Shared Labels
    /// </summary>
    public class SharedLabels : BaseLabels
    {
        [DefaultValue("Close")]
        public string CloseLightboxText { get; set; }
    }
}
