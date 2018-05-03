using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Careers Labels
    /// </summary>
    public class CareersLabels : LabelsBase
    {
        [Key]
        public int CareersLabelsId { get; set; }

        [DefaultValue("View latest vacancies")]
        public string ViewLatestVacancies { get; set; }

        [DefaultValue("Latest vacancies")]
        public string LatestVacanciesTitle { get; set; }
    }
}
