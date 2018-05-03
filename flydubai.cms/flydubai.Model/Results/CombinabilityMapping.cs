using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Results
{
    [Serializable]
    public class CombinabilityMapping
    {
        public object[] SolutionRefID { get; set; }

        public int idField { get; set; }
    }
}
