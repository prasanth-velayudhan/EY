using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Fare Type
    /// </summary>
    public class FareType
    {
        [Key]
        public int FareTypeId { get; set; }

        public int LanguageId { get; set; }

        public int Index { get; set; }

        public string RowName { get; set; }

        public int? Fare1Image { get; set; }

        public string Fare1ImageUrl { get; set; }

        public string Fare1Description { get; set; }

        public int? Fare2Image { get; set; }

        public string Fare2ImageUrl { get; set; }

        public string Fare2Description { get; set; }

        public int? Fare3Image { get; set; }

        public string Fare3ImageUrl { get; set; }

        public string Fare3Description { get; set; }

        //Fare type Ibs-a 5466
        public int? Fare4Image { get; set; }

        public string Fare4ImageUrl { get; set; }

        public string Fare4Description { get; set; }

        //Fare type Ibs-a 5466
        public int? Fare5Image { get; set; }

        public string Fare5ImageUrl { get; set; }

        public string Fare5Description { get; set; }

        public int? Fare6Image { get; set; }

        public string Fare6ImageUrl { get; set; }

        public string Fare6Description { get; set; }

        //FareBrand changes
        public int? Fare7Image { get; set; }

        public string Fare7ImageUrl { get; set; }

        public string Fare7Description { get; set; }

        public int? Fare8Image { get; set; }

        public string Fare8ImageUrl { get; set; }

        public string Fare8Description { get; set; }

        public int? Fare9Image { get; set; }

        public string Fare9ImageUrl { get; set; }

        public string Fare9Description { get; set; }

        public int? Fare10Image { get; set; }

        public string Fare10ImageUrl { get; set; }

        public string Fare10Description { get; set; }

        public int? Fare11Image { get; set; }

        public string Fare11ImageUrl { get; set; }

        public string Fare11Description { get; set; }

        public int? Fare12Image { get; set; }

        public string Fare12ImageUrl { get; set; }

        public string Fare12Description { get; set; }

        public int? Fare13Image { get; set; }

        public string Fare13ImageUrl { get; set; }

        public string Fare13Description { get; set; }

    }
}
