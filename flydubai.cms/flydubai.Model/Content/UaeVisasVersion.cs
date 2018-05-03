using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using flydubai.Model.Content;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Uae Visas Version
    /// </summary>
    public class UaeVisasVersion : EntityVersionBase<UaeVisas, UaeVisasVersion>
    {
        [Key]
        public int HowToApplyUaeVisasVersionId { get; set; }

        public override int Id
        {
            get { return this.HowToApplyUaeVisasVersionId; }
            set { this.HowToApplyUaeVisasVersionId = value; }
        }

        public string Title { get; set; }

        public string DescriptionHtml { get; set; }

        public string ApplicationFormFileName { get; set; }

        public string ApplicationFormDownloadFileName { get; set; }
    }
}
