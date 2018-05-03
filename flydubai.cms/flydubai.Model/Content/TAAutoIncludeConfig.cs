using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    //A-5446 WR7 - Auto Include SSR
    public class TAAutoIncludeConfig
    {
        [Key]
        public int ID { get; set; }

        public bool TAAutoIncludeMeal { get; set; }

        public bool TAAutoIncludeIFE { get; set; }

        public string MealCode { get; set; }

        public string WrapMealCode { get; set; }
    }
}
