using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model
{
    /// <summary>
    /// City Localised
    /// </summary>
    public class CityLocalised
    {
        [Key]
        public int LocalisedCityId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public City City { get; set; }

    }
}
