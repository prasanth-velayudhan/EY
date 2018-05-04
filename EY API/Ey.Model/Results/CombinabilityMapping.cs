using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model.Results
{
    [Serializable]
    public class CombinabilityMapping
    {
        public object[] SolutionRefID { get; set; }

        public int idField { get; set; }
    }
}
