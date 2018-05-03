using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Network With Us Labels
    /// </summary>
    public class NetworkWithUsLabels : LabelsBase
    {
        [Key]
        public int NetworkWithUsLabelsId { get; set; }

        [DefaultValue("Network with us")]
        public string ModuleTitle { get; set; }

        [DefaultValue("Facebook")]
        public string Facebook { get; set; }

        [DefaultValue("Twitter")]
        public string Twitter { get; set; }

        [DefaultValue("RSS")]
        public string Rss { get; set; }

        [DefaultValue("Flickr")]
        public string Flickr { get; set; }

        [DefaultValue("YouTube")]
        public string YouTube { get; set; }
    }
}
