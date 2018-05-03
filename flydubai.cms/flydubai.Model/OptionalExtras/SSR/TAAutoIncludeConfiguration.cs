using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.OptionalExtras.SSR
{
    [Serializable]
   public class TAAutoIncludeConfiguration
    {

        //A-5446 WR7 - Auto Include SSR
        
        public int ID { get; set; }

        public bool TAAutoIncludeMeal { get; set; }

        public bool TAAutoIncludeIFE { get; set; }

        public string MealCode { get; set; }

    }
}
