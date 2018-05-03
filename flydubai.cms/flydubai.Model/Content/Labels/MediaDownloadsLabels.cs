using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Media Downloads Labels
    /// </summary>
    public class MediaDownloadsLabels : LabelsBase
    {
        [Key]
        public int MediaDownloadsLabelsId { get; set; }

        [DefaultValue("Media downloads")]
        public string Title { get; set; }

        [DefaultValue("Media pack")]
        public string MediaPack { get; set; }

        [DefaultValue("Official statement from flydubai CEO")]
        public string OfficialStatement { get; set; }
    }
}
